#!/usr/bin/env python3
import json
from web3 import Web3


class Valeria():
    def __init__(self, _smartContract_path, _addressSmartContract, provider): 
        self.w3 = Web3(Web3.HTTPProvider(provider))
        self.sc_path = _smartContract_path
        self.addressSmartContract = _addressSmartContract
        with open(self.sc_path) as file:
            self.sc_json = json.load(file)
            self.sc_abi = self.sc_json['abi']

        
        self.sc = self.w3.eth.contract(address=self.addressSmartContract, abi=self.sc_abi)

    # Function that return a total supply of NFT minted 
    def get_totalSupply(self):
        return self.sc.functions.totalSupply().call()

    def get_name(self):
        return self.sc.functions.name().call()
    
    def get_symbol(self):
        return self.sc.functions.symbol().call()

    # Function that return a list with a each tokenId onwership of caller of function
    def get_balanceOf(self, owner):
        balance = self.sc.functions.balanceOf(owner).call()
        return self.w3.fromWei(balance,'ether')
    

    def getAccDailyBy(self, user):
        acc = self.sc.functions.get_AccToDay(user).call()
        return acc

    def  isSpetialAddress(self, user):
        isSpa = self.sc.functions.isSpecialAddress(user).call()
        return isSpa
    
    def pol(self):
        pol = self.sc.functions.POL().call()
        return pol

    def get_frozenTime(self):
        return self.sc.functions.frozenTime().call()
    
    def get_maxAmountByTx(self):
        return self.sc.functions.maxAmountByTx().call()

    def get_chainId(self):
        chainId = self.w3.eth.chain_id
        return self.w3.toHex(chainId)

    def set_exludeFromMaxToTransfer(self, user, admin, Pk):
        gasLimit = self.sc.functions.exludeFromMaxToTransfer(user).estimateGas({'from': admin})
        nonce = self.w3.eth.get_transaction_count(admin)
        raw_tx = self.sc.functions.exludeFromMaxToTransfer(user).buildTransaction({
            'chainId': self.w3.toHex(self.w3.eth.chain_id),
            'gas': gasLimit,
            'nonce': nonce
        })
        signed_tx = self.w3.eth.account.sign_transaction(raw_tx, private_key=Pk)
        hash_tx = self.w3.eth.send_raw_transaction(signed_tx.rawTransaction)
        tx_receipt = self.w3.eth.wait_for_transaction_receipt(hash_tx)
        return tx_receipt
    
    def set_includeToMaxToTransfer(self, user, admin, Pk):
        gasLimit = self.sc.functions.includeToMaxToTransfer(user).estimateGas({'from': admin})
        nonce = self.w3.eth.get_transaction_count(admin)
        raw_tx = self.sc.functions.includeToMaxToTransfer(user).buildTransaction({
            'chainId': self.w3.eth.chain_id,
            'gas': gasLimit,
            'nonce': nonce
        })
        signed_tx = self.w3.eth.account.sign_transaction(raw_tx, private_key = Pk)
        hash_tx = self.w3.eth.send_raw_transaction(signed_tx.rawTransaction)
        tx_receipt = self.w3.eth.wait_for_transaction_receipt(hash_tx)
        return tx_receipt

    def setfrozenTime(self, frozenTime, admin, Pk):
        gasLimit = self.sc.functions.setfrozenTime(frozenTime).estimateGas({'from': admin})
        nonce = self.w3.eth.get_transaction_count(admin)
        raw_tx = self.sc.functions.setfrozenTime(frozenTime).buildTransaction({
            'chainId': self.w3.eth.chain_id,
            'gas': gasLimit,
            'nonce': nonce
        })
        signed_tx = self.w3.eth.account.sign_transaction(raw_tx, private_key = Pk)
        hash_tx = self.w3.eth.send_raw_transaction(signed_tx.rawTransaction)
        tx_receipt = self.w3.eth.wait_for_transaction_receipt(hash_tx)
        return tx_receipt

    def setMaxAmountByTx(self, maxAmount, admin, Pk):
        gasLimit = self.sc.functions.setMaxAmountByTx(maxAmount).estimateGas({'from': admin})
        nonce = self.w3.eth.get_transaction_count(admin)
        raw_tx = self.sc.functions.setMaxAmountByTx(maxAmount).buildTransaction({
            'chainId': self.w3.eth.chain_id,
            'gas': gasLimit,
            'nonce': nonce
        })
        signed_tx = self.w3.eth.account.sign_transaction(raw_tx, private_key = Pk)
        hash_tx = self.w3.eth.send_raw_transaction(signed_tx.rawTransaction)
        tx_receipt = self.w3.eth.wait_for_transaction_receipt(hash_tx)
        return tx_receipt

    def lockLP(self, admin, Pk):
        gasLimit = self.sc.functions.lockLP().estimateGas({'from': admin})
        nonce = self.w3.eth.get_transaction_count(admin)
        raw_tx = self.sc.functions.lockLP.buildTransaction({
            'chainId': self.w3.eth.chain_id,
            'gas': gasLimit,
            'nonce': nonce
        })
        signed_tx = self.w3.eth.account.sign_transaction(raw_tx, private_key = Pk)
        hash_tx = self.w3.eth.send_raw_transaction(signed_tx.rawTransaction)
        tx_receipt = self.w3.eth.wait_for_transaction_receipt(hash_tx)
        return tx_receipt
    
    def unlockLP(self, admin, Pk):
        gasLimit = self.sc.functions.unlockLP().estimateGas({'from': admin})
        nonce = self.w3.eth.get_transaction_count(admin)
        raw_tx = self.sc.functions.unlockLP.buildTransaction({
            'chainId': self.w3.eth.chain_id,
            'gas': gasLimit,
            'nonce': nonce
        })
        signed_tx = self.w3.eth.account.sign_transaction(raw_tx, private_key = Pk)
        hash_tx = self.w3.eth.send_raw_transaction(signed_tx.rawTransaction)
        tx_receipt = self.w3.eth.wait_for_transaction_receipt(hash_tx)
        return tx_receipt

