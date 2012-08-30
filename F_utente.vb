Public Class F_utente

    Private Sub UtentiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UtentiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtentiBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.AliDBDataSet)

    End Sub

    Private Sub F_utente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.cittadinanza'. È possibile spostarla o rimuoverla se necessario.
        Me.CittadinanzaTableAdapter.Fill(Me.AliDBDataSet.cittadinanza)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.stato_civile'. È possibile spostarla o rimuoverla se necessario.
        Me.Stato_civileTableAdapter.Fill(Me.AliDBDataSet.stato_civile)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.titolo_studio'. È possibile spostarla o rimuoverla se necessario.
        Me.Titolo_studioTableAdapter.Fill(Me.AliDBDataSet.titolo_studio)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.operatori'. È possibile spostarla o rimuoverla se necessario.
        Me.OperatoriTableAdapter.Fill(Me.AliDBDataSet.operatori)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.utenti'. È possibile spostarla o rimuoverla se necessario.
        Me.UtentiTableAdapter.Fill(Me.AliDBDataSet.utenti)

    End Sub

    Private Sub ID_nazionalitaLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class