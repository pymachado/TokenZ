// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

/**
  @author Pedro Machado
  @title VALERIA TOKEN
  @notice Governanza Token
  @custom:address 0x0d652741d37d0FC70F17c923DD4de9eAdF02D6B2
  @custom:address2 0xDFaeC40c11A98E3765e0Fab58888A1134e6Ac057
  @custom:address3 0x27b9A920508442D5a6e40Da63f05e78C8a7d7BB5
  @custom:genesisBlock 16123981
 */


import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
import "@openzeppelin/contracts/access/Ownable.sol";
import "./ItMaps.sol";

interface IUniswapV2Pair {
    event Approval(address indexed owner, address indexed spender, uint value);
    event Transfer(address indexed from, address indexed to, uint value);

    function name() external pure returns (string memory);
    function symbol() external pure returns (string memory);
    function decimals() external pure returns (uint8);
    function totalSupply() external view returns (uint);
    function balanceOf(address owner) external view returns (uint);
    function allowance(address owner, address spender) external view returns (uint);

    function approve(address spender, uint value) external returns (bool);
    function transfer(address to, uint value) external returns (bool);
    function transferFrom(address from, address to, uint value) external returns (bool);

    function DOMAIN_SEPARATOR() external view returns (bytes32);
    function PERMIT_TYPEHASH() external pure returns (bytes32);
    function nonces(address owner) external view returns (uint);

    function permit(address owner, address spender, uint value, uint deadline, uint8 v, bytes32 r, bytes32 s) external;

    event Mint(address indexed sender, uint amount0, uint amount1);
    event Burn(address indexed sender, uint amount0, uint amount1, address indexed to);
    event Swap(
        address indexed sender,
        uint amount0In,
        uint amount1In,
        uint amount0Out,
        uint amount1Out,
        address indexed to
    );
    event Sync(uint112 reserve0, uint112 reserve1);

    function MINIMUM_LIQUIDITY() external pure returns (uint);
    function factory() external view returns (address);
    function token0() external view returns (address);
    function token1() external view returns (address);
    function getReserves() external view returns (uint112 reserve0, uint112 reserve1, uint32 blockTimestampLast);
    function price0CumulativeLast() external view returns (uint);
    function price1CumulativeLast() external view returns (uint);
    function kLast() external view returns (uint);

    function mint(address to) external returns (uint liquidity);
    function burn(address to) external returns (uint amount0, uint amount1);
    function swap(uint amount0Out, uint amount1Out, address to, bytes calldata data) external;
    function skim(address to) external;
    function sync() external;

    function initialize(address, address) external;
}

interface IUniswapV2Factory {
    event PairCreated(address indexed token0, address indexed token1, address pair, uint);

    function feeTo() external view returns (address);
    function feeToSetter() external view returns (address);

    function getPair(address tokenA, address tokenB) external view returns (address pair);
    function allPairs(uint) external view returns (address pair);
    function allPairsLength() external view returns (uint);

    function createPair(address tokenA, address tokenB) external returns (address pair);

    function setFeeTo(address) external;
    function setFeeToSetter(address) external;
}

contract Valeria is ERC20, Ownable {
  using IterableMap for IterableMap.SpecialAddress;

 IterableMap.SpecialAddress private spa;
 IUniswapV2Pair pair;
 IUniswapV2Factory factory;

 uint public frozenTime;
 uint public maxAmountByTx;
 uint public startTime;
 uint public lockTime;
 bool public flagUnlock;
 address public addressPair;
 //Pancake Testnet's Factory
 address constant public addressFactory = 0xB7926C0430Afb07AA7DEfDE6DA862aE0Bde767bc;
 //Pancake Testnet's Router
 address constant public addressRouter = 0x9Ac64Cc6e4415144C455BD8E4837Fea55603e5c3;
 //Testnet's WBNB  
 address constant public WCOIN = 0xae13d989daC2f0dEbFf460aC112a837C89BAa7cd;  


  struct SNAPSHOT {
    uint64 firstTx;
    uint dailyVolume;
  }

  mapping (address => SNAPSHOT) private _snapshot;

  event LOCKLP(uint indexed amount, uint indexed startTime, uint indexed blockNumber);
  event UNLOCKLP(uint indexed amount, uint indexed periodOfLocked, uint indexed blockNumber);

  constructor(uint _lockTime) ERC20("VALERIA", "VAL") {
    //initializing Uniswap Factory
    factory = IUniswapV2Factory(addressFactory);
    //creating liquidity pool
    factory.createPair(address(this), WCOIN);
    //setting address to exclude from max to transfer
    exludeFromMaxToTransfer(_msgSender());
    exludeFromMaxToTransfer(address(0));
    exludeFromMaxToTransfer(addressRouter);
    //minting total supply to owner
    _mint(_msgSender(), 29102021*10**decimals());
    //setting lock time to LP
    lockTime = _lockTime;
    //getting address pair
    addressPair = factory.getPair(address(this), WCOIN);
    //initializing pair
    pair = IUniswapV2Pair(addressPair);
  }

  function lockLP() external onlyOwner {
    //need to approve it first to call this function
    pair.transferFrom(owner(), address(this), pair.balanceOf(owner()));
    startTime = block.timestamp;
    emit LOCKLP(pair.balanceOf(owner()), block.timestamp, block.number);
  }

  function unlockLP() external onlyOwner returns(bool _flagUnlock) {
    require(! flagUnlock, "VAL: Function was launched already");
    require((block.timestamp - startTime / 1 minutes) > lockTime, "VAL: Already until frozen time");
    pair.transfer(owner(), (40 * pair.balanceOf(address(this))) / 100);
    flagUnlock = true;
    emit UNLOCKLP(pair.balanceOf(owner()), (block.timestamp - startTime / 1 minutes), block.number);
    _flagUnlock = flagUnlock;
  }

  function POL() public view returns (uint) {
    return pair.balanceOf(address(this));
  }

  function setfrozenTime(uint _frozenTime) public onlyOwner {
    frozenTime = _frozenTime;
  }

  function setMaxAmountByTx(uint _maxAmountByTx) public onlyOwner {
    maxAmountByTx = _maxAmountByTx * 10 **decimals();
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
      require(amount <= maxAmountByTx);
      uint timeStamp = block.timestamp - uint(_snapshot[from].firstTx);
      if (timeStamp / 1 minutes > frozenTime) {//1440 minutes once deploy is done 
        _snapshot[from].dailyVolume = 0;
        _snapshot[from].firstTx = uint64(block.timestamp);
      }
      else if (_snapshot[from].dailyVolume + amount > maxAmountByTx ) {
        revert("VAL: transfer exceeds the accumulated amount by day");
      }
      
    }

  }

  function _afterTokenTransfer(address from, address , uint256 amount) internal override {    
      if (! spa.contains(from)) {
        _snapshot[from].dailyVolume += amount;
      }
    } 
}
