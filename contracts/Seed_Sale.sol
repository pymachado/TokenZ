// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

/**
  @author Pedro Machado
  @title SEED_SALE
  @notice Contract designing to launch a private sale ERC20 token.
 */

import "@openzeppelin/contracts/token/ERC20/IERC20.sol";
import "@openzeppelin/contracts/access/Ownable.sol";
import "./ABDKMath64x64.sol";

contract Seed_Sale is Ownable {

  mapping(address => uint) private _balance;

  int128 public constant dailyVesting = 184467440700000000; //1% converted to fixed64x64
  uint public constant rate = 7440;
  uint public constant min = 1*10**17 wei; 
  uint public constant max = 5*10**18 wei;
  uint public constant goal = 200*10**18 wei;
  uint public lastDayToBuy;
  address immutable val;
  address public constant burnAddress = 0x000000000000000000000000000000000000dEaD;
  IERC20 VAL;  

  event CLAIMED(address claimer, uint amount, uint date);
  event RECEIVED(address claimer, uint amountBNB, uint amountVAL);

  constructor(address _val) {
    val = _val;
    lastDayToBuy = block.timestamp + 1 weeks;
  }


  receive() external payable {
    require(address(this).balance < goal, "SEED_SALE: We did it :)");
    require(block.timestamp <= lastDayToBuy, "SEED_SALE: Error over date to buy.");
    require(msg.value >= min && msg.value <= max, "SEED_SALE: Error in value receiving");
    _balance[msg.sender] += msg.value * rate;
    emit RECEIVED(msg.sender, msg.value, msg.value * rate);
  }

  function claim() external {
    require(_balance[msg.sender] !=0, "SEED_SALE: You don't have funds");
    require(daysPassed(lastDayToBuy) >= 30, "SEED_SALE: You have to wait at least one vesting period.");
    uint validDaysToPay = daysPassed(lastDayToBuy) - (daysPassed(lastDayToBuy) % 30);
    uint valueToPay = ABDKMath64x64.mulu(dailyVesting, _balance[msg.sender]) * validDaysToPay;
    _balance[msg.sender] -= valueToPay;
    VAL = IERC20(val);
    VAL.transfer(msg.sender, valueToPay);
    emit CLAIMED(msg.sender, valueToPay, block.timestamp);
  }

  function withdraw(uint amount) external onlyOwner {
    require(block.timestamp >= lastDayToBuy + 1 days, "SEED_SALE: error");
    require(amount <= address(this).balance);
    payable(owner()).transfer(amount);
  }

  function burnRemaining() external onlyOwner {
    require(block.timestamp >= lastDayToBuy + 1 days, "SEED_SALE: error");
    require(VAL.balanceOf(address(this)) != 0, "SEED_SALE: error");
    VAL.transfer(burnAddress, VAL.balanceOf(address(this)));
    emit CLAIMED(burnAddress, VAL.balanceOf(address(this)), block.timestamp);
  }

  function pendingToClaimOf(address claimer) external view returns(uint) {
    return _balance[claimer];
  }

  function releasedOf(address claimer) external view returns(uint) {
    return ABDKMath64x64.mulu(dailyVesting, _balance[claimer]) * daysPassed(lastDayToBuy);
  }

  function daysPassed(uint startDate) private view returns(uint) {
    require(90 - ((block.timestamp - startDate) / 1 days) > 0, "Time is over.");
    return (block.timestamp - startDate) / 1 days;
  }


}
