Public Class F_utente

    Private Sub UtentiBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UtentiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtentiBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.AliDBDataSet)

    End Sub

    Private Sub F_utente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.altri_redditi'. È possibile spostarla o rimuoverla se necessario.
        Me.Altri_redditiTableAdapter.Fill(Me.AliDBDataSet.altri_redditi)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.reddito_individuale'. È possibile spostarla o rimuoverla se necessario.
        Me.Reddito_individualeTableAdapter.Fill(Me.AliDBDataSet.reddito_individuale)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.condizione_professionale'. È possibile spostarla o rimuoverla se necessario.
        Me.Condizione_professionaleTableAdapter.Fill(Me.AliDBDataSet.condizione_professionale)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.nucleo_familiare'. È possibile spostarla o rimuoverla se necessario.
        Me.Nucleo_familiareTableAdapter.Fill(Me.AliDBDataSet.nucleo_familiare)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.alloggio'. È possibile spostarla o rimuoverla se necessario.
        Me.AlloggioTableAdapter.Fill(Me.AliDBDataSet.alloggio)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.dimora'. È possibile spostarla o rimuoverla se necessario.
        Me.DimoraTableAdapter.Fill(Me.AliDBDataSet.dimora)
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.paesi'. È possibile spostarla o rimuoverla se necessario.
        Me.PaesiTableAdapter.Fill(Me.AliDBDataSet.paesi)
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

    Private Sub ID_comune_residenzaLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ID_dimoraLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ID_partnerLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Lavoro_esteroLabel_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class