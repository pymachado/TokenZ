Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts.ContractHandlers
Imports Nethereum.Contracts
Imports System.Threading
Imports Valeria.Contracts.IUniswapV2Pair.ContractDefinition
Namespace Valeria.Contracts.IUniswapV2Pair


    Public Partial Class IUniswapV2PairService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal iUniswapV2PairDeployment As IUniswapV2PairDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of IUniswapV2PairDeployment)().SendRequestAndWaitForReceiptAsync(iUniswapV2PairDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal iUniswapV2PairDeployment As IUniswapV2PairDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of IUniswapV2PairDeployment)().SendRequestAsync(iUniswapV2PairDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal iUniswapV2PairDeployment As IUniswapV2PairDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of IUniswapV2PairService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, iUniswapV2PairDeployment, cancellationTokenSource)
            Return New IUniswapV2PairService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function DOMAIN_SEPARATORQueryAsync(ByVal dOMAIN_SEPARATORFunction As DOMAIN_SEPARATORFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte())
        
            Return ContractHandler.QueryAsync(Of DOMAIN_SEPARATORFunction, Byte())(dOMAIN_SEPARATORFunction, blockParameter)
        
        End Function

        
        Public Function DOMAIN_SEPARATORQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte())
        
            return ContractHandler.QueryAsync(Of DOMAIN_SEPARATORFunction, Byte())(Nothing, blockParameter)
        
        End Function



        Public Function MINIMUM_LIQUIDITYQueryAsync(ByVal mINIMUM_LIQUIDITYFunction As MINIMUM_LIQUIDITYFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of MINIMUM_LIQUIDITYFunction, BigInteger)(mINIMUM_LIQUIDITYFunction, blockParameter)
        
        End Function

        
        Public Function MINIMUM_LIQUIDITYQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of MINIMUM_LIQUIDITYFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function PERMIT_TYPEHASHQueryAsync(ByVal pERMIT_TYPEHASHFunction As PERMIT_TYPEHASHFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte())
        
            Return ContractHandler.QueryAsync(Of PERMIT_TYPEHASHFunction, Byte())(pERMIT_TYPEHASHFunction, blockParameter)
        
        End Function

        
        Public Function PERMIT_TYPEHASHQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte())
        
            return ContractHandler.QueryAsync(Of PERMIT_TYPEHASHFunction, Byte())(Nothing, blockParameter)
        
        End Function



        Public Function AllowanceQueryAsync(ByVal allowanceFunction As AllowanceFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of AllowanceFunction, BigInteger)(allowanceFunction, blockParameter)
        
        End Function

        
        Public Function AllowanceQueryAsync(ByVal [owner] As String, ByVal [spender] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Dim allowanceFunction = New AllowanceFunction()
                allowanceFunction.Owner = [owner]
                allowanceFunction.Spender = [spender]
            
            Return ContractHandler.QueryAsync(Of AllowanceFunction, BigInteger)(allowanceFunction, blockParameter)
        
        End Function


        Public Function ApproveRequestAsync(ByVal approveFunction As ApproveFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of ApproveFunction)(approveFunction)
        
        End Function

        Public Function ApproveRequestAndWaitForReceiptAsync(ByVal approveFunction As ApproveFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of ApproveFunction)(approveFunction, cancellationToken)
        
        End Function

        
        Public Function ApproveRequestAsync(ByVal [spender] As String, ByVal [value] As BigInteger) As Task(Of String)
        
            Dim approveFunction = New ApproveFunction()
                approveFunction.Spender = [spender]
                approveFunction.Value = [value]
            
            Return ContractHandler.SendRequestAsync(Of ApproveFunction)(approveFunction)
        
        End Function

        
        Public Function ApproveRequestAndWaitForReceiptAsync(ByVal [spender] As String, ByVal [value] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim approveFunction = New ApproveFunction()
                approveFunction.Spender = [spender]
                approveFunction.Value = [value]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of ApproveFunction)(approveFunction, cancellationToken)
        
        End Function
        Public Function BalanceOfQueryAsync(ByVal balanceOfFunction As BalanceOfFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of BalanceOfFunction, BigInteger)(balanceOfFunction, blockParameter)
        
        End Function

        
        Public Function BalanceOfQueryAsync(ByVal [owner] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Dim balanceOfFunction = New BalanceOfFunction()
                balanceOfFunction.Owner = [owner]
            
            Return ContractHandler.QueryAsync(Of BalanceOfFunction, BigInteger)(balanceOfFunction, blockParameter)
        
        End Function


        Public Function BurnRequestAsync(ByVal burnFunction As BurnFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of BurnFunction)(burnFunction)
        
        End Function

        Public Function BurnRequestAndWaitForReceiptAsync(ByVal burnFunction As BurnFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of BurnFunction)(burnFunction, cancellationToken)
        
        End Function

        
        Public Function BurnRequestAsync(ByVal [to] As String) As Task(Of String)
        
            Dim burnFunction = New BurnFunction()
                burnFunction.To = [to]
            
            Return ContractHandler.SendRequestAsync(Of BurnFunction)(burnFunction)
        
        End Function

        
        Public Function BurnRequestAndWaitForReceiptAsync(ByVal [to] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim burnFunction = New BurnFunction()
                burnFunction.To = [to]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of BurnFunction)(burnFunction, cancellationToken)
        
        End Function
        Public Function DecimalsQueryAsync(ByVal decimalsFunction As DecimalsFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            Return ContractHandler.QueryAsync(Of DecimalsFunction, Byte)(decimalsFunction, blockParameter)
        
        End Function

        
        Public Function DecimalsQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            return ContractHandler.QueryAsync(Of DecimalsFunction, Byte)(Nothing, blockParameter)
        
        End Function



        Public Function FactoryQueryAsync(ByVal factoryFunction As FactoryFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of FactoryFunction, String)(factoryFunction, blockParameter)
        
        End Function

        
        Public Function FactoryQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of FactoryFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function GetReservesQueryAsync(ByVal getReservesFunction As GetReservesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of GetReservesOutputDTO)
        
            Return ContractHandler.QueryDeserializingToObjectAsync(Of GetReservesFunction, GetReservesOutputDTO)(getReservesFunction, blockParameter)
        
        End Function

        
        Public Function GetReservesQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of GetReservesOutputDTO)
        
            return ContractHandler.QueryDeserializingToObjectAsync(Of GetReservesFunction, GetReservesOutputDTO)(Nothing, blockParameter)
        
        End Function



        Public Function InitializeRequestAsync(ByVal initializeFunction As InitializeFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of InitializeFunction)(initializeFunction)
        
        End Function

        Public Function InitializeRequestAndWaitForReceiptAsync(ByVal initializeFunction As InitializeFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of InitializeFunction)(initializeFunction, cancellationToken)
        
        End Function

        
        Public Function InitializeRequestAsync(ByVal [returnValue1] As String, ByVal [returnValue2] As String) As Task(Of String)
        
            Dim initializeFunction = New InitializeFunction()
                initializeFunction.ReturnValue1 = [returnValue1]
                initializeFunction.ReturnValue2 = [returnValue2]
            
            Return ContractHandler.SendRequestAsync(Of InitializeFunction)(initializeFunction)
        
        End Function

        
        Public Function InitializeRequestAndWaitForReceiptAsync(ByVal [returnValue1] As String, ByVal [returnValue2] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim initializeFunction = New InitializeFunction()
                initializeFunction.ReturnValue1 = [returnValue1]
                initializeFunction.ReturnValue2 = [returnValue2]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of InitializeFunction)(initializeFunction, cancellationToken)
        
        End Function
        Public Function KLastQueryAsync(ByVal kLastFunction As KLastFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of KLastFunction, BigInteger)(kLastFunction, blockParameter)
        
        End Function

        
        Public Function KLastQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of KLastFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function MintRequestAsync(ByVal mintFunction As MintFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of MintFunction)(mintFunction)
        
        End Function

        Public Function MintRequestAndWaitForReceiptAsync(ByVal mintFunction As MintFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of MintFunction)(mintFunction, cancellationToken)
        
        End Function

        
        Public Function MintRequestAsync(ByVal [to] As String) As Task(Of String)
        
            Dim mintFunction = New MintFunction()
                mintFunction.To = [to]
            
            Return ContractHandler.SendRequestAsync(Of MintFunction)(mintFunction)
        
        End Function

        
        Public Function MintRequestAndWaitForReceiptAsync(ByVal [to] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim mintFunction = New MintFunction()
                mintFunction.To = [to]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of MintFunction)(mintFunction, cancellationToken)
        
        End Function
        Public Function NameQueryAsync(ByVal nameFunction As NameFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of NameFunction, String)(nameFunction, blockParameter)
        
        End Function

        
        Public Function NameQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of NameFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function NoncesQueryAsync(ByVal noncesFunction As NoncesFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of NoncesFunction, BigInteger)(noncesFunction, blockParameter)
        
        End Function

        
        Public Function NoncesQueryAsync(ByVal [owner] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Dim noncesFunction = New NoncesFunction()
                noncesFunction.Owner = [owner]
            
            Return ContractHandler.QueryAsync(Of NoncesFunction, BigInteger)(noncesFunction, blockParameter)
        
        End Function


        Public Function PermitRequestAsync(ByVal permitFunction As PermitFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of PermitFunction)(permitFunction)
        
        End Function

        Public Function PermitRequestAndWaitForReceiptAsync(ByVal permitFunction As PermitFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of PermitFunction)(permitFunction, cancellationToken)
        
        End Function

        
        Public Function PermitRequestAsync(ByVal [owner] As String, ByVal [spender] As String, ByVal [value] As BigInteger, ByVal [deadline] As BigInteger, ByVal [v] As Byte, ByVal [r] As Byte(), ByVal [s] As Byte()) As Task(Of String)
        
            Dim permitFunction = New PermitFunction()
                permitFunction.Owner = [owner]
                permitFunction.Spender = [spender]
                permitFunction.Value = [value]
                permitFunction.Deadline = [deadline]
                permitFunction.V = [v]
                permitFunction.R = [r]
                permitFunction.S = [s]
            
            Return ContractHandler.SendRequestAsync(Of PermitFunction)(permitFunction)
        
        End Function

        
        Public Function PermitRequestAndWaitForReceiptAsync(ByVal [owner] As String, ByVal [spender] As String, ByVal [value] As BigInteger, ByVal [deadline] As BigInteger, ByVal [v] As Byte, ByVal [r] As Byte(), ByVal [s] As Byte(), ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim permitFunction = New PermitFunction()
                permitFunction.Owner = [owner]
                permitFunction.Spender = [spender]
                permitFunction.Value = [value]
                permitFunction.Deadline = [deadline]
                permitFunction.V = [v]
                permitFunction.R = [r]
                permitFunction.S = [s]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of PermitFunction)(permitFunction, cancellationToken)
        
        End Function
        Public Function Price0CumulativeLastQueryAsync(ByVal price0CumulativeLastFunction As Price0CumulativeLastFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of Price0CumulativeLastFunction, BigInteger)(price0CumulativeLastFunction, blockParameter)
        
        End Function

        
        Public Function Price0CumulativeLastQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of Price0CumulativeLastFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function Price1CumulativeLastQueryAsync(ByVal price1CumulativeLastFunction As Price1CumulativeLastFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of Price1CumulativeLastFunction, BigInteger)(price1CumulativeLastFunction, blockParameter)
        
        End Function

        
        Public Function Price1CumulativeLastQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of Price1CumulativeLastFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function SkimRequestAsync(ByVal skimFunction As SkimFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SkimFunction)(skimFunction)
        
        End Function

        Public Function SkimRequestAndWaitForReceiptAsync(ByVal skimFunction As SkimFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SkimFunction)(skimFunction, cancellationToken)
        
        End Function

        
        Public Function SkimRequestAsync(ByVal [to] As String) As Task(Of String)
        
            Dim skimFunction = New SkimFunction()
                skimFunction.To = [to]
            
            Return ContractHandler.SendRequestAsync(Of SkimFunction)(skimFunction)
        
        End Function

        
        Public Function SkimRequestAndWaitForReceiptAsync(ByVal [to] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim skimFunction = New SkimFunction()
                skimFunction.To = [to]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SkimFunction)(skimFunction, cancellationToken)
        
        End Function
        Public Function SwapRequestAsync(ByVal swapFunction As SwapFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SwapFunction)(swapFunction)
        
        End Function

        Public Function SwapRequestAndWaitForReceiptAsync(ByVal swapFunction As SwapFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SwapFunction)(swapFunction, cancellationToken)
        
        End Function

        
        Public Function SwapRequestAsync(ByVal [amount0Out] As BigInteger, ByVal [amount1Out] As BigInteger, ByVal [to] As String, ByVal [data] As Byte()) As Task(Of String)
        
            Dim swapFunction = New SwapFunction()
                swapFunction.Amount0Out = [amount0Out]
                swapFunction.Amount1Out = [amount1Out]
                swapFunction.To = [to]
                swapFunction.Data = [data]
            
            Return ContractHandler.SendRequestAsync(Of SwapFunction)(swapFunction)
        
        End Function

        
        Public Function SwapRequestAndWaitForReceiptAsync(ByVal [amount0Out] As BigInteger, ByVal [amount1Out] As BigInteger, ByVal [to] As String, ByVal [data] As Byte(), ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim swapFunction = New SwapFunction()
                swapFunction.Amount0Out = [amount0Out]
                swapFunction.Amount1Out = [amount1Out]
                swapFunction.To = [to]
                swapFunction.Data = [data]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SwapFunction)(swapFunction, cancellationToken)
        
        End Function
        Public Function SymbolQueryAsync(ByVal symbolFunction As SymbolFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of SymbolFunction, String)(symbolFunction, blockParameter)
        
        End Function

        
        Public Function SymbolQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of SymbolFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function SyncRequestAsync(ByVal syncFunction As SyncFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SyncFunction)(syncFunction)
        
        End Function

        Public Function SyncRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SyncFunction)
        
        End Function

        Public Function SyncRequestAndWaitForReceiptAsync(ByVal syncFunction As SyncFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SyncFunction)(syncFunction, cancellationToken)
        
        End Function

        Public Function SyncRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SyncFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function Token0QueryAsync(ByVal token0Function As Token0Function, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of Token0Function, String)(token0Function, blockParameter)
        
        End Function

        
        Public Function Token0QueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of Token0Function, String)(Nothing, blockParameter)
        
        End Function



        Public Function Token1QueryAsync(ByVal token1Function As Token1Function, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of Token1Function, String)(token1Function, blockParameter)
        
        End Function

        
        Public Function Token1QueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of Token1Function, String)(Nothing, blockParameter)
        
        End Function



        Public Function TotalSupplyQueryAsync(ByVal totalSupplyFunction As TotalSupplyFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of TotalSupplyFunction, BigInteger)(totalSupplyFunction, blockParameter)
        
        End Function

        
        Public Function TotalSupplyQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of TotalSupplyFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function TransferRequestAsync(ByVal transferFunction As TransferFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TransferFunction)(transferFunction)
        
        End Function

        Public Function TransferRequestAndWaitForReceiptAsync(ByVal transferFunction As TransferFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferFunction)(transferFunction, cancellationToken)
        
        End Function

        
        Public Function TransferRequestAsync(ByVal [to] As String, ByVal [value] As BigInteger) As Task(Of String)
        
            Dim transferFunction = New TransferFunction()
                transferFunction.To = [to]
                transferFunction.Value = [value]
            
            Return ContractHandler.SendRequestAsync(Of TransferFunction)(transferFunction)
        
        End Function

        
        Public Function TransferRequestAndWaitForReceiptAsync(ByVal [to] As String, ByVal [value] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim transferFunction = New TransferFunction()
                transferFunction.To = [to]
                transferFunction.Value = [value]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferFunction)(transferFunction, cancellationToken)
        
        End Function
        Public Function TransferFromRequestAsync(ByVal transferFromFunction As TransferFromFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TransferFromFunction)(transferFromFunction)
        
        End Function

        Public Function TransferFromRequestAndWaitForReceiptAsync(ByVal transferFromFunction As TransferFromFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferFromFunction)(transferFromFunction, cancellationToken)
        
        End Function

        
        Public Function TransferFromRequestAsync(ByVal [from] As String, ByVal [to] As String, ByVal [value] As BigInteger) As Task(Of String)
        
            Dim transferFromFunction = New TransferFromFunction()
                transferFromFunction.From = [from]
                transferFromFunction.To = [to]
                transferFromFunction.Value = [value]
            
            Return ContractHandler.SendRequestAsync(Of TransferFromFunction)(transferFromFunction)
        
        End Function

        
        Public Function TransferFromRequestAndWaitForReceiptAsync(ByVal [from] As String, ByVal [to] As String, ByVal [value] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim transferFromFunction = New TransferFromFunction()
                transferFromFunction.From = [from]
                transferFromFunction.To = [to]
                transferFromFunction.Value = [value]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferFromFunction)(transferFromFunction, cancellationToken)
        
        End Function
    
    End Class

End Namespace
