// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

/**
  @author Pedro Machado
  @title SEED_SALE
  @notice Contract designing to launch an ERC20 private-sale-token with vesting time. 
 */

import "@openzeppelin/contracts/token/ERC20/IERC20.sol";
import "@openzeppelin/contracts/access/Ownable.sol";

contract Seed_Sale is Ownable {

  struct Investor {
    uint _allocation;
    uint _released;
    uint64 _lastDateClaimed;
  }

  mapping (address => Investor) private _investor;


  uint public constant min = 2*10**18 wei; 
  uint public constant max = 5*10**18 wei;
  uint public goal;
  uint64 public startDateToBuy; //UNIX format
  uint64 public lastDayToBuy; //UNIX format
  uint16 public constant rate = 1000; 
  uint8 vestingEpoch; //sampling period
  address immutable erc20;
  address public constant burnAddress = 0x000000000000000000000000000000000000dEaD;
  
  event CLAIMED(address claimer, uint amount, uint date);
  event RECEIVED(address claimer, uint amountBNB, uint amountVAL);

  constructor(address _token, uint64 startDate, uint64 endDate, uint8 vestingTime) {
    //address erc20
    erc20 = _token;
    //Private duration
    startDateToBuy = startDate;
    lastDayToBuy = endDate;
    //Vesting time
    vestingEpoch = vestingTime;
  }


  receive() external payable {
    require(goal + msg.value <= address(this).balance , "SEED_SALE: We did it :)");
    require(block.timestamp >= startDateToBuy && block.timestamp <= lastDayToBuy, "SEED_SALE: Error over date to buy.");
    require(msg.value >= min && msg.value <= max, "SEED_SALE: Error in value receiving");
    _investor[msg.sender]._allocation += msg.value * rate;
    _investor[msg.sender]._lastDateClaimed = lastDayToBuy; //lastDateClaimed is inicialized at lastDayToBuy;
    goal += msg.value;
    emit RECEIVED(msg.sender, msg.value, msg.value * rate);
  }

  function claim() external { 
    require(pendingToRelease(msg.sender) != 0, 'There is nothing to release.');
    IERC20 TOKEN;
    TOKEN = IERC20(erc20);
    TOKEN.transfer(msg.sender, pendingToRelease(msg.sender));
    _investor[msg.sender]._lastDateClaimed = uint64(block.timestamp);
    _investor[msg.sender]._released += pendingToRelease(msg.sender);
    emit CLAIMED(msg.sender, pendingToRelease(msg.sender), block.timestamp);

  }

  function pendingToRelease(address claimer) public view returns(uint) {
    if (_investor[claimer]._allocation - released(claimer) != 0) {
      uint epoch = duration(claimer) / vestingEpoch;
      return calculeToRelease(claimer, epoch);
    }
    else {
      return 0;
    }
  }

  function totalAllocation() public view returns(uint) {
    IERC20 TOKEN;
    TOKEN = IERC20(erc20);
    return TOKEN.balanceOf(address(this));
  }

  function toRelease(address claimer) public view returns(uint) {
    return _investor[claimer]._allocation - released(claimer);
  }

  function released(address claimer) public view returns(uint) {
    return _investor[claimer]._released;
  }

  function vestingAmount(address claimer) public view returns(uint) {
    return (vestingPorcentage() * _investor[claimer]._allocation) / 100;  
  }

  function vestingPorcentage() public pure returns(uint8) {
    return 25;
  }

  function calculeToRelease(address claimer, uint epoch) private view returns(uint) {
    return vestingAmount(claimer) * epoch - released(claimer);
  }

  function duration(address claimer) private view returns (uint) {
    return (block.timestamp - _investor[claimer]._lastDateClaimed) / 1 minutes;
  }

}
