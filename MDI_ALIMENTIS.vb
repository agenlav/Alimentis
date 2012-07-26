Imports System.Windows.Forms

Public Class MDI_ALIMENTIS

    Public p_stato As String
    Public CONNESSO = 1
    Public DISCONNESSO = 0

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Crea una nuova istanza del form figlio.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Imposta il form come figlio di questo form MDI prima di visualizzarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Finestra " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: aggiungere qui il codice per l'apertura del file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: aggiungere qui il codice per il salvataggio del contenuto corrente del form in un file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilizzare My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData per recuperare informazioni dagli Appunti.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Chiude tutti i form figlio del form padre.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub ConnessioneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConnessioneToolStripMenuItem.Click

        If Me.p_stato = DISCONNESSO Then
            MsgBox("Eseguire la connessione!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attenzione!")
            Exit Sub
        End If

        Dim lf_utente As New F_utente
        lf_utente.MdiParent = Me

        m_ChildFormNumber += 1
        lf_utente.Text = "Nuovo Utente " & m_ChildFormNumber

        lf_utente.Show()

    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'AliDBDataSet.operatori'. È possibile spostarla o rimuoverla se necessario.


    End Sub

    Private Sub Connetti_Click(sender As System.Object, e As System.EventArgs) Handles Connetti.Click
        Dim lf_connetti As New F_Accesso

        lf_connetti.Show()

    End Sub

    Public Sub Connessione()
        If p_stato Then
            Me.StatusStrip.Items(0).Text = "Connesso"
        Else
            Me.StatusStrip.Items(0).Text = "Disconnesso"
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripButton.Click

    End Sub

    Shared Function AliDBDataSetTableAdapters() As Object
        Throw New NotImplementedException
    End Function

End Class
