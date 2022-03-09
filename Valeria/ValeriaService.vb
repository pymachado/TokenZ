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
Imports Valeria.Contracts.Valeria.ContractDefinition
Namespace Valeria.Contracts.Valeria


    Public Partial Class ValeriaService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal valeriaDeployment As ValeriaDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ValeriaDeployment)().SendRequestAndWaitForReceiptAsync(valeriaDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal valeriaDeployment As ValeriaDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of ValeriaDeployment)().SendRequestAsync(valeriaDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal valeriaDeployment As ValeriaDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of ValeriaService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, valeriaDeployment, cancellationTokenSource)
            Return New ValeriaService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function POLQueryAsync(ByVal pOLFunction As POLFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of POLFunction, BigInteger)(pOLFunction, blockParameter)
        
        End Function

        
        Public Function POLQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of POLFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function WCOINQueryAsync(ByVal wCOINFunction As WCOINFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of WCOINFunction, String)(wCOINFunction, blockParameter)
        
        End Function

        
        Public Function WCOINQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of WCOINFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function AddressFactoryQueryAsync(ByVal addressFactoryFunction As AddressFactoryFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of AddressFactoryFunction, String)(addressFactoryFunction, blockParameter)
        
        End Function

        
        Public Function AddressFactoryQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of AddressFactoryFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function AddressPairQueryAsync(ByVal addressPairFunction As AddressPairFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of AddressPairFunction, String)(addressPairFunction, blockParameter)
        
        End Function

        
        Public Function AddressPairQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of AddressPairFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function AddressRouterQueryAsync(ByVal addressRouterFunction As AddressRouterFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of AddressRouterFunction, String)(addressRouterFunction, blockParameter)
        
        End Function

        
        Public Function AddressRouterQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of AddressRouterFunction, String)(Nothing, blockParameter)
        
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

        
        Public Function ApproveRequestAsync(ByVal [spender] As String, ByVal [amount] As BigInteger) As Task(Of String)
        
            Dim approveFunction = New ApproveFunction()
                approveFunction.Spender = [spender]
                approveFunction.Amount = [amount]
            
            Return ContractHandler.SendRequestAsync(Of ApproveFunction)(approveFunction)
        
        End Function

        
        Public Function ApproveRequestAndWaitForReceiptAsync(ByVal [spender] As String, ByVal [amount] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim approveFunction = New ApproveFunction()
                approveFunction.Spender = [spender]
                approveFunction.Amount = [amount]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of ApproveFunction)(approveFunction, cancellationToken)
        
        End Function
        Public Function BalanceOfQueryAsync(ByVal balanceOfFunction As BalanceOfFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of BalanceOfFunction, BigInteger)(balanceOfFunction, blockParameter)
        
        End Function

        
        Public Function BalanceOfQueryAsync(ByVal [account] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Dim balanceOfFunction = New BalanceOfFunction()
                balanceOfFunction.Account = [account]
            
            Return ContractHandler.QueryAsync(Of BalanceOfFunction, BigInteger)(balanceOfFunction, blockParameter)
        
        End Function


        Public Function DecimalsQueryAsync(ByVal decimalsFunction As DecimalsFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            Return ContractHandler.QueryAsync(Of DecimalsFunction, Byte)(decimalsFunction, blockParameter)
        
        End Function

        
        Public Function DecimalsQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Byte)
        
            return ContractHandler.QueryAsync(Of DecimalsFunction, Byte)(Nothing, blockParameter)
        
        End Function



        Public Function DecreaseAllowanceRequestAsync(ByVal decreaseAllowanceFunction As DecreaseAllowanceFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of DecreaseAllowanceFunction)(decreaseAllowanceFunction)
        
        End Function

        Public Function DecreaseAllowanceRequestAndWaitForReceiptAsync(ByVal decreaseAllowanceFunction As DecreaseAllowanceFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of DecreaseAllowanceFunction)(decreaseAllowanceFunction, cancellationToken)
        
        End Function

        
        Public Function DecreaseAllowanceRequestAsync(ByVal [spender] As String, ByVal [subtractedValue] As BigInteger) As Task(Of String)
        
            Dim decreaseAllowanceFunction = New DecreaseAllowanceFunction()
                decreaseAllowanceFunction.Spender = [spender]
                decreaseAllowanceFunction.SubtractedValue = [subtractedValue]
            
            Return ContractHandler.SendRequestAsync(Of DecreaseAllowanceFunction)(decreaseAllowanceFunction)
        
        End Function

        
        Public Function DecreaseAllowanceRequestAndWaitForReceiptAsync(ByVal [spender] As String, ByVal [subtractedValue] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim decreaseAllowanceFunction = New DecreaseAllowanceFunction()
                decreaseAllowanceFunction.Spender = [spender]
                decreaseAllowanceFunction.SubtractedValue = [subtractedValue]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of DecreaseAllowanceFunction)(decreaseAllowanceFunction, cancellationToken)
        
        End Function
        Public Function ExludeFromMaxToTransferRequestAsync(ByVal exludeFromMaxToTransferFunction As ExludeFromMaxToTransferFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of ExludeFromMaxToTransferFunction)(exludeFromMaxToTransferFunction)
        
        End Function

        Public Function ExludeFromMaxToTransferRequestAndWaitForReceiptAsync(ByVal exludeFromMaxToTransferFunction As ExludeFromMaxToTransferFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of ExludeFromMaxToTransferFunction)(exludeFromMaxToTransferFunction, cancellationToken)
        
        End Function

        
        Public Function ExludeFromMaxToTransferRequestAsync(ByVal [user] As String) As Task(Of String)
        
            Dim exludeFromMaxToTransferFunction = New ExludeFromMaxToTransferFunction()
                exludeFromMaxToTransferFunction.User = [user]
            
            Return ContractHandler.SendRequestAsync(Of ExludeFromMaxToTransferFunction)(exludeFromMaxToTransferFunction)
        
        End Function

        
        Public Function ExludeFromMaxToTransferRequestAndWaitForReceiptAsync(ByVal [user] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim exludeFromMaxToTransferFunction = New ExludeFromMaxToTransferFunction()
                exludeFromMaxToTransferFunction.User = [user]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of ExludeFromMaxToTransferFunction)(exludeFromMaxToTransferFunction, cancellationToken)
        
        End Function
        Public Function FlagUnlockQueryAsync(ByVal flagUnlockFunction As FlagUnlockFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of FlagUnlockFunction, Boolean)(flagUnlockFunction, blockParameter)
        
        End Function

        
        Public Function FlagUnlockQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            return ContractHandler.QueryAsync(Of FlagUnlockFunction, Boolean)(Nothing, blockParameter)
        
        End Function



        Public Function FrozenTimeQueryAsync(ByVal frozenTimeFunction As FrozenTimeFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of FrozenTimeFunction, BigInteger)(frozenTimeFunction, blockParameter)
        
        End Function

        
        Public Function FrozenTimeQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of FrozenTimeFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function Get_AccToDayQueryAsync(ByVal get_AccToDayFunction As Get_AccToDayFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of Get_AccToDayFunction, BigInteger)(get_AccToDayFunction, blockParameter)
        
        End Function

        
        Public Function Get_AccToDayQueryAsync(ByVal [user] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Dim get_AccToDayFunction = New Get_AccToDayFunction()
                get_AccToDayFunction.User = [user]
            
            Return ContractHandler.QueryAsync(Of Get_AccToDayFunction, BigInteger)(get_AccToDayFunction, blockParameter)
        
        End Function


        Public Function IncludeToMaxToTransferRequestAsync(ByVal includeToMaxToTransferFunction As IncludeToMaxToTransferFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of IncludeToMaxToTransferFunction)(includeToMaxToTransferFunction)
        
        End Function

        Public Function IncludeToMaxToTransferRequestAndWaitForReceiptAsync(ByVal includeToMaxToTransferFunction As IncludeToMaxToTransferFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of IncludeToMaxToTransferFunction)(includeToMaxToTransferFunction, cancellationToken)
        
        End Function

        
        Public Function IncludeToMaxToTransferRequestAsync(ByVal [user] As String) As Task(Of String)
        
            Dim includeToMaxToTransferFunction = New IncludeToMaxToTransferFunction()
                includeToMaxToTransferFunction.User = [user]
            
            Return ContractHandler.SendRequestAsync(Of IncludeToMaxToTransferFunction)(includeToMaxToTransferFunction)
        
        End Function

        
        Public Function IncludeToMaxToTransferRequestAndWaitForReceiptAsync(ByVal [user] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim includeToMaxToTransferFunction = New IncludeToMaxToTransferFunction()
                includeToMaxToTransferFunction.User = [user]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of IncludeToMaxToTransferFunction)(includeToMaxToTransferFunction, cancellationToken)
        
        End Function
        Public Function IncreaseAllowanceRequestAsync(ByVal increaseAllowanceFunction As IncreaseAllowanceFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of IncreaseAllowanceFunction)(increaseAllowanceFunction)
        
        End Function

        Public Function IncreaseAllowanceRequestAndWaitForReceiptAsync(ByVal increaseAllowanceFunction As IncreaseAllowanceFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of IncreaseAllowanceFunction)(increaseAllowanceFunction, cancellationToken)
        
        End Function

        
        Public Function IncreaseAllowanceRequestAsync(ByVal [spender] As String, ByVal [addedValue] As BigInteger) As Task(Of String)
        
            Dim increaseAllowanceFunction = New IncreaseAllowanceFunction()
                increaseAllowanceFunction.Spender = [spender]
                increaseAllowanceFunction.AddedValue = [addedValue]
            
            Return ContractHandler.SendRequestAsync(Of IncreaseAllowanceFunction)(increaseAllowanceFunction)
        
        End Function

        
        Public Function IncreaseAllowanceRequestAndWaitForReceiptAsync(ByVal [spender] As String, ByVal [addedValue] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim increaseAllowanceFunction = New IncreaseAllowanceFunction()
                increaseAllowanceFunction.Spender = [spender]
                increaseAllowanceFunction.AddedValue = [addedValue]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of IncreaseAllowanceFunction)(increaseAllowanceFunction, cancellationToken)
        
        End Function
        Public Function IsSpecialAddressQueryAsync(ByVal isSpecialAddressFunction As IsSpecialAddressFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of IsSpecialAddressFunction, Boolean)(isSpecialAddressFunction, blockParameter)
        
        End Function

        
        Public Function IsSpecialAddressQueryAsync(ByVal [user] As String, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Dim isSpecialAddressFunction = New IsSpecialAddressFunction()
                isSpecialAddressFunction.User = [user]
            
            Return ContractHandler.QueryAsync(Of IsSpecialAddressFunction, Boolean)(isSpecialAddressFunction, blockParameter)
        
        End Function


        Public Function LockLPRequestAsync(ByVal lockLPFunction As LockLPFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of LockLPFunction)(lockLPFunction)
        
        End Function

        Public Function LockLPRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of LockLPFunction)
        
        End Function

        Public Function LockLPRequestAndWaitForReceiptAsync(ByVal lockLPFunction As LockLPFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of LockLPFunction)(lockLPFunction, cancellationToken)
        
        End Function

        Public Function LockLPRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of LockLPFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function LockTimeQueryAsync(ByVal lockTimeFunction As LockTimeFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of LockTimeFunction, BigInteger)(lockTimeFunction, blockParameter)
        
        End Function

        
        Public Function LockTimeQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of LockTimeFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function MaxAmountByTxQueryAsync(ByVal maxAmountByTxFunction As MaxAmountByTxFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of MaxAmountByTxFunction, BigInteger)(maxAmountByTxFunction, blockParameter)
        
        End Function

        
        Public Function MaxAmountByTxQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of MaxAmountByTxFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function NameQueryAsync(ByVal nameFunction As NameFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of NameFunction, String)(nameFunction, blockParameter)
        
        End Function

        
        Public Function NameQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of NameFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function OwnerQueryAsync(ByVal ownerFunction As OwnerFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of OwnerFunction, String)(ownerFunction, blockParameter)
        
        End Function

        
        Public Function OwnerQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of OwnerFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function RenounceOwnershipRequestAsync(ByVal renounceOwnershipFunction As RenounceOwnershipFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RenounceOwnershipFunction)(renounceOwnershipFunction)
        
        End Function

        Public Function RenounceOwnershipRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of RenounceOwnershipFunction)
        
        End Function

        Public Function RenounceOwnershipRequestAndWaitForReceiptAsync(ByVal renounceOwnershipFunction As RenounceOwnershipFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RenounceOwnershipFunction)(renounceOwnershipFunction, cancellationToken)
        
        End Function

        Public Function RenounceOwnershipRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of RenounceOwnershipFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function SetMaxAmountByTxRequestAsync(ByVal setMaxAmountByTxFunction As SetMaxAmountByTxFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetMaxAmountByTxFunction)(setMaxAmountByTxFunction)
        
        End Function

        Public Function SetMaxAmountByTxRequestAndWaitForReceiptAsync(ByVal setMaxAmountByTxFunction As SetMaxAmountByTxFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetMaxAmountByTxFunction)(setMaxAmountByTxFunction, cancellationToken)
        
        End Function

        
        Public Function SetMaxAmountByTxRequestAsync(ByVal [maxAmountByTx] As BigInteger) As Task(Of String)
        
            Dim setMaxAmountByTxFunction = New SetMaxAmountByTxFunction()
                setMaxAmountByTxFunction.MaxAmountByTx = [maxAmountByTx]
            
            Return ContractHandler.SendRequestAsync(Of SetMaxAmountByTxFunction)(setMaxAmountByTxFunction)
        
        End Function

        
        Public Function SetMaxAmountByTxRequestAndWaitForReceiptAsync(ByVal [maxAmountByTx] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim setMaxAmountByTxFunction = New SetMaxAmountByTxFunction()
                setMaxAmountByTxFunction.MaxAmountByTx = [maxAmountByTx]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetMaxAmountByTxFunction)(setMaxAmountByTxFunction, cancellationToken)
        
        End Function
        Public Function SetfrozenTimeRequestAsync(ByVal setfrozenTimeFunction As SetfrozenTimeFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetfrozenTimeFunction)(setfrozenTimeFunction)
        
        End Function

        Public Function SetfrozenTimeRequestAndWaitForReceiptAsync(ByVal setfrozenTimeFunction As SetfrozenTimeFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetfrozenTimeFunction)(setfrozenTimeFunction, cancellationToken)
        
        End Function

        
        Public Function SetfrozenTimeRequestAsync(ByVal [frozenTime] As BigInteger) As Task(Of String)
        
            Dim setfrozenTimeFunction = New SetfrozenTimeFunction()
                setfrozenTimeFunction.FrozenTime = [frozenTime]
            
            Return ContractHandler.SendRequestAsync(Of SetfrozenTimeFunction)(setfrozenTimeFunction)
        
        End Function

        
        Public Function SetfrozenTimeRequestAndWaitForReceiptAsync(ByVal [frozenTime] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim setfrozenTimeFunction = New SetfrozenTimeFunction()
                setfrozenTimeFunction.FrozenTime = [frozenTime]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetfrozenTimeFunction)(setfrozenTimeFunction, cancellationToken)
        
        End Function
        Public Function StartTimeQueryAsync(ByVal startTimeFunction As StartTimeFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of StartTimeFunction, BigInteger)(startTimeFunction, blockParameter)
        
        End Function

        
        Public Function StartTimeQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of StartTimeFunction, BigInteger)(Nothing, blockParameter)
        
        End Function



        Public Function SymbolQueryAsync(ByVal symbolFunction As SymbolFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of SymbolFunction, String)(symbolFunction, blockParameter)
        
        End Function

        
        Public Function SymbolQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of SymbolFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function TotalSpecialAddressQueryAsync(ByVal totalSpecialAddressFunction As TotalSpecialAddressFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            Return ContractHandler.QueryAsync(Of TotalSpecialAddressFunction, BigInteger)(totalSpecialAddressFunction, blockParameter)
        
        End Function

        
        Public Function TotalSpecialAddressQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of BigInteger)
        
            return ContractHandler.QueryAsync(Of TotalSpecialAddressFunction, BigInteger)(Nothing, blockParameter)
        
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

        
        Public Function TransferRequestAsync(ByVal [recipient] As String, ByVal [amount] As BigInteger) As Task(Of String)
        
            Dim transferFunction = New TransferFunction()
                transferFunction.Recipient = [recipient]
                transferFunction.Amount = [amount]
            
            Return ContractHandler.SendRequestAsync(Of TransferFunction)(transferFunction)
        
        End Function

        
        Public Function TransferRequestAndWaitForReceiptAsync(ByVal [recipient] As String, ByVal [amount] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim transferFunction = New TransferFunction()
                transferFunction.Recipient = [recipient]
                transferFunction.Amount = [amount]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferFunction)(transferFunction, cancellationToken)
        
        End Function
        Public Function TransferFromRequestAsync(ByVal transferFromFunction As TransferFromFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TransferFromFunction)(transferFromFunction)
        
        End Function

        Public Function TransferFromRequestAndWaitForReceiptAsync(ByVal transferFromFunction As TransferFromFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferFromFunction)(transferFromFunction, cancellationToken)
        
        End Function

        
        Public Function TransferFromRequestAsync(ByVal [sender] As String, ByVal [recipient] As String, ByVal [amount] As BigInteger) As Task(Of String)
        
            Dim transferFromFunction = New TransferFromFunction()
                transferFromFunction.Sender = [sender]
                transferFromFunction.Recipient = [recipient]
                transferFromFunction.Amount = [amount]
            
            Return ContractHandler.SendRequestAsync(Of TransferFromFunction)(transferFromFunction)
        
        End Function

        
        Public Function TransferFromRequestAndWaitForReceiptAsync(ByVal [sender] As String, ByVal [recipient] As String, ByVal [amount] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim transferFromFunction = New TransferFromFunction()
                transferFromFunction.Sender = [sender]
                transferFromFunction.Recipient = [recipient]
                transferFromFunction.Amount = [amount]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferFromFunction)(transferFromFunction, cancellationToken)
        
        End Function
        Public Function TransferOwnershipRequestAsync(ByVal transferOwnershipFunction As TransferOwnershipFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TransferOwnershipFunction)(transferOwnershipFunction)
        
        End Function

        Public Function TransferOwnershipRequestAndWaitForReceiptAsync(ByVal transferOwnershipFunction As TransferOwnershipFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferOwnershipFunction)(transferOwnershipFunction, cancellationToken)
        
        End Function

        
        Public Function TransferOwnershipRequestAsync(ByVal [newOwner] As String) As Task(Of String)
        
            Dim transferOwnershipFunction = New TransferOwnershipFunction()
                transferOwnershipFunction.NewOwner = [newOwner]
            
            Return ContractHandler.SendRequestAsync(Of TransferOwnershipFunction)(transferOwnershipFunction)
        
        End Function

        
        Public Function TransferOwnershipRequestAndWaitForReceiptAsync(ByVal [newOwner] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim transferOwnershipFunction = New TransferOwnershipFunction()
                transferOwnershipFunction.NewOwner = [newOwner]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TransferOwnershipFunction)(transferOwnershipFunction, cancellationToken)
        
        End Function
        Public Function UnlockLPRequestAsync(ByVal unlockLPFunction As UnlockLPFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of UnlockLPFunction)(unlockLPFunction)
        
        End Function

        Public Function UnlockLPRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of UnlockLPFunction)
        
        End Function

        Public Function UnlockLPRequestAndWaitForReceiptAsync(ByVal unlockLPFunction As UnlockLPFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of UnlockLPFunction)(unlockLPFunction, cancellationToken)
        
        End Function

        Public Function UnlockLPRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of UnlockLPFunction)(Nothing, cancellationToken)
        
        End Function
    
    End Class

End Namespace
