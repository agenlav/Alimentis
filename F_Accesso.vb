Imports System.Data.OleDb



Public Class F_Accesso

    Public l_stato As Integer

    ' TODO: inserire il codice per l'esecuzione dell'autenticazione personalizzata tramite il nome utente e la password forniti 
    ' (Vedere http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'entità personalizzata può essere quindi collegata all'entità del thread corrente nel modo seguente: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' dove CustomPrincipal è l'implementazione di IPrincipal utilizzata per eseguire l'autenticazione. 
    ' My.User restituirà quindi informazioni sull'identità incapsulate nell'oggetto CustomPrincipal,
    ' quali il nome utente, il nome visualizzato e così via.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ls_operatore As String
        Dim ls_password As String

        ls_operatore = Me.operatoreTextBox.Text
        ls_password = Me.PasswordTextBox.Text

        Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Alimentis\Alimentis_repo\Alimentis\AliDB.mdb;Persist Security Info=False"
        Dim cmd As String = "Select ID_operatore from operatori WHERE operatore = '" & ls_operatore & "' AND password = '" & ls_password & "';"
        Dim adapter As New OleDbDataAdapter(cmd, conn)
        Dim topics As New DataSet
        adapter.Fill(topics)

        If topics.Tables(0).Rows.Count = 0 Then
            MsgBox("User o password errata.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Attenzione!!!")
            l_stato = 0
        Else
            MsgBox("Connessione eseguita.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "OK!!!")
            l_stato = 1
        End If

        topics.Clear()

        MDI_ALIMENTIS.p_stato = l_stato

        MDI_ALIMENTIS.Connessione()

        Me.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
