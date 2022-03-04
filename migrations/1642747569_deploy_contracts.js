const Web3ProviderEngine = require("@trufflesuite/web3-provider-engine");
const { time } = require("console");
const { toChecksumAddress } = require("ethereumjs-util");

const Valeria = artifacts.require("Valeria");
const Seed_Sale = artifacts.require("Seed_Sale");

module.exports =  async function (deployer, accounts) {
  await deployer.deploy(Valeria);
  //const timestamp = Math.floor(Date.now() / 1000)
  //const Val = await Valeria.deployed();
  //deployer.deploy(Seed_Sale, Val.address, timestamp + 2*60, timestamp + 10*60,2);
  //const Seed = await Seed_Sale.deployed();  
  //Val.transfer(Seed.address, 10000*10*18, {'from': accounts[0]});
};
