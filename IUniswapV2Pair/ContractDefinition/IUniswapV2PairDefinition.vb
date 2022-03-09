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
Namespace Valeria.Contracts.IUniswapV2Pair.ContractDefinition

    
    
    Public Partial Class IUniswapV2PairDeployment
     Inherits IUniswapV2PairDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class IUniswapV2PairDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = ""
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class DOMAIN_SEPARATORFunction
        Inherits DOMAIN_SEPARATORFunctionBase
    End Class

        <[Function]("DOMAIN_SEPARATOR", "bytes32")>
    Public Class DOMAIN_SEPARATORFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class MINIMUM_LIQUIDITYFunction
        Inherits MINIMUM_LIQUIDITYFunctionBase
    End Class

        <[Function]("MINIMUM_LIQUIDITY", "uint256")>
    Public Class MINIMUM_LIQUIDITYFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class PERMIT_TYPEHASHFunction
        Inherits PERMIT_TYPEHASHFunctionBase
    End Class

        <[Function]("PERMIT_TYPEHASH", "bytes32")>
    Public Class PERMIT_TYPEHASHFunctionBase
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
        <[Parameter]("uint256", "value", 2)>
        Public Overridable Property [Value] As BigInteger
    
    End Class
    
    
    Public Partial Class BalanceOfFunction
        Inherits BalanceOfFunctionBase
    End Class

        <[Function]("balanceOf", "uint256")>
    Public Class BalanceOfFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "owner", 1)>
        Public Overridable Property [Owner] As String
    
    End Class
    
    
    Public Partial Class BurnFunction
        Inherits BurnFunctionBase
    End Class

        <[Function]("burn", GetType(BurnOutputDTO))>
    Public Class BurnFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "to", 1)>
        Public Overridable Property [To] As String
    
    End Class
    
    
    Public Partial Class DecimalsFunction
        Inherits DecimalsFunctionBase
    End Class

        <[Function]("decimals", "uint8")>
    Public Class DecimalsFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class FactoryFunction
        Inherits FactoryFunctionBase
    End Class

        <[Function]("factory", "address")>
    Public Class FactoryFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class GetReservesFunction
        Inherits GetReservesFunctionBase
    End Class

        <[Function]("getReserves", GetType(GetReservesOutputDTO))>
    Public Class GetReservesFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class InitializeFunction
        Inherits InitializeFunctionBase
    End Class

        <[Function]("initialize")>
    Public Class InitializeFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
        <[Parameter]("address", "", 2)>
        Public Overridable Property [ReturnValue2] As String
    
    End Class
    
    
    Public Partial Class KLastFunction
        Inherits KLastFunctionBase
    End Class

        <[Function]("kLast", "uint256")>
    Public Class KLastFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class MintFunction
        Inherits MintFunctionBase
    End Class

        <[Function]("mint", "uint256")>
    Public Class MintFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "to", 1)>
        Public Overridable Property [To] As String
    
    End Class
    
    
    Public Partial Class NameFunction
        Inherits NameFunctionBase
    End Class

        <[Function]("name", "string")>
    Public Class NameFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class NoncesFunction
        Inherits NoncesFunctionBase
    End Class

        <[Function]("nonces", "uint256")>
    Public Class NoncesFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "owner", 1)>
        Public Overridable Property [Owner] As String
    
    End Class
    
    
    Public Partial Class PermitFunction
        Inherits PermitFunctionBase
    End Class

        <[Function]("permit")>
    Public Class PermitFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "owner", 1)>
        Public Overridable Property [Owner] As String
        <[Parameter]("address", "spender", 2)>
        Public Overridable Property [Spender] As String
        <[Parameter]("uint256", "value", 3)>
        Public Overridable Property [Value] As BigInteger
        <[Parameter]("uint256", "deadline", 4)>
        Public Overridable Property [Deadline] As BigInteger
        <[Parameter]("uint8", "v", 5)>
        Public Overridable Property [V] As Byte
        <[Parameter]("bytes32", "r", 6)>
        Public Overridable Property [R] As Byte()
        <[Parameter]("bytes32", "s", 7)>
        Public Overridable Property [S] As Byte()
    
    End Class
    
    
    Public Partial Class Price0CumulativeLastFunction
        Inherits Price0CumulativeLastFunctionBase
    End Class

        <[Function]("price0CumulativeLast", "uint256")>
    Public Class Price0CumulativeLastFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class Price1CumulativeLastFunction
        Inherits Price1CumulativeLastFunctionBase
    End Class

        <[Function]("price1CumulativeLast", "uint256")>
    Public Class Price1CumulativeLastFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class SkimFunction
        Inherits SkimFunctionBase
    End Class

        <[Function]("skim")>
    Public Class SkimFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "to", 1)>
        Public Overridable Property [To] As String
    
    End Class
    
    
    Public Partial Class SwapFunction
        Inherits SwapFunctionBase
    End Class

        <[Function]("swap")>
    Public Class SwapFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "amount0Out", 1)>
        Public Overridable Property [Amount0Out] As BigInteger
        <[Parameter]("uint256", "amount1Out", 2)>
        Public Overridable Property [Amount1Out] As BigInteger
        <[Parameter]("address", "to", 3)>
        Public Overridable Property [To] As String
        <[Parameter]("bytes", "data", 4)>
        Public Overridable Property [Data] As Byte()
    
    End Class
    
    
    Public Partial Class SymbolFunction
        Inherits SymbolFunctionBase
    End Class

        <[Function]("symbol", "string")>
    Public Class SymbolFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class SyncFunction
        Inherits SyncFunctionBase
    End Class

        <[Function]("sync")>
    Public Class SyncFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class Token0Function
        Inherits Token0FunctionBase
    End Class

        <[Function]("token0", "address")>
    Public Class Token0FunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class Token1Function
        Inherits Token1FunctionBase
    End Class

        <[Function]("token1", "address")>
    Public Class Token1FunctionBase
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
    
        <[Parameter]("address", "to", 1)>
        Public Overridable Property [To] As String
        <[Parameter]("uint256", "value", 2)>
        Public Overridable Property [Value] As BigInteger
    
    End Class
    
    
    Public Partial Class TransferFromFunction
        Inherits TransferFromFunctionBase
    End Class

        <[Function]("transferFrom", "bool")>
    Public Class TransferFromFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "from", 1)>
        Public Overridable Property [From] As String
        <[Parameter]("address", "to", 2)>
        Public Overridable Property [To] As String
        <[Parameter]("uint256", "value", 3)>
        Public Overridable Property [Value] As BigInteger
    
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
    
    Public Partial Class BurnEventDTO
        Inherits BurnEventDTOBase
    End Class

    <[Event]("Burn")>
    Public Class BurnEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "sender", 1, true)>
        Public Overridable Property [Sender] As String
        <[Parameter]("uint256", "amount0", 2, false)>
        Public Overridable Property [Amount0] As BigInteger
        <[Parameter]("uint256", "amount1", 3, false)>
        Public Overridable Property [Amount1] As BigInteger
        <[Parameter]("address", "to", 4, true)>
        Public Overridable Property [To] As String
    
    End Class    
    
    Public Partial Class MintEventDTO
        Inherits MintEventDTOBase
    End Class

    <[Event]("Mint")>
    Public Class MintEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "sender", 1, true)>
        Public Overridable Property [Sender] As String
        <[Parameter]("uint256", "amount0", 2, false)>
        Public Overridable Property [Amount0] As BigInteger
        <[Parameter]("uint256", "amount1", 3, false)>
        Public Overridable Property [Amount1] As BigInteger
    
    End Class    
    
    Public Partial Class SwapEventDTO
        Inherits SwapEventDTOBase
    End Class

    <[Event]("Swap")>
    Public Class SwapEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "sender", 1, true)>
        Public Overridable Property [Sender] As String
        <[Parameter]("uint256", "amount0In", 2, false)>
        Public Overridable Property [Amount0In] As BigInteger
        <[Parameter]("uint256", "amount1In", 3, false)>
        Public Overridable Property [Amount1In] As BigInteger
        <[Parameter]("uint256", "amount0Out", 4, false)>
        Public Overridable Property [Amount0Out] As BigInteger
        <[Parameter]("uint256", "amount1Out", 5, false)>
        Public Overridable Property [Amount1Out] As BigInteger
        <[Parameter]("address", "to", 6, true)>
        Public Overridable Property [To] As String
    
    End Class    
    
    Public Partial Class SyncEventDTO
        Inherits SyncEventDTOBase
    End Class

    <[Event]("Sync")>
    Public Class SyncEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("uint112", "reserve0", 1, false)>
        Public Overridable Property [Reserve0] As BigInteger
        <[Parameter]("uint112", "reserve1", 2, false)>
        Public Overridable Property [Reserve1] As BigInteger
    
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
    
    Public Partial Class DOMAIN_SEPARATOROutputDTO
        Inherits DOMAIN_SEPARATOROutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class DOMAIN_SEPARATOROutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bytes32", "", 1)>
        Public Overridable Property [ReturnValue1] As Byte()
    
    End Class    
    
    Public Partial Class MINIMUM_LIQUIDITYOutputDTO
        Inherits MINIMUM_LIQUIDITYOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class MINIMUM_LIQUIDITYOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class PERMIT_TYPEHASHOutputDTO
        Inherits PERMIT_TYPEHASHOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class PERMIT_TYPEHASHOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bytes32", "", 1)>
        Public Overridable Property [ReturnValue1] As Byte()
    
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
    
    Public Partial Class BurnOutputDTO
        Inherits BurnOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class BurnOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "amount0", 1)>
        Public Overridable Property [Amount0] As BigInteger
        <[Parameter]("uint256", "amount1", 2)>
        Public Overridable Property [Amount1] As BigInteger
    
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
    
    Public Partial Class FactoryOutputDTO
        Inherits FactoryOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class FactoryOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class GetReservesOutputDTO
        Inherits GetReservesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class GetReservesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint112", "reserve0", 1)>
        Public Overridable Property [Reserve0] As BigInteger
        <[Parameter]("uint112", "reserve1", 2)>
        Public Overridable Property [Reserve1] As BigInteger
        <[Parameter]("uint32", "blockTimestampLast", 3)>
        Public Overridable Property [BlockTimestampLast] As UInteger
    
    End Class    
    
    
    
    Public Partial Class KLastOutputDTO
        Inherits KLastOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class KLastOutputDTOBase
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
    
    Public Partial Class NoncesOutputDTO
        Inherits NoncesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class NoncesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    
    
    Public Partial Class Price0CumulativeLastOutputDTO
        Inherits Price0CumulativeLastOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class Price0CumulativeLastOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class Price1CumulativeLastOutputDTO
        Inherits Price1CumulativeLastOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class Price1CumulativeLastOutputDTOBase
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
    
    
    
    Public Partial Class Token0OutputDTO
        Inherits Token0OutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class Token0OutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class Token1OutputDTO
        Inherits Token1OutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class Token1OutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
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
