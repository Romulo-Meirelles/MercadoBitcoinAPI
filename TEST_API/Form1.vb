Imports MercadoBitcoin.API.Core
Public Class Form1
    Private TAPI_ID As String = "khmnm8l4i9elpckrsxgniffcvrkevow4qqgimkieomzg661esu17vtgcxaqs"
    ReadOnly TAPI_SECRET As String = "ldxraasqutcee1xt6ywoqxdxnp7v9agbsojaff6ucxixikqtmlwzc1zmrx4b"
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using Client = MercadoBitcoinClient.Create(New ApiConfig With {.TAPI_ID = TAPI_ID, .TAPI_SECRET = TAPI_SECRET})
            Try


                '--------------- API DE DADOS ----------------

                'Dim H = Await Client.GetFeesFromAsset(Asset:="BTC")
                'Console.WriteLine(H.ToString)

                'Dim GOB = Await Client.GetOrderBook(SymbolCurrency:="BTC-BRL", Limit:=10)
                'Console.WriteLine(GOB.ToString)

                'Dim LT = Await Client.ListTrades(SymbolCurrency:="BTC-BRL")
                'Console.WriteLine(LT.ToString)

                'Dim LC = Await Client.ListCandles(SymbolCurrency:="BTC-BRL", Resolution:="1h", [To]:=Date.Now, From:=Date.Now.AddDays(-1))
                'Console.WriteLine(LC.ToString)

                'Dim LS = Await Client.ListSymbol(SymbolCurrency:="BTC-BRL")
                'Console.WriteLine(LS.ToString)

                'Dim LTS = Await Client.ListTickers(SymbolCurrency:="BTC-BRL,LTC-BRL")
                'Console.WriteLine(LTS.ToString)

                '-------------- API TRADER ACCOUNT --------------
                'Dim AccountID = Await Client.ListAccount()
                'Console.WriteLine(AccountID.Root.Item(0).Identificacao) 'Result: (xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end)

                'Dim LA = Await Client.ListAccount()
                'Console.WriteLine(LA.ToString)

                'Dim LB = Await Client.ListBalance(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end")
                'Console.WriteLine(LB.ToString)

                'Dim LP = Await Client.ListPositions(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC-BRL")
                'Console.WriteLine(LP.ToString)

                '--------------API TRADER WALLET ----------------

                'Dim LD = Await Client.ListDeposits(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC", From:=Date.Now.AddYears(-3), [To]:=Date.Now)
                'Console.WriteLine(LD.ToString)

                'Dim WC = Await Client.WithdrawCoin(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC", AccountRef:="1", Address:="687fadsARQWE65sf4qFSDFQWsf654qwsASDF", Description:="description example", DestinationTag:="string", NetWork:="stellar", Quantity:="2.5", Fee:="2")
                'Console.WriteLine(WC.ToString)

                'Dim LP = Await Client.GetWithdrawCoin(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC", WithdrawID:="1")
                'Console.WriteLine(LP.ToString)

                '-------------- API TRADER ---------------------

                'Dim LO = Await Client.ListOrders(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC-BRL")
                'Console.WriteLine(LO.ToString)

                'Dim PO = Await Client.PlaceOrders(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC-BRL", Async:=True, Cost:=100, ExternalId:="134872873", LimitPrice:=9997, Quantity:="0.001", Side:="buy", StopPrice:=1000, Type:="limit")
                'Console.WriteLine(PO.ToString)

                'Dim CO = Await Client.CancelOrder(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC-BRL", OrderID:="123546")
                'Console.WriteLine(CO.ToString)

                'Dim CO = Await Client.CancelOrder(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC-BRL", OrderID:="123546")
                'Console.WriteLine(CO.ToString)

                'Dim GO = Await Client.GetOrder(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", SymbolCurrency:="BTC-BRL", OrderID:="123546")
                'Console.WriteLine(GO.ToString)

                'Dim GO = Await Client.CancellAllOpenOrder(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", HasExecutions:=False, SymbolCurrency:="BTC-BRL")
                'Console.WriteLine(GO.ToString)

                'Dim LAO = Await Client.ListAllOrders(AccountID:="xfyh33gfbqeg1svo4on04lakkoc4ab82yhqad4h40wizxfennt3lt9qi5end", HasExecutions:=False, SymbolCurrency:="BTC-BRL", Status:="filled", Size:="1")
                'Console.WriteLine(LAO.ToString)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub
End Class
