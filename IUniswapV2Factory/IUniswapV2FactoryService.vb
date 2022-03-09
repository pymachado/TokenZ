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
Imports Valeria.Contracts.IUniswapV2Factory.ContractDefinition
Namespace Valeria.Contracts.IUniswapV2Factory


    Public Partial Class IUniswapV2FactoryService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal iUniswapV2FactoryDeployment As IUniswapV2FactoryDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of IUniswapV2FactoryDeployment)().SendRequestAndWaitForReceiptAsync(iUniswapV2FactoryDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal iUniswapV2FactoryDeployment As IUniswapV2FactoryDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of IUniswapV2FactoryDeployment)().SendRequestAsync(iUniswapV2FactoryDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal iUniswapV2FactoryDeployment As IUniswapV2FactoryDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of IUniswapV2FactoryService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, iUniswapV2FactoryDeployment, cancellationTokenSource)
            Return New IUniswapV2FactoryService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function AllPairsQueryAsync(ByVal allPairsFunction As AllPairsFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of AllPairsFunction, String)(allPairsFunction, blockParameter)
        
        End Function

        
        Public Function AllPairsQueryAsync(ByVal [returnValue1] As BigInteger, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Dim allPairsFunction = New AllPairsFunction()
                allPairsFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.QueryAsync(Of AllPairsFunction, String)(allPairsFunction, blockParameter)
        
        End Function


        Public Function AllPairsLengthQueryAsync(ByVal allPairsLengthFunction As AllPairsLengthFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of AllPairsLengthFunction, BigInteger)(allPairsLengthFunction, blockParameter)
        
        End Function

        
        Public Function AllPairsLengthQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of AllPairsLengthFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function CreatePairRequestAsync(ByVal createPairFunction As CreatePairFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of CreatePairFunction)(createPairFunction)
        
        End Function

        Public Function CreatePairRequestAndWaitForReceiptAsync(ByVal createPairFunction As CreatePairFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of CreatePairFunction)(createPairFunction, cancellationToken)
        
        End Function

        
        Public Function CreatePairRequestAsync(ByVal [tokenA] As String, ByVal [tokenB] As String) As Task(Of String)
        
            Dim createPairFunction = New CreatePairFunction()
                createPairFunction.TokenA = [tokenA]
                createPairFunction.TokenB = [tokenB]
            
            Return ContractHandler.SendRequestAsync(Of CreatePairFunction)(createPairFunction)
        
        End Function

        
        Public Function CreatePairRequestAndWaitForReceiptAsync(ByVal [tokenA] As String, ByVal [tokenB] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim createPairFunction = New CreatePairFunction()
                createPairFunction.TokenA = [tokenA]
                createPairFunction.TokenB = [tokenB]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of CreatePairFunction)(createPairFunction, cancellationToken)
        
        End Function
        Public Function FeeToQueryAsync(ByVal feeToFunction As FeeToFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of FeeToFunction, String)(feeToFunction, blockParameter)
        
        End Function

        
        Public Function FeeToQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of FeeToFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function FeeToSetterQueryAsync(ByVal feeToSetterFunction As FeeToSetterFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of FeeToSetterFunction, String)(feeToSetterFunction, blockParameter)
        
        End Function

        
        Public Function FeeToSetterQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of FeeToSetterFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function GetPairQueryAsync(ByVal getPairFunction As GetPairFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of GetPairFunction, String)(getPairFunction, blockParameter)
        
        End Function

        
        Public Function GetPairQueryAsync(ByVal [tokenA] As String, ByVal [tokenB] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Dim getPairFunction = New GetPairFunction()
                getPairFunction.TokenA = [tokenA]
                getPairFunction.TokenB = [tokenB]
            
            Return ContractHandler.QueryAsync(Of GetPairFunction, String)(getPairFunction, blockParameter)
        
        End Function


        Public Function SetFeeToRequestAsync(ByVal setFeeToFunction As SetFeeToFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetFeeToFunction)(setFeeToFunction)
        
        End Function

        Public Function SetFeeToRequestAndWaitForReceiptAsync(ByVal setFeeToFunction As SetFeeToFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetFeeToFunction)(setFeeToFunction, cancellationToken)
        
        End Function

        
        Public Function SetFeeToRequestAsync(ByVal [returnValue1] As String) As Task(Of String)
        
            Dim setFeeToFunction = New SetFeeToFunction()
                setFeeToFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.SendRequestAsync(Of SetFeeToFunction)(setFeeToFunction)
        
        End Function

        
        Public Function SetFeeToRequestAndWaitForReceiptAsync(ByVal [returnValue1] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim setFeeToFunction = New SetFeeToFunction()
                setFeeToFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetFeeToFunction)(setFeeToFunction, cancellationToken)
        
        End Function
        Public Function SetFeeToSetterRequestAsync(ByVal setFeeToSetterFunction As SetFeeToSetterFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetFeeToSetterFunction)(setFeeToSetterFunction)
        
        End Function

        Public Function SetFeeToSetterRequestAndWaitForReceiptAsync(ByVal setFeeToSetterFunction As SetFeeToSetterFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetFeeToSetterFunction)(setFeeToSetterFunction, cancellationToken)
        
        End Function

        
        Public Function SetFeeToSetterRequestAsync(ByVal [returnValue1] As String) As Task(Of String)
        
            Dim setFeeToSetterFunction = New SetFeeToSetterFunction()
                setFeeToSetterFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.SendRequestAsync(Of SetFeeToSetterFunction)(setFeeToSetterFunction)
        
        End Function

        
        Public Function SetFeeToSetterRequestAndWaitForReceiptAsync(ByVal [returnValue1] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim setFeeToSetterFunction = New SetFeeToSetterFunction()
                setFeeToSetterFunction.ReturnValue1 = [returnValue1]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetFeeToSetterFunction)(setFeeToSetterFunction, cancellationToken)
        
        End Function
    
    End Class

End Namespace
