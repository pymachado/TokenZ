// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
contract Valeria is ERC20 {
  constructor(address recipient) ERC20("VALERIA", "VAL") {
    _mint(recipient, 29102021);
  }
}
