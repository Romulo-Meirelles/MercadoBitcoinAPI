
Namespace Framework
    ''' <summary>
    ''' *** MADE FOR GITHUB ***
    ''' WRITTEN BY ROMULO MEIRELLES.
    ''' UPWORK: https://www.upwork.com/freelancers/~01fcbc5039ac5766b4
    ''' CONTACT WHATSAPP: https://wa.me/message/KWIS3BYO6K24N1
    ''' CONTACT TELEGRAM: https://t.me/Romulo_Meirelles
    ''' GITHUB: https://github.com/Romulo-Meirelles
    ''' DISCORD: đąяķňέs§¢øďε#2786
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface IMercadoBitcoinClient
        Inherits IDisposable

#Region "API DE DADOS"
        Function Autorization() As Task(Of Authorization)
        Function GetFeesFromAsset(Asset As String) As Task(Of GetFeesFromAsset)
        Function GetOrderBook(ByVal SymbolCurrency As String, ByVal Limit As Integer) As Task(Of GetOrderBook)
        Function ListTrades(ByVal SymbolCurrency As String, Optional ByVal Tid As Integer = Nothing, Optional ByVal Since As Integer = Nothing, Optional ByVal From As Date = Nothing, Optional ByVal [To] As Date = Nothing) As Task(Of ListTrades)
        Function ListCandles(ByVal SymbolCurrency As String, ByVal Resolution As String, ByVal [To] As Date, ByVal From As Date, Optional ByVal CountBack As Integer = 0) As Task(Of ListCandles)
        Function ListSymbol(Optional ByVal SymbolCurrency As String = Nothing) As Task(Of ListSymbols)
        Function ListTickers(ByVal SymbolCurrency As String) As Task(Of ListTickers)
#End Region

#Region "API DE NEGOCIAÇÃO"
#Region "API ACCOUNT"
        Function ListAccounts() As Task(Of ListAccounts)
        Function ListBalance(AccountID As String) As Task(Of ListBalances)
        Function ListPositions(AccountID As String, Optional SymbolCurrency As String = Nothing) As Task(Of ListPositions)
#End Region
#Region "API WALLET"
        Function ListDeposits(AccountID As String, ByVal SymbolCurrency As String, Optional Limit As String = Nothing, Optional Pagination As String = Nothing, Optional ByVal From As Date = Nothing, Optional ByVal [To] As Date = Nothing) As Task(Of ListDeposits)
        Function WithdrawCoin(AccountID As String, ByVal SymbolCurrency As String, AccountRef As Integer, Address As String, Description As String, DestinationTag As String, NetWork As String, Quantity As String, Fee As String) As Task(Of WithdrawCoin)
        Function GetWithdrawCoin(AccountID As String, ByVal SymbolCurrency As String, ByVal WithdrawID As String) As Task(Of GetWithdrawCoin)
#End Region
#Region "API TRADING"
        Function ListOrders(AccountID As String, ByVal SymbolCurrency As String, Optional HasExecutions As String = Nothing, Optional Side As String = Nothing, Optional Status As String = Nothing, Optional IDFrom As String = Nothing, Optional IDTo As String = Nothing, Optional CreatedAtFrom As String = Nothing, Optional CreatedAtTo As String = Nothing) As Task(Of ListOrder)
        Function PlaceOrders(AccountID As String, ByVal SymbolCurrency As String, Optional Async As Boolean = Nothing, Optional Cost As Integer = Nothing, Optional ExternalId As String = Nothing, Optional LimitPrice As Integer = Nothing, Optional Quantity As String = Nothing, Optional Side As String = Nothing, Optional StopPrice As Integer = Nothing, Optional Type As String = Nothing) As Task(Of PlaceOrder)
        Function CancelOrder(AccountID As String, ByVal SymbolCurrency As String, ByVal OrderID As String) As Task(Of CancelOrder)
        Function GetOrder(AccountID As String, ByVal SymbolCurrency As String, ByVal OrderID As String) As Task(Of GetOrder)
        Function CancellAllOpenOrder(ByVal AccountID As String, Optional ByVal HasExecutions As Boolean = Nothing, Optional ByVal SymbolCurrency As String = Nothing) As Task(Of CancelAllOpenOrders)
        Function ListAllOrders(ByVal AccountID As String, Optional ByVal HasExecutions As Boolean = Nothing, Optional ByVal SymbolCurrency As String = Nothing, Optional ByVal Status As String = Nothing, Optional ByVal Size As String = Nothing) As Task(Of ListAllOrders)

#End Region
#End Region



    End Interface
End Namespace
