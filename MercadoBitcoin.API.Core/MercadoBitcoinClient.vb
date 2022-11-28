Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Namespace Core
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
    ''' 
    Public Class MercadoBitcoinClient : Implements IMercadoBitcoinClient

        Private ReadOnly _Requester As IRequester
        Public Sub New(ByVal Requester As IRequester)
            _Requester = Requester
        End Sub

        Public Shared Function Create(ByVal Config As ApiConfig, ByVal Optional Client As HttpClient = Nothing) As MercadoBitcoinClient
            Dim Requester = HttpClientRequester.Create(Config, Client)
            Return New MercadoBitcoinClient(Requester)
        End Function

#Region "API DE DADOS"

        Public Async Function GetFeesFromAsset(ByVal Asset As String) As Task(Of GetFeesFromAsset) Implements IMercadoBitcoinClient.GetFeesFromAsset
            Return Await _Requester.Post(Of GetFeesFromAsset)(Asset & "/fees", New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function

        Public Async Function GetOrderBook(ByVal SymbolCurrency As String, ByVal Limit As Integer) As Task(Of GetOrderBook) Implements IMercadoBitcoinClient.GetOrderBook
            Dim RequestBody As String = http_build_query({"limit"}, {Limit})
            Return Await _Requester.Post(Of GetOrderBook)(SymbolCurrency & "/orderbook?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function

        Public Async Function ListTrades(ByVal SymbolCurrency As String, Optional ByVal Tid As Integer = Nothing, Optional ByVal Since As Integer = Nothing, Optional ByVal From As Date = Nothing, Optional ByVal [To] As Date = Nothing) As Task(Of ListTrades) Implements IMercadoBitcoinClient.ListTrades
            Dim RequestBody As String = String.Empty
            Dim ParName(), ParValue()


            If Not IsNothing(Tid) Then ParName = {""} : ParValue = {""}            'RequestBody = http_build_query({"tid"}, {Tid.ToString})
            If Not IsNothing(Since) Then ParName = {""} : ParValue = {""}  'RequestBody = http_build_query({"&since"}, {Since.ToString})
            If Not IsNothing(From) Then ParName = {""} : ParValue = {""}  'RequestBody = http_build_query({"&from"}, {TimeToUnix(From)})
            If Not IsNothing([To]) Then ParName = {""} : ParValue = {""}  'RequestBody = http_build_query({"&to"}, {TimeToUnix([To])})





            Return Await _Requester.Post(Of ListTrades)(SymbolCurrency & "/trades?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get, Root:=True).ConfigureAwait(False)
        End Function

        Public Async Function ListCandles(ByVal SymbolCurrency As String, ByVal Resolution As String, ByVal [To] As Date, ByVal From As Date, Optional ByVal CountBack As Integer = 0) As Task(Of ListCandles) Implements IMercadoBitcoinClient.ListCandles
            Dim RequestBody As String = http_build_query({"symbol", "resolution", "to", "from", "countback"}, {SymbolCurrency, Resolution, TimeToUnix([To]), TimeToUnix(From), CountBack.ToString})
            Return Await _Requester.Post(Of ListCandles)("candles?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function

        Public Async Function ListSymbol(Optional ByVal SymbolCurrency As String = Nothing) As Task(Of ListSymbols) Implements IMercadoBitcoinClient.ListSymbol
            Dim RequestBody As String = http_build_query({"symbols"}, {SymbolCurrency})
            Return Await _Requester.Post(Of ListSymbols)("symbols?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get).ConfigureAwait(False)
        End Function

        Public Async Function ListTickers(ByVal SymbolCurrency As String) As Task(Of ListTickers) Implements IMercadoBitcoinClient.ListTickers
            Dim RequestBody As String = http_build_query({"symbols"}, {SymbolCurrency})
            Return Await _Requester.Post(Of ListTickers)("tickers?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get, Root:=True).ConfigureAwait(False)
        End Function

#End Region

#Region "API DE NEGOCIAÇÃO"

#Region "API ACCOUNT"
        Public Async Function ListAccount() As Task(Of ListAccounts) Implements IMercadoBitcoinClient.ListAccounts
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Return Await _Requester.Post(Of ListAccounts)("accounts", New Dictionary(Of String, String) From {}, HttpMethod.Get, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function

        Public Async Function ListBalance(AccountID As String) As Task(Of ListBalances) Implements IMercadoBitcoinClient.ListBalance
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As String = http_build_query({"accountid"}, {AccountID})
            Return Await _Requester.Post(Of ListBalances)("accounts/" & AccountID & "/balances?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function

        Public Async Function ListPositions(AccountID As String, Optional SymbolCurrency As String = Nothing) As Task(Of ListPositions) Implements IMercadoBitcoinClient.ListPositions
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As String = String.Empty
            If Not IsNothing(SymbolCurrency) Then RequestBody = http_build_query({"symbols"}, {SymbolCurrency})
            Return Await _Requester.Post(Of ListPositions)("accounts/" & AccountID & "/positions?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function

#End Region

#Region "API WALLET"

        Public Async Function ListDeposits(AccountID As String, ByVal SymbolCurrency As String, Optional Limit As String = Nothing, Optional Pagination As String = Nothing, Optional ByVal From As Date = Nothing, Optional ByVal [To] As Date = Nothing) As Task(Of ListDeposits) Implements IMercadoBitcoinClient.ListDeposits
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As String = String.Empty
            If Not IsNothing(Limit) Then RequestBody = http_build_query({"limit"}, {Limit})
            If Not IsNothing(Limit) Then RequestBody += http_build_query({"&page"}, {Pagination})
            If Not IsNothing(Limit) Then RequestBody += http_build_query({"&from"}, {TimeToUnix(From)})
            If Not IsNothing(Limit) Then RequestBody += http_build_query({"&to"}, {TimeToUnix([To])})
            Return Await _Requester.Post(Of ListDeposits)("accounts/" & AccountID & "/wallet/" & SymbolCurrency & "/deposits?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function

        Public Async Function WithdrawCoin(AccountID As String, ByVal SymbolCurrency As String, AccountRef As Integer, Address As String, Description As String, DestinationTag As String, NetWork As String, Quantity As String, Fee As String) As Task(Of WithdrawCoin) Implements IMercadoBitcoinClient.WithdrawCoin
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As New Dictionary(Of String, String)
            RequestBody.Add("account_ref", AccountRef.ToString)
            RequestBody.Add("address", Address)
            RequestBody.Add("description", Description)
            RequestBody.Add("destination_tag", DestinationTag)
            RequestBody.Add("network", NetWork)
            RequestBody.Add("quantity", Quantity)
            RequestBody.Add("tx_fee", Fee)
            Return Await _Requester.Post(Of WithdrawCoin)("accounts/" & AccountID & "/wallet/" & SymbolCurrency & "/withdraw", RequestBody, HttpMethod.Post, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function

        Public Async Function GetWithdrawCoin(AccountID As String, ByVal SymbolCurrency As String, ByVal WithdrawID As String) As Task(Of GetWithdrawCoin) Implements IMercadoBitcoinClient.GetWithdrawCoin
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Return Await _Requester.Post(Of GetWithdrawCoin)("accounts/" & AccountID & "/wallet/" & SymbolCurrency & "/withdraw/" & WithdrawID, New Dictionary(Of String, String), HttpMethod.Get, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function
#End Region

#Region "API TRADING"
        Public Async Function ListOrders(ByVal AccountID As String, ByVal SymbolCurrency As String, Optional HasExecutions As String = Nothing, Optional Side As String = Nothing, Optional Status As String = Nothing, Optional IDFrom As String = Nothing, Optional IDTo As String = Nothing, Optional CreatedAtFrom As String = Nothing, Optional CreatedAtTo As String = Nothing) As Task(Of ListOrder) Implements IMercadoBitcoinClient.ListOrders
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As String = String.Empty
            If Not IsNothing(HasExecutions) Then RequestBody = http_build_query({"has_executions"}, {HasExecutions})
            If Not IsNothing(Side) Then RequestBody += http_build_query({"&side"}, {Side})
            If Not IsNothing(Status) Then RequestBody += http_build_query({"&status"}, {Status})
            If Not IsNothing(IDFrom) Then RequestBody += http_build_query({"&id_from"}, {IDFrom})
            If Not IsNothing(IDTo) Then RequestBody += http_build_query({"&id_to"}, {IDTo})
            If Not IsNothing(CreatedAtFrom) Then RequestBody += http_build_query({"&created_at_from"}, {CreatedAtFrom})
            If Not IsNothing(CreatedAtTo) Then RequestBody += http_build_query({"&created_at_to"}, {CreatedAtTo})
            Return Await _Requester.Post(Of ListOrder)("accounts/" & AccountID & "/" & SymbolCurrency & "/orders?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function

        Public Async Function PlaceOrders(ByVal AccountID As String, ByVal SymbolCurrency As String, Optional Async As Boolean = Nothing, Optional Cost As Integer = Nothing, Optional ExternalId As String = Nothing, Optional LimitPrice As Integer = Nothing, Optional Quantity As String = Nothing, Optional Side As String = Nothing, Optional StopPrice As Integer = Nothing, Optional Type As String = Nothing) As Task(Of PlaceOrder) Implements IMercadoBitcoinClient.PlaceOrders
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As New Dictionary(Of String, String)
            If Not IsNothing(Async) Then RequestBody.Add("async", Async.ToString)
            If Not IsNothing(Cost) Then RequestBody.Add("cost", Cost.ToString)
            If Not IsNothing(ExternalId) Then RequestBody.Add("externalId", ExternalId)
            If Not IsNothing(LimitPrice) Then RequestBody.Add("limitPrice", LimitPrice.ToString)
            If Not IsNothing(Quantity) Then RequestBody.Add("qty", Quantity)
            If Not IsNothing(Side) Then RequestBody.Add("side", Side)
            If Not IsNothing(StopPrice) Then RequestBody.Add("stopPrice", StopPrice.ToString)
            If Not IsNothing(Type) Then RequestBody.Add("type", Type)
            Return Await _Requester.Post(Of PlaceOrder)("accounts/" & AccountID & "/" & SymbolCurrency & "/orders", RequestBody, HttpMethod.Post, Token.AcessToken, True, True).ConfigureAwait(False)
        End Function

        Public Async Function CancelOrder(ByVal AccountID As String, ByVal SymbolCurrency As String, ByVal OrderID As String) As Task(Of CancelOrder) Implements IMercadoBitcoinClient.CancelOrder
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Return Await _Requester.Post(Of CancelOrder)("accounts/" & AccountID & "/" & SymbolCurrency & "/orders/" & OrderID, New Dictionary(Of String, String), HttpMethod.Delete, Token.AcessToken, False, True).ConfigureAwait(False)
        End Function

        Public Async Function GetOrder(ByVal AccountID As String, ByVal SymbolCurrency As String, ByVal OrderID As String) As Task(Of GetOrder) Implements IMercadoBitcoinClient.GetOrder
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Return Await _Requester.Post(Of GetOrder)("accounts/" & AccountID & "/" & SymbolCurrency & "/orders/" & OrderID, New Dictionary(Of String, String), HttpMethod.Get, Token.AcessToken, False, True).ConfigureAwait(False)
        End Function

        Public Async Function CancellAllOpenOrder(ByVal AccountID As String, Optional ByVal HasExecutions As Boolean = Nothing, Optional ByVal SymbolCurrency As String = Nothing) As Task(Of CancelAllOpenOrders) Implements IMercadoBitcoinClient.CancellAllOpenOrder
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As String = String.Empty
            If Not IsNothing(HasExecutions) Then RequestBody = http_build_query({"has_executions"}, {HasExecutions.ToString})
            If Not IsNothing(HasExecutions) Then RequestBody = http_build_query({"symbol"}, {SymbolCurrency})
            Return Await _Requester.Post(Of CancelAllOpenOrders)("accounts/" & AccountID & "/cancel_all_open_orders?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Delete, Token.AcessToken, False, True).ConfigureAwait(False)
        End Function

        Public Async Function ListAllOrders(ByVal AccountID As String, Optional ByVal HasExecutions As Boolean = Nothing, Optional ByVal SymbolCurrency As String = Nothing, Optional ByVal Status As String = Nothing, Optional ByVal Size As String = Nothing) As Task(Of ListAllOrders) Implements IMercadoBitcoinClient.ListAllOrders
            _Requester.Configuration.Check()
            Dim Token = Await Authorization()
            Dim RequestBody As String = String.Empty
            If Not IsNothing(HasExecutions) Then RequestBody = http_build_query({"has_executions"}, {HasExecutions.ToString})
            If Not IsNothing(HasExecutions) Then RequestBody = http_build_query({"symbol"}, {SymbolCurrency})
            If Not IsNothing(HasExecutions) Then RequestBody = http_build_query({"status"}, {Status})
            If Not IsNothing(HasExecutions) Then RequestBody = http_build_query({"size"}, {Size})
            Return Await _Requester.Post(Of ListAllOrders)("accounts/" & AccountID & "/orders?" & RequestBody, New Dictionary(Of String, String), HttpMethod.Get, Token.AcessToken, False, True).ConfigureAwait(False)
        End Function


#End Region

#End Region

#Region "API DE AUTORIZAÇÃO"
        Friend Async Function Authorization() As Task(Of Authorization) Implements IMercadoBitcoinClient.Autorization
            Return Await _Requester.Post(Of Authorization)("authorize", New Dictionary(Of String, String) From {{"login", _Requester.Configuration.TAPI_ID}, {"password", _Requester.Configuration.TAPI_SECRET}}, HttpMethod.Post).ConfigureAwait(False)
        End Function
#End Region


        Public Sub Dispose() Implements IMercadoBitcoinClient.Dispose
            Dim Disposable As IDisposable = Nothing

            If [Implements].Assign(Disposable, TryCast(_Requester, IDisposable)) IsNot Nothing Then
                Disposable.Dispose()
            End If
        End Sub
        Private Class [Implements]
            Shared Function Assign(Of T)(ByRef Target As T, Value As T) As T
                Target = Value
                Return Value
            End Function
        End Class

    End Class
End Namespace
