// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

/**
  @author Pedro Machado
  @title VALERIA TOKEN
  @notice Governanza Token
  @custom:address 0x0d652741d37d0FC70F17c923DD4de9eAdF02D6B2
  @custom:address2 0xDFaeC40c11A98E3765e0Fab58888A1134e6Ac057
  @custom:genesisBlock 16123981
 */


import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
import "@openzeppelin/contracts/access/Ownable.sol";
import "./ItMaps.sol";

contract Valeria is ERC20, Ownable {
  using IterableMap for IterableMap.SpecialAddress;

 IterableMap.SpecialAddress private spa;

  //add function that give permits to wallet. 
  //get totalAccBy(user);

  struct SNAPSHOT {
    uint64 firstTx;
    uint dailyVolume;
  }

  mapping (address => SNAPSHOT) private _snapshot;

  constructor() ERC20("VALERIA", "VAL") {
    exludeFromMaxToTransfer(_msgSender());
    exludeFromMaxToTransfer(address(0));
    _mint(_msgSender(), 29102021*10**decimals());
  }

  function maxAmountByTx() public view returns (uint){
    return 3056*10**decimals();
  }

  function exludeFromMaxToTransfer(address user) public onlyOwner {
    spa.insert(user);
  }

  //if the element exist exclude. 
  function includeToMaxToTransfer(address user) public onlyOwner {
    spa.remove(user);
  }

  function isSpecialAddress(address user) public view returns(bool) {
    return spa.contains(user);
  }

  function totalSpecialAddress() public view returns(uint) {
    return spa._length();
  }

  function get_AccToDay(address user) public view returns(uint) {
    return _snapshot[user].dailyVolume;
  }

  function _beforeTokenTransfer( address from, address , uint256 amount) internal override {
    if (! spa.contains(from)) {
      require(amount <= maxAmountByTx());
      uint timeStamp = block.timestamp - uint(_snapshot[from].firstTx);
      if (timeStamp / 1 minutes > 5) {//1440 minutes once deploy is done 
        _snapshot[from].dailyVolume = 0;
        _snapshot[from].firstTx = uint64(block.timestamp);
      }
      else if (_snapshot[from].dailyVolume + amount > maxAmountByTx() ) {
        revert();
      }
      
    }

  }

  function _afterTokenTransfer(address from, address , uint256 amount) internal override {    
      if (! spa.contains(from)) {
        _snapshot[from].dailyVolume += amount;
      }
    } 
}
