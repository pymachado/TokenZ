const Web3 = require('web3');
const w3 = new Web3('https://data-seed-prebsc-1-s1.binance.org:8545');
const Val = require("./build/contracts/Valeria.json");
const val = new w3.eth.Contract(Val.abi, '0x27b9A920508442D5a6e40Da63f05e78C8a7d7BB5');

async function pol() {
    pol = await val.methods.POL().call();
    console.log(w3.utils.fromWei(pol, 'ether'));
}

async function totalSpecialAddress() {
    spas = await val.methods.totalSpecialAddress().call();
    console.log(spas);
}

async function _balanceOf(user) {
    balance = await val.methods.balanceOf(user).call();
    console.log( w3.utils.fromWei(balance, 'ether'));
}

async function getAccDailyBy(user) {
    acc = await val.methods.get_AccToDay(user).call({from:user});
    console.log(acc);
}

async function isSpetialAddress(user) {
    isSpa = await val.methods.isSpecialAddress(user).call({from:user});
    console.log(isSpa);
}



//_balanceOf('0x6aFB23957b6407A3376C95Bd35A0B60B2b85127c');
pol()