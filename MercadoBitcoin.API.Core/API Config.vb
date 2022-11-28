
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
    Public Class ApiConfig
        Public Property TAPI_ID As String
        Public Property TAPI_SECRET As String
        Public Property BaseUrl As String = "https://api.mercadobitcoin.net/api/v4/"
        Public Sub Check()
            If String.IsNullOrEmpty(TAPI_ID) Then Throw New ArgumentException("The TAPI_ID key Mercado Bitcoin is missing.", NameOf(ApiConfig.TAPI_ID))
            If String.IsNullOrEmpty(TAPI_SECRET) Then Throw New ArgumentException("The TAPI_SECRET Mercado Bitcoin key is missing.", NameOf(ApiConfig.TAPI_SECRET))
        End Sub
    End Class
End Namespace
