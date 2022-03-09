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
Namespace Valeria.Contracts.IUniswapV2Factory.ContractDefinition

    
    
    Public Partial Class IUniswapV2FactoryDeployment
     Inherits IUniswapV2FactoryDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class IUniswapV2FactoryDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = ""
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class AllPairsFunction
        Inherits AllPairsFunctionBase
    End Class

        <[Function]("allPairs", "address")>
    Public Class AllPairsFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class
    
    
    Public Partial Class AllPairsLengthFunction
        Inherits AllPairsLengthFunctionBase
    End Class

        <[Function]("allPairsLength", "uint256")>
    Public Class AllPairsLengthFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class CreatePairFunction
        Inherits CreatePairFunctionBase
    End Class

        <[Function]("createPair", "address")>
    Public Class CreatePairFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "tokenA", 1)>
        Public Overridable Property [TokenA] As String
        <[Parameter]("address", "tokenB", 2)>
        Public Overridable Property [TokenB] As String
    
    End Class
    
    
    Public Partial Class FeeToFunction
        Inherits FeeToFunctionBase
    End Class

        <[Function]("feeTo", "address")>
    Public Class FeeToFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class FeeToSetterFunction
        Inherits FeeToSetterFunctionBase
    End Class

        <[Function]("feeToSetter", "address")>
    Public Class FeeToSetterFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class GetPairFunction
        Inherits GetPairFunctionBase
    End Class

        <[Function]("getPair", "address")>
    Public Class GetPairFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "tokenA", 1)>
        Public Overridable Property [TokenA] As String
        <[Parameter]("address", "tokenB", 2)>
        Public Overridable Property [TokenB] As String
    
    End Class
    
    
    Public Partial Class SetFeeToFunction
        Inherits SetFeeToFunctionBase
    End Class

        <[Function]("setFeeTo")>
    Public Class SetFeeToFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class SetFeeToSetterFunction
        Inherits SetFeeToSetterFunctionBase
    End Class

        <[Function]("setFeeToSetter")>
    Public Class SetFeeToSetterFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class PairCreatedEventDTO
        Inherits PairCreatedEventDTOBase
    End Class

    <[Event]("PairCreated")>
    Public Class PairCreatedEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "token0", 1, true)>
        Public Overridable Property [Token0] As String
        <[Parameter]("address", "token1", 2, true)>
        Public Overridable Property [Token1] As String
        <[Parameter]("address", "pair", 3, false)>
        Public Overridable Property [Pair] As String
        <[Parameter]("uint256", "", 4, false)>
        Public Overridable Property [ReturnValue4] As BigInteger
    
    End Class    
    
    Public Partial Class AllPairsOutputDTO
        Inherits AllPairsOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AllPairsOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "pair", 1)>
        Public Overridable Property [Pair] As String
    
    End Class    
    
    Public Partial Class AllPairsLengthOutputDTO
        Inherits AllPairsLengthOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AllPairsLengthOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    
    
    Public Partial Class FeeToOutputDTO
        Inherits FeeToOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class FeeToOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class FeeToSetterOutputDTO
        Inherits FeeToSetterOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class FeeToSetterOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class GetPairOutputDTO
        Inherits GetPairOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetPairOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "pair", 1)>
        Public Overridable Property [Pair] As String
    
    End Class    
    
    
    

End Namespace
