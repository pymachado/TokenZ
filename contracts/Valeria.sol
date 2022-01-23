// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

/**
  @author Pedro Machado
  @title VALERIA TOKEN
  @notice Governanza Token
  @custom:address 0x0d652741d37d0FC70F17c923DD4de9eAdF02D6B2
  @custom:genesisBlock 16123981
 */


import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
import "@openzeppelin/contracts/access/Ownable.sol";

contract Valeria is ERC20, Ownable {
  constructor() ERC20("VALERIA", "VAL") {
    _mint(owner(), 29102021*10**decimals());
  }
}
