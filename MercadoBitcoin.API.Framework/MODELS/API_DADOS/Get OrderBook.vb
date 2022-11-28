Imports Newtonsoft.Json

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
    Public Class GetOrderBook
        Inherits MercadoBitcoinResponse

        <JsonProperty("asks")>
        Public Property Asks As List(Of List(Of Object))

        <JsonProperty("bids")>
        Public Property Bids As List(Of List(Of Object))

        <JsonProperty("timestamp")>
        Public Property TimeStamp As String

        Public Overrides Function ToString() As String
            Dim A As String = String.Empty
            A += "Preço da Oferta: " & vbCrLf
            For i = 0 To Bids.Count - 1
                A += Bids.Item(i).Item(0).ToString & " | " & Bids.Item(i).Item(1).ToString & vbCrLf
            Next

            A += vbCrLf & "Quantia Total da Oferta: " & vbCrLf
            For i = 0 To Asks.Count - 1
                A += Asks.Item(i).Item(0).ToString & " | " & Asks.Item(i).Item(1).ToString & vbCrLf
            Next
            A += "Fuso Horário (TimeStamp): " & UnixToTime(TimeStamp).ToString
            Return A
        End Function
    End Class
End Namespace