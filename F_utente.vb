Public Class F_utente

    Private Sub UtentiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UtentiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtentiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AliDBDataSet)

    End Sub

    Private Sub F_utente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.utenti'. È possibile spostarla o rimuoverla se necessario.
        Me.UtentiTableAdapter.Fill(Me.AliDBDataSet.utenti)

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles G_sesso.Enter

    End Sub
End Class