// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;
//Don't has owner
import "@openzeppelin/contracts/token/ERC20/IERC20.sol";

contract Seed_Sale {

  mapping(address => uint) private _balance;

  uint public constant vestingPorcentage = 30;
  uint public constant min = 1*10**17 wei;
  uint public constant max = 200*10**18 wei;    
  uint32 public lastDayToBuy;
  address immutable val;
  IERC20 VAL;  

  constructor(address _val) {
    val = _val;
  }

  

}
