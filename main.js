const Web3 = require('web3');
const w3 = new Web3('https://data-seed-prebsc-1-s1.binance.org:8545');
const Val = require("./build/contracts/Valeria.json");
const val = new w3.eth.Contract(Val.abi, '0x27b9A920508442D5a6e40Da63f05e78C8a7d7BB5');

async function _balanceOf(user) {
    balance = await val.methods.balanceOf(user).call();
    console.log( w3.utils.fromWei(balance, 'ether'));
}

async function pol() {
    pol = await val.methods.POL().call({from: '0x6aFB23957b6407A3376C95Bd35A0B60B2b85127c'});
    console.log(w3.utils.fromWei(pol, 'ether'));
}

//_balanceOf('0x6aFB23957b6407A3376C95Bd35A0B60B2b85127c');
pol()