// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

import "@openzeppelin/contracts/access/Ownable.sol";
import "@openzeppelin/contracts/token/ERC20/IERC20.sol";

contract SpliterTeam is Ownable{
  uint[3] setCategoryBalance;
  uint[3] setCategoryAccumalated;

  uint periodVestingTime;
  uint totalReleased;
  
  struct TEMPLATE {
    address beneficiary;
    uint amount;
    uint vestingTime;
  }

  mapping (uint => mapping(address => uint)) setBeneficiaryByCategory;
  mapping (address => uint) vestingTimes;
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
        setBeneficiaryByCategory[category][_subwhitelist[i].beneficiary] += _subwhitelist[i].amount;
        setCategoryAccumalated[category] += _subwhitelist[i].amount;
        vestingTimes[_subwhitelist[i].beneficiary] = (block.timestamp + _subwhitelist[i].vestingTime) / 1 days;
        _checkAmount(setCategoryAccumalated[category], setCategoryBalance[category]);  
      }
    return true;
  }

  function addProfitToBenefociary(uint category, address _beneficiary, uint _amount) external onlyOwner returns (bool){
    setBeneficiaryByCategory[category][_beneficiary] += _amount;
    setCategoryAccumalated[category] += setBeneficiaryByCategory[category][_beneficiary];
    require(setCategoryAccumalated[category] <= setCategoryBalance[category], "Error: Amount added exceeds the category balance.");
    return true;
  }

  function subProfitToBenefociary(uint category, address _beneficiary, uint _amount) external onlyOwner returns(bool) {
    require(_amount <= setBeneficiaryByCategory[category][_beneficiary]);
    setBeneficiaryByCategory[category][_beneficiary] -= _amount;
    setCategoryAccumalated[category] -= setBeneficiaryByCategory[category][_beneficiary];
    return true;
  }

  function getTotalBalanceOfDistribuition() external view returns(uint) {
    return VAL.balanceOf(address(this));
  }

  function releasedOf(address beneficiary) external view returns (uint) {
      // que pasa en el final del vesintg time, debe dar 540 
  }

  function _checkAmount(uint _check, uint _amount) private pure {
      if(_check > _amount) {
        revert("Error: checkAmount exceeds Destination's balance");
      }

  }
  
}
