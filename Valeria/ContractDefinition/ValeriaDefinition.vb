Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace Valeria.Contracts.Valeria.ContractDefinition

    
    
    Public Partial Class ValeriaDeployment
     Inherits ValeriaDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class ValeriaDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "60806040523480156200001157600080fd5b5060405162002331380380620023318339810160408190526200003491620007a9565b6040518060400160405280600781526020016656414c4552494160c81b8152506040518060400160405280600381526020016215905360ea1b81525081600390805190602001906200008892919062000703565b5080516200009e90600490602084019062000703565b505050620000bb620000b56200029960201b60201c565b6200029d565b600980546001600160a01b03191673b7926c0430afb07aa7defde6da862ae0bde767bc9081179091556040516364e329cb60e11b815230600482015273ae13d989dac2f0debff460ac112a837c89baa7cd602482015263c9c65396906044016020604051808303816000875af11580156200013a573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190620001609190620007c3565b506200016c33620002ef565b620001786000620002ef565b62000197739ac64cc6e4415144c455bd8e4837fea55603e5c3620002ef565b620001c033620001aa6012600a62000908565b620001ba906301bc0fc562000919565b6200036e565b600d81905560095460405163e6a4390560e01b815230600482015273ae13d989dac2f0debff460ac112a837c89baa7cd60248201526001600160a01b039091169063e6a4390590604401602060405180830381865afa15801562000228573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906200024e9190620007c3565b600e8054610100600160a81b0319166101006001600160a01b039384168102919091179182905560088054919092049092166001600160a01b031990921691909117905550620009e6565b3390565b600580546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6005546001600160a01b031633146200034f5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064015b60405180910390fd5b6200036a8160066200046b60201b62000e1f1790919060201c565b5050565b6001600160a01b038216620003c65760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f206164647265737300604482015260640162000346565b620003d4600083836200052e565b8060026000828254620003e891906200093b565b90915550506001600160a01b03821660009081526020819052604081208054839290620004179084906200093b565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a36200036a600083836200068e565b6001600160a01b03811660009081526020839052604081205480156200049657600191505062000528565b5060018084018054808301825560009190915290620004b79082906200093b565b6001600160a01b03841660009081526020869052604090209081556001908101805460ff1916821790558401805484919083908110620004fb57620004fb62000956565b6000918252602082200180546001600160a01b0319166001600160a01b0393909316929092179091559150505b92915050565b62000549836006620006e560201b62000ee01790919060201c565b6200068957600b548111156200055e57600080fd5b6001600160a01b0383166000908152600f60205260408120546200058c906001600160401b0316426200096c565b600a549091506200059f603c8362000986565b1115620005e5576001600160a01b0384166000908152600f60205260408120600181019190915580546001600160401b031916426001600160401b031617905562000687565b600b546001600160a01b0385166000908152600f6020526040902060010154620006119084906200093b565b1115620006875760405162461bcd60e51b815260206004820152603360248201527f56414c3a207472616e7366657220657863656564732074686520616363756d7560448201527f6c6174656420616d6f756e742062792064617900000000000000000000000000606482015260840162000346565b505b505050565b620006a9836006620006e560201b62000ee01790919060201c565b62000689576001600160a01b0383166000908152600f602052604081206001018054839290620006db9084906200093b565b9091555050505050565b6001600160a01b031660009081526020919091526040902054151590565b8280546200071190620009a9565b90600052602060002090601f01602090048101928262000735576000855562000780565b82601f106200075057805160ff191683800117855562000780565b8280016001018555821562000780579182015b828111156200078057825182559160200191906001019062000763565b506200078e92915062000792565b5090565b5b808211156200078e576000815560010162000793565b600060208284031215620007bc57600080fd5b5051919050565b600060208284031215620007d657600080fd5b81516001600160a01b0381168114620007ee57600080fd5b9392505050565b634e487b7160e01b600052601160045260246000fd5b600181815b808511156200084c578160001904821115620008305762000830620007f5565b808516156200083e57918102915b93841c939080029062000810565b509250929050565b600082620008655750600162000528565b81620008745750600062000528565b81600181146200088d57600281146200089857620008b8565b600191505062000528565b60ff841115620008ac57620008ac620007f5565b50506001821b62000528565b5060208310610133831016604e8410600b8410161715620008dd575081810a62000528565b620008e983836200080b565b8060001904821115620009005762000900620007f5565b029392505050565b6000620007ee60ff84168362000854565b6000816000190483118215151615620009365762000936620007f5565b500290565b60008219821115620009515762000951620007f5565b500190565b634e487b7160e01b600052603260045260246000fd5b600082821015620009815762000981620007f5565b500390565b600082620009a457634e487b7160e01b600052601260045260246000fd5b500490565b600181811c90821680620009be57607f821691505b60208210811415620009e057634e487b7160e01b600052602260045260246000fd5b50919050565b61193b80620009f66000396000f3fe608060405234801561001057600080fd5b50600436106101fa5760003560e01c8063752bb93e1161011a578063a9059cbb116100ad578063df5c76a51161007c578063df5c76a51461042e578063e36f0a4114610441578063f2fde38b1461045c578063f6359f4c1461046f578063f8289b421461048757600080fd5b8063a9059cbb146103c7578063b91f3f97146103da578063d489a7eb146103e2578063dd62ed3e146103f557600080fd5b80638da5cb5b116100e95780638da5cb5b14610392578063906db9ff146103a357806395d89b41146103ac578063a457c2d7146103b457600080fd5b8063752bb93e1461037057806375564f4414610378578063763d73531461038157806378e979251461038957600080fd5b8063262d122e1161019257806348d8f8ad1161016157806348d8f8ad146103245780635f3d16751461033757806370a082311461033f578063715018a61461036857600080fd5b8063262d122e146102e0578063313ce567146102ed57806339509351146102fc57806342f6bf621461030f57600080fd5b80630d668087116101ce5780630d668087146102895780631397ad861461029257806318160ddd146102c557806323b872dd146102cd57600080fd5b8062b6bd8d146101ff57806306fdde031461023e578063095ea7b3146102535780630b13ace214610276575b600080fd5b61022b61020d36600461158c565b6001600160a01b03166000908152600f602052604090206001015490565b6040519081526020015b60405180910390f35b6102466104a2565b60405161023591906115ae565b610266610261366004611603565b610534565b6040519015158152602001610235565b61026661028436600461158c565b61054b565b61022b600d5481565b6102ad73b7926c0430afb07aa7defde6da862ae0bde767bc81565b6040516001600160a01b039091168152602001610235565b60025461022b565b6102666102db36600461162d565b610558565b600e546102669060ff1681565b60405160128152602001610235565b61026661030a366004611603565b610607565b61032261031d366004611669565b610643565b005b61032261033236600461158c565b610672565b61022b6106ab565b61022b61034d36600461158c565b6001600160a01b031660009081526020819052604090205490565b61032261071d565b60075461022b565b61022b600b5481565b610322610753565b61022b600c5481565b6005546001600160a01b03166102ad565b61022b600a5481565b610246610965565b6102666103c2366004611603565b610974565b6102666103d5366004611603565b610a0d565b610266610a1a565b6103226103f0366004611669565b610d09565b61022b610403366004611682565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b61032261043c36600461158c565b610d4f565b6102ad73ae13d989dac2f0debff460ac112a837c89baa7cd81565b61032261046a36600461158c565b610d84565b600e546102ad9061010090046001600160a01b031681565b6102ad739ac64cc6e4415144c455bd8e4837fea55603e5c381565b6060600380546104b1906116b5565b80601f01602080910402602001604051908101604052809291908181526020018280546104dd906116b5565b801561052a5780601f106104ff5761010080835404028352916020019161052a565b820191906000526020600020905b81548152906001019060200180831161050d57829003601f168201915b5050505050905090565b6000610541338484610efe565b5060015b92915050565b6000610545600683610ee0565b6000610565848484611022565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156105ef5760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6105fc8533858403610efe565b506001949350505050565b3360008181526001602090815260408083206001600160a01b0387168452909152812054909161054191859061063e908690611706565b610efe565b6005546001600160a01b0316331461066d5760405162461bcd60e51b81526004016105e69061171e565b600a55565b6005546001600160a01b0316331461069c5760405162461bcd60e51b81526004016105e69061171e565b6106a7600682611207565b5050565b6008546040516370a0823160e01b81523060048201526000916001600160a01b0316906370a0823190602401602060405180830381865afa1580156106f4573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906107189190611753565b905090565b6005546001600160a01b031633146107475760405162461bcd60e51b81526004016105e69061171e565b610751600061139f565b565b6005546001600160a01b0316331461077d5760405162461bcd60e51b81526004016105e69061171e565b6008546001600160a01b03166323b872dd6107a06005546001600160a01b031690565b60085430906001600160a01b03166370a082316107c56005546001600160a01b031690565b6040516001600160e01b031960e084901b1681526001600160a01b039091166004820152602401602060405180830381865afa158015610809573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061082d9190611753565b6040516001600160e01b031960e086901b1681526001600160a01b03938416600482015292909116602483015260448201526064016020604051808303816000875af1158015610881573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108a5919061176c565b5042600c8190556008544391906001600160a01b03166370a082316108d26005546001600160a01b031690565b6040516001600160e01b031960e084901b1681526001600160a01b039091166004820152602401602060405180830381865afa158015610916573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061093a9190611753565b6040517f1c95b8df0ac724c9ca919ee5ee29c4b3d6dda7f54e2f6a395df22e42193d78e190600090a4565b6060600480546104b1906116b5565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156109f65760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016105e6565b610a033385858403610efe565b5060019392505050565b6000610541338484611022565b6005546000906001600160a01b03163314610a475760405162461bcd60e51b81526004016105e69061171e565b600e5460ff1615610aa55760405162461bcd60e51b815260206004820152602260248201527f56414c3a2046756e6374696f6e20776173206c61756e6368656420616c726561604482015261647960f01b60648201526084016105e6565b600d54603c600c54610ab7919061178e565b610ac190426117b0565b11610b0e5760405162461bcd60e51b815260206004820152601e60248201527f56414c3a20416c726561647920756e74696c2066726f7a656e2074696d65000060448201526064016105e6565b6008546001600160a01b031663a9059cbb610b316005546001600160a01b031690565b6008546040516370a0823160e01b81523060048201526064916001600160a01b0316906370a0823190602401602060405180830381865afa158015610b7a573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610b9e9190611753565b610ba99060286117c7565b610bb3919061178e565b6040516001600160e01b031960e085901b1681526001600160a01b03909216600483015260248201526044016020604051808303816000875af1158015610bfe573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610c22919061176c565b50600e805460ff19166001179055600c544390610c4190603c9061178e565b610c4b90426117b0565b6008546001600160a01b03166370a08231610c6e6005546001600160a01b031690565b6040516001600160e01b031960e084901b1681526001600160a01b039091166004820152602401602060405180830381865afa158015610cb2573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610cd69190611753565b6040517f77ae1ff58018f613895dba7004897a98e53a5592a517db9291d0efbbde3a7a5790600090a450600e5460ff1690565b6005546001600160a01b03163314610d335760405162461bcd60e51b81526004016105e69061171e565b610d3f6012600a6118ca565b610d4990826117c7565b600b5550565b6005546001600160a01b03163314610d795760405162461bcd60e51b81526004016105e69061171e565b6106a7600682610e1f565b6005546001600160a01b03163314610dae5760405162461bcd60e51b81526004016105e69061171e565b6001600160a01b038116610e135760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016105e6565b610e1c8161139f565b50565b6001600160a01b0381166000908152602083905260408120548015610e48576001915050610545565b5060018084018054808301825560009190915290610e67908290611706565b6001600160a01b03841660009081526020869052604090209081556001908101805460ff1916821790558401805484919083908110610ea857610ea86118d9565b9060005260206000200160006101000a8154816001600160a01b0302191690836001600160a01b031602179055506000915050610545565b6001600160a01b031660009081526020919091526040902054151590565b6001600160a01b038316610f605760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016105e6565b6001600160a01b038216610fc15760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016105e6565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b0383166110865760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016105e6565b6001600160a01b0382166110e85760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016105e6565b6110f38383836113f1565b6001600160a01b0383166000908152602081905260409020548181101561116b5760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016105e6565b6001600160a01b038085166000908152602081905260408082208585039055918516815290812080548492906111a2908490611706565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef846040516111ee91815260200190565b60405180910390a361120184848461152c565b50505050565b6001600160a01b0381166000908152602083905260408120546001840154811415611266578360010180548061123f5761123f6118ef565b600082815260209020810160001990810180546001600160a01b0319169055019055611372565b60018085018054600092611279916117b0565b81548110611289576112896118d9565b6000918252602090912001546001600160a01b03169050806001868101906112b190856117b0565b815481106112c1576112c16118d9565b9060005260206000200160006101000a8154816001600160a01b0302191690836001600160a01b0316021790555084600101805480611302576113026118ef565b600082815260208120820160001990810180546001600160a01b03191690559091019091558290869060018281019061133b90856117b0565b8154811061134b5761134b6118d9565b60009182526020808320909101546001600160a01b03168352820192909252604001902055505b50506001600160a01b03166000908152602091909152604081209081556001908101805460ff1916905590565b600580546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6113fc600684610ee0565b61152757600b5481111561140f57600080fd5b6001600160a01b0383166000908152600f602052604081205461143c9067ffffffffffffffff16426117b0565b600a5490915061144d603c8361178e565b1115611493576001600160a01b0384166000908152600f602052604081206001810191909155805467ffffffffffffffff19164267ffffffffffffffff16179055611201565b600b546001600160a01b0385166000908152600f60205260409020600101546114bd908490611706565b11156112015760405162461bcd60e51b815260206004820152603360248201527f56414c3a207472616e7366657220657863656564732074686520616363756d756044820152726c6174656420616d6f756e742062792064617960681b60648201526084016105e6565b505050565b611537600684610ee0565b611527576001600160a01b0383166000908152600f602052604081206001018054839290611566908490611706565b9091555050505050565b80356001600160a01b038116811461158757600080fd5b919050565b60006020828403121561159e57600080fd5b6115a782611570565b9392505050565b600060208083528351808285015260005b818110156115db578581018301518582016040015282016115bf565b818111156115ed576000604083870101525b50601f01601f1916929092016040019392505050565b6000806040838503121561161657600080fd5b61161f83611570565b946020939093013593505050565b60008060006060848603121561164257600080fd5b61164b84611570565b925061165960208501611570565b9150604084013590509250925092565b60006020828403121561167b57600080fd5b5035919050565b6000806040838503121561169557600080fd5b61169e83611570565b91506116ac60208401611570565b90509250929050565b600181811c908216806116c957607f821691505b602082108114156116ea57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b60008219821115611719576117196116f0565b500190565b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b60006020828403121561176557600080fd5b5051919050565b60006020828403121561177e57600080fd5b815180151581146115a757600080fd5b6000826117ab57634e487b7160e01b600052601260045260246000fd5b500490565b6000828210156117c2576117c26116f0565b500390565b60008160001904831182151516156117e1576117e16116f0565b500290565b600181815b80851115611821578160001904821115611807576118076116f0565b8085161561181457918102915b93841c93908002906117eb565b509250929050565b60008261183857506001610545565b8161184557506000610545565b816001811461185b576002811461186557611881565b6001915050610545565b60ff841115611876576118766116f0565b50506001821b610545565b5060208310610133831016604e8410600b84101617156118a4575081810a610545565b6118ae83836117e6565b80600019048211156118c2576118c26116f0565b029392505050565b60006115a760ff841683611829565b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052603160045260246000fdfea26469706673582212206d0ed8aaafdf8420d49a85c5bc3aa92fd6dab311f45cc70890b2d070cb7a0b9a64736f6c634300080c0033"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        
        <[Parameter]("uint256", "_lockTime", 1)>
        Public Overridable Property [LockTime] As BigInteger
    
    End Class    
    
    Public Partial Class POLFunction
        Inherits POLFunctionBase
    End Class

        <[Function]("POL", "uint256")>
    Public Class POLFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class WCOINFunction
        Inherits WCOINFunctionBase
    End Class

        <[Function]("WCOIN", "address")>
    Public Class WCOINFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class AddressFactoryFunction
        Inherits AddressFactoryFunctionBase
    End Class

        <[Function]("addressFactory", "address")>
    Public Class AddressFactoryFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class AddressPairFunction
        Inherits AddressPairFunctionBase
    End Class

        <[Function]("addressPair", "address")>
    Public Class AddressPairFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class AddressRouterFunction
        Inherits AddressRouterFunctionBase
    End Class

        <[Function]("addressRouter", "address")>
    Public Class AddressRouterFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class AllowanceFunction
        Inherits AllowanceFunctionBase
    End Class

        <[Function]("allowance", "uint256")>
    Public Class AllowanceFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "owner", 1)>
        Public Overridable Property [Owner] As String
        <[Parameter]("address", "spender", 2)>
        Public Overridable Property [Spender] As String
    
    End Class
    
    
    Public Partial Class ApproveFunction
        Inherits ApproveFunctionBase
    End Class

        <[Function]("approve", "bool")>
    Public Class ApproveFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "spender", 1)>
        Public Overridable Property [Spender] As String
        <[Parameter]("uint256", "amount", 2)>
        Public Overridable Property [Amount] As BigInteger
    
    End Class
    
    
    Public Partial Class BalanceOfFunction
        Inherits BalanceOfFunctionBase
    End Class

        <[Function]("balanceOf", "uint256")>
    Public Class BalanceOfFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "account", 1)>
        Public Overridable Property [Account] As String
    
    End Class
    
    
    Public Partial Class DecimalsFunction
        Inherits DecimalsFunctionBase
    End Class

        <[Function]("decimals", "uint8")>
    Public Class DecimalsFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class DecreaseAllowanceFunction
        Inherits DecreaseAllowanceFunctionBase
    End Class

        <[Function]("decreaseAllowance", "bool")>
    Public Class DecreaseAllowanceFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "spender", 1)>
        Public Overridable Property [Spender] As String
        <[Parameter]("uint256", "subtractedValue", 2)>
        Public Overridable Property [SubtractedValue] As BigInteger
    
    End Class
    
    
    Public Partial Class ExludeFromMaxToTransferFunction
        Inherits ExludeFromMaxToTransferFunctionBase
    End Class

        <[Function]("exludeFromMaxToTransfer")>
    Public Class ExludeFromMaxToTransferFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "user", 1)>
        Public Overridable Property [User] As String
    
    End Class
    
    
    Public Partial Class FlagUnlockFunction
        Inherits FlagUnlockFunctionBase
    End Class

        <[Function]("flagUnlock", "bool")>
    Public Class FlagUnlockFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class FrozenTimeFunction
        Inherits FrozenTimeFunctionBase
    End Class

        <[Function]("frozenTime", "uint256")>
    Public Class FrozenTimeFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class Get_AccToDayFunction
        Inherits Get_AccToDayFunctionBase
    End Class

        <[Function]("get_AccToDay", "uint256")>
    Public Class Get_AccToDayFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "user", 1)>
        Public Overridable Property [User] As String
    
    End Class
    
    
    Public Partial Class IncludeToMaxToTransferFunction
        Inherits IncludeToMaxToTransferFunctionBase
    End Class

        <[Function]("includeToMaxToTransfer")>
    Public Class IncludeToMaxToTransferFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "user", 1)>
        Public Overridable Property [User] As String
    
    End Class
    
    
    Public Partial Class IncreaseAllowanceFunction
        Inherits IncreaseAllowanceFunctionBase
    End Class

        <[Function]("increaseAllowance", "bool")>
    Public Class IncreaseAllowanceFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "spender", 1)>
        Public Overridable Property [Spender] As String
        <[Parameter]("uint256", "addedValue", 2)>
        Public Overridable Property [AddedValue] As BigInteger
    
    End Class
    
    
    Public Partial Class IsSpecialAddressFunction
        Inherits IsSpecialAddressFunctionBase
    End Class

        <[Function]("isSpecialAddress", "bool")>
    Public Class IsSpecialAddressFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "user", 1)>
        Public Overridable Property [User] As String
    
    End Class
    
    
    Public Partial Class LockLPFunction
        Inherits LockLPFunctionBase
    End Class

        <[Function]("lockLP")>
    Public Class LockLPFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class LockTimeFunction
        Inherits LockTimeFunctionBase
    End Class

        <[Function]("lockTime", "uint256")>
    Public Class LockTimeFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class MaxAmountByTxFunction
        Inherits MaxAmountByTxFunctionBase
    End Class

        <[Function]("maxAmountByTx", "uint256")>
    Public Class MaxAmountByTxFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class NameFunction
        Inherits NameFunctionBase
    End Class

        <[Function]("name", "string")>
    Public Class NameFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class OwnerFunction
        Inherits OwnerFunctionBase
    End Class

        <[Function]("owner", "address")>
    Public Class OwnerFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class RenounceOwnershipFunction
        Inherits RenounceOwnershipFunctionBase
    End Class

        <[Function]("renounceOwnership")>
    Public Class RenounceOwnershipFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class SetMaxAmountByTxFunction
        Inherits SetMaxAmountByTxFunctionBase
    End Class

        <[Function]("setMaxAmountByTx")>
    Public Class SetMaxAmountByTxFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "_maxAmountByTx", 1)>
        Public Overridable Property [MaxAmountByTx] As BigInteger
    
    End Class
    
    
    Public Partial Class SetfrozenTimeFunction
        Inherits SetfrozenTimeFunctionBase
    End Class

        <[Function]("setfrozenTime")>
    Public Class SetfrozenTimeFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "_frozenTime", 1)>
        Public Overridable Property [FrozenTime] As BigInteger
    
    End Class
    
    
    Public Partial Class StartTimeFunction
        Inherits StartTimeFunctionBase
    End Class

        <[Function]("startTime", "uint256")>
    Public Class StartTimeFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class SymbolFunction
        Inherits SymbolFunctionBase
    End Class

        <[Function]("symbol", "string")>
    Public Class SymbolFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TotalSpecialAddressFunction
        Inherits TotalSpecialAddressFunctionBase
    End Class

        <[Function]("totalSpecialAddress", "uint256")>
    Public Class TotalSpecialAddressFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TotalSupplyFunction
        Inherits TotalSupplyFunctionBase
    End Class

        <[Function]("totalSupply", "uint256")>
    Public Class TotalSupplyFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TransferFunction
        Inherits TransferFunctionBase
    End Class

        <[Function]("transfer", "bool")>
    Public Class TransferFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "recipient", 1)>
        Public Overridable Property [Recipient] As String
        <[Parameter]("uint256", "amount", 2)>
        Public Overridable Property [Amount] As BigInteger
    
    End Class
    
    
    Public Partial Class TransferFromFunction
        Inherits TransferFromFunctionBase
    End Class

        <[Function]("transferFrom", "bool")>
    Public Class TransferFromFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "sender", 1)>
        Public Overridable Property [Sender] As String
        <[Parameter]("address", "recipient", 2)>
        Public Overridable Property [Recipient] As String
        <[Parameter]("uint256", "amount", 3)>
        Public Overridable Property [Amount] As BigInteger
    
    End Class
    
    
    Public Partial Class TransferOwnershipFunction
        Inherits TransferOwnershipFunctionBase
    End Class

        <[Function]("transferOwnership")>
    Public Class TransferOwnershipFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "newOwner", 1)>
        Public Overridable Property [NewOwner] As String
    
    End Class
    
    
    Public Partial Class UnlockLPFunction
        Inherits UnlockLPFunctionBase
    End Class

        <[Function]("unlockLP", "bool")>
    Public Class UnlockLPFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class ApprovalEventDTO
        Inherits ApprovalEventDTOBase
    End Class

    <[Event]("Approval")>
    Public Class ApprovalEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "owner", 1, true)>
        Public Overridable Property [Owner] As String
        <[Parameter]("address", "spender", 2, true)>
        Public Overridable Property [Spender] As String
        <[Parameter]("uint256", "value", 3, false)>
        Public Overridable Property [Value] As BigInteger
    
    End Class    
    
    Public Partial Class LOCKLPEventDTO
        Inherits LOCKLPEventDTOBase
    End Class

    <[Event]("LOCKLP")>
    Public Class LOCKLPEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("uint256", "amount", 1, true)>
        Public Overridable Property [Amount] As BigInteger
        <[Parameter]("uint256", "startTime", 2, true)>
        Public Overridable Property [StartTime] As BigInteger
        <[Parameter]("uint256", "blockNumber", 3, true)>
        Public Overridable Property [BlockNumber] As BigInteger
    
    End Class    
    
    Public Partial Class OwnershipTransferredEventDTO
        Inherits OwnershipTransferredEventDTOBase
    End Class

    <[Event]("OwnershipTransferred")>
    Public Class OwnershipTransferredEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "previousOwner", 1, true)>
        Public Overridable Property [PreviousOwner] As String
        <[Parameter]("address", "newOwner", 2, true)>
        Public Overridable Property [NewOwner] As String
    
    End Class    
    
    Public Partial Class TransferEventDTO
        Inherits TransferEventDTOBase
    End Class

    <[Event]("Transfer")>
    Public Class TransferEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "from", 1, true)>
        Public Overridable Property [From] As String
        <[Parameter]("address", "to", 2, true)>
        Public Overridable Property [To] As String
        <[Parameter]("uint256", "value", 3, false)>
        Public Overridable Property [Value] As BigInteger
    
    End Class    
    
    Public Partial Class UNLOCKLPEventDTO
        Inherits UNLOCKLPEventDTOBase
    End Class

    <[Event]("UNLOCKLP")>
    Public Class UNLOCKLPEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("uint256", "amount", 1, true)>
        Public Overridable Property [Amount] As BigInteger
        <[Parameter]("uint256", "periodOfLocked", 2, true)>
        Public Overridable Property [PeriodOfLocked] As BigInteger
        <[Parameter]("uint256", "blockNumber", 3, true)>
        Public Overridable Property [BlockNumber] As BigInteger
    
    End Class    
    
    Public Partial Class POLOutputDTO
        Inherits POLOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class POLOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class WCOINOutputDTO
        Inherits WCOINOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class WCOINOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class AddressFactoryOutputDTO
        Inherits AddressFactoryOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AddressFactoryOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class AddressPairOutputDTO
        Inherits AddressPairOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AddressPairOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class AddressRouterOutputDTO
        Inherits AddressRouterOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AddressRouterOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class AllowanceOutputDTO
        Inherits AllowanceOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AllowanceOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    
    
    Public Partial Class BalanceOfOutputDTO
        Inherits BalanceOfOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class BalanceOfOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class DecimalsOutputDTO
        Inherits DecimalsOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class DecimalsOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint8", "", 1)>
        Public Overridable Property [ReturnValue1] As Byte
    
    End Class    
    
    
    
    
    
    Public Partial Class FlagUnlockOutputDTO
        Inherits FlagUnlockOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class FlagUnlockOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class    
    
    Public Partial Class FrozenTimeOutputDTO
        Inherits FrozenTimeOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class FrozenTimeOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class Get_AccToDayOutputDTO
        Inherits Get_AccToDayOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class Get_AccToDayOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    
    
    
    
    Public Partial Class IsSpecialAddressOutputDTO
        Inherits IsSpecialAddressOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class IsSpecialAddressOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class    
    
    
    
    Public Partial Class LockTimeOutputDTO
        Inherits LockTimeOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class LockTimeOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class MaxAmountByTxOutputDTO
        Inherits MaxAmountByTxOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class MaxAmountByTxOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class NameOutputDTO
        Inherits NameOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class NameOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("string", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class OwnerOutputDTO
        Inherits OwnerOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class OwnerOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    
    
    
    
    
    
    Public Partial Class StartTimeOutputDTO
        Inherits StartTimeOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class StartTimeOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class SymbolOutputDTO
        Inherits SymbolOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class SymbolOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("string", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class TotalSpecialAddressOutputDTO
        Inherits TotalSpecialAddressOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class TotalSpecialAddressOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class TotalSupplyOutputDTO
        Inherits TotalSupplyOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class TotalSupplyOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    
    
    
    
    
    

End Namespace