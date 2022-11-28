Imports Newtonsoft.Json

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
    Public Class ListCandles
        Inherits MercadoBitcoinResponse


        <JsonProperty("c")>
        Public Property Preco_Fechamento As List(Of String)

        <JsonProperty("h")>
        Public Property Preco_Mais_Alto As List(Of String)

        <JsonProperty("l")>
        Public Property Preco_Mais_Baixo As List(Of String)

        <JsonProperty("o")>
        Public Property Preco_de_Abertura As List(Of String)

        <JsonProperty("t")>
        Public Property Inicio_do_Bucket As List(Of String)

        <JsonProperty("v")>
        Public Property Volume_de_Trading As List(Of String)


        Public Overrides Function ToString() As String
            Dim A As String = String.Empty

            A += "Preço de Fechamento: " & vbCrLf
            For i = 0 To Preco_Fechamento.Count - 1
                A += Preco_Fechamento(i).ToString & vbCrLf
            Next

            A += vbCrLf & "Preço Mais Alto: " & vbCrLf
            For i = 0 To Preco_Mais_Alto.Count - 1
                A += Preco_Mais_Alto(i).ToString & vbCrLf
            Next

            A += vbCrLf & "Preço Mais Baixo: " & vbCrLf
            For i = 0 To Preco_Mais_Baixo.Count - 1
                A += Preco_Mais_Baixo(i).ToString & vbCrLf
            Next

            A += vbCrLf & "Preço de Abertura: " & vbCrLf
            For i = 0 To Preco_de_Abertura.Count - 1
                A += Preco_de_Abertura(i).ToString & vbCrLf
            Next

            A += vbCrLf & "Incício de Bucket: " & vbCrLf
            For i = 0 To Inicio_do_Bucket.Count - 1
                A += Inicio_do_Bucket(i).ToString & vbCrLf
            Next

            A += vbCrLf & "Volume de Trading: " & vbCrLf
            For i = 0 To Volume_de_Trading.Count - 1
                A += Volume_de_Trading(i).ToString & vbCrLf
            Next

            Return A
        End Function
    End Class
End Namespace