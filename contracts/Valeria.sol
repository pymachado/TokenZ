// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
import "@openzeppelin/contracts/access/Ownable.sol";
contract Valeria is ERC20, Ownable {
  constructor() ERC20("VALERIA", "VAL") {
    _mint(owner(), 29102021*10**decimals());
  }
}
