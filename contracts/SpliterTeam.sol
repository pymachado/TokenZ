// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

import "@openzeppelin/contracts/access/Ownable.sol";
import "@openzeppelin/contracts/token/ERC20/IERC20.sol";
import "./ABDKMath64x64.sol";

contract SpliterTeam is Ownable{
  uint[3] setCategoryBalance;
  uint[3] setCategoryAccumalated;

  uint periodVestingTime;
  uint totalReleased;
   
  struct TEMPLATE {
    address beneficiary;
    uint amount;
    uint category;
    uint vestingTime;
    uint dailyIssue;
    uint startDate;
    uint lastClaim;
  }

  mapping (address => TEMPLATE) user;
  address valeria; 
  IERC20 VAL;


  constructor(address _valeria, uint _balanceOfMarketing, uint _balanceOfTeams, uint _balanceOfConsultants) {
    valeria = _valeria;
    setCategoryBalance[0] = _balanceOfMarketing;
    setCategoryBalance[1] = _balanceOfTeams;
    setCategoryBalance[2] = _balanceOfConsultants;
    VAL = IERC20(valeria);
  }

  function insertListOf(uint category, TEMPLATE[] memory _subwhitelist) external onlyOwner returns(bool) {
      for (uint8 i = 0; i <_subwhitelist.length; i++) {
        user[_subwhitelist[i].beneficiary] = TEMPLATE(
          _subwhitelist[i].beneficiary, 
          _subwhitelist[i].amount, 
          category, 
          (block.timestamp + 540 * 1 days), 
          ABDKMath64x64.mulu(ABDKMath64x64.inv(ABDKMath64x64.fromUInt(540)), _subwhitelist[i].amount), 
          block.timestamp, 
          block.timestamp);
        setCategoryAccumalated[category] += _subwhitelist[i].amount;
        _checkAmount(setCategoryAccumalated[category], setCategoryBalance[category]);  
      }
    return true;
  }

  function addProfitToBeneficiary(address _beneficiary, uint _amount) external onlyOwner returns (bool){
    user[_beneficiary].amount += _amount;
    setCategoryAccumalated[user[_beneficiary].category] += _amount;
    require(setCategoryAccumalated[user[_beneficiary].category] <= setCategoryBalance[user[_beneficiary].category], "Error: Amount added exceeds the category balance.");
    return true;
  }

  function subProfitToBeneficiary(address _beneficiary, uint _amount) external onlyOwner returns(bool) {
    require(_amount <= user[_beneficiary].amount);
    setCategoryAccumalated[user[_beneficiary].category] -= _amount;
    return true;
  }

  function getTotalBalanceForDistribuition() external view returns(uint) {
    return VAL.balanceOf(address(this));
  }

  function accumulatedRelease() external view returns (uint) { 
      return user[msg.sender].dailyIssue * daysPassed(user[msg.sender].startDate); 
  }

  function toRelease() external view returns(uint) {
    return user[msg.sender].amount;
  }

  function totalClaimed() external view returns(uint) {
    uint validDaysToPay = daysPassed(user[msg.sender].startDate) - (daysPassed(user[msg.sender].startDate) % 30);
    return user[msg.sender].dailyIssue * validDaysToPay;
  }

  function claim() external returns(bool) {
    require(daysPassed(user[msg.sender].startDate) > 30, "Error: Wait at least after first 30 days.");
    uint validDaysToPay = daysPassed(user[msg.sender].lastClaim) - (daysPassed(user[msg.sender].lastClaim) % 30);
    user[msg.sender].amount -= user[msg.sender].dailyIssue * validDaysToPay;
    require(user[msg.sender].amount > 0, "Error: Funds had been claimed.");
    VAL.transfer(msg.sender, user[msg.sender].dailyIssue * validDaysToPay);
    user[msg.sender].lastClaim = block.timestamp;
    return true;
  }

  function daysPassed(uint startDate) private view returns(uint) {
    require(startDate <= block.timestamp);
    require(540 - ((block.timestamp - startDate) * 1 days) > 0, "Time is over.");
    return (block.timestamp - startDate) * 1 days;
  }

  function _checkAmount(uint _check, uint _amount) private pure {
      if(_check > _amount) {
        revert("Error: checkAmount exceeds Destination's balance");
      }

  }
  
}
