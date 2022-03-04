
// SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;


library IterableMap {

struct IndexValue {
    uint keyIndex; 
    bool isValid;
}

struct SpecialAddress {
    mapping(address => IndexValue) data;
    address[] keys;
}

  /////////////////////////////////////////key--value----oo///////////////////////////////////////////
  function _length(SpecialAddress storage self) internal view returns(uint) {
      return self.keys.length;
  }
  
  function insert(SpecialAddress storage self, address key) internal returns (bool replaced) {
        uint keyIndex = self.data[key].keyIndex;
        if (keyIndex > 0)
            return true;
        else {
            keyIndex = self.keys.length;
            self.keys.push();//index 0
            self.data[key].keyIndex = keyIndex + 1;
            self.data[key].isValid = true;
            self.keys[keyIndex] = key;
            return false;
        } 
    }

  function remove(SpecialAddress storage self, address key) internal returns (bool success) {
      uint keyIndex = self.data[key].keyIndex;
      if (keyIndex == self.keys.length ) {
          self.keys.pop();
      }
      else {
        address addressToStillHold = self.keys[self.keys.length - 1];
        self.keys[keyIndex - 1] = addressToStillHold;
        self.keys.pop();
        self.data[self.keys[keyIndex - 1]].keyIndex = keyIndex;   
      }
      delete self.data[key];
      return true;
  }

  function contains(SpecialAddress storage self, address key) internal view returns (bool) {
      return self.data[key].keyIndex > 0;
  }


  function iterate_start(SpecialAddress storage self) internal view returns (uint keyIndex) {
      return iterate_next(self, type(uint).max);
  }


  function iterate_valid(SpecialAddress storage self, uint keyIndex) internal view returns (bool) {
      return keyIndex < self.keys.length;
  }

  function iterate_next(SpecialAddress storage self, uint keyIndex) internal view returns (uint r_keyIndex) {
      keyIndex++;
      while (keyIndex < self.keys.length)
          keyIndex++;
      return keyIndex;
  }

  function iterate_get(SpecialAddress storage self, uint keyIndex) internal view returns (address key) {
      key = self.keys[keyIndex];
  }


}
