<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_utente
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_centroLabel As System.Windows.Forms.Label
        Dim ID_utenteLabel As System.Windows.Forms.Label
        Dim Data_registrazioneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_utente))
        Me.AliDBDataSet = New Alimentis.AliDBDataSet()
        Me.UtentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtentiTableAdapter = New Alimentis.AliDBDataSetTableAdapters.utentiTableAdapter()
        Me.TableAdapterManager = New Alimentis.AliDBDataSetTableAdapters.TableAdapterManager()
        Me.UtentiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UtentiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_centroTextBox = New System.Windows.Forms.TextBox()
        Me.ID_utenteTextBox = New System.Windows.Forms.TextBox()
        Me.Data_registrazioneDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.G_sesso = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.UtentiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ID_centroLabel = New System.Windows.Forms.Label()
        ID_utenteLabel = New System.Windows.Forms.Label()
        Data_registrazioneLabel = New System.Windows.Forms.Label()
        CType(Me.AliDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtentiBindingNavigator.SuspendLayout()
        Me.G_sesso.SuspendLayout()
        CType(Me.UtentiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_centroLabel
        '
        ID_centroLabel.AutoSize = True
        ID_centroLabel.Location = New System.Drawing.Point(8, 74)
        ID_centroLabel.Name = "ID_centroLabel"
        ID_centroLabel.Size = New System.Drawing.Size(54, 13)
        ID_centroLabel.TabIndex = 1
        ID_centroLabel.Text = "ID centro:"
        '
        'ID_utenteLabel
        '
        ID_utenteLabel.AutoSize = True
        ID_utenteLabel.Location = New System.Drawing.Point(8, 31)
        ID_utenteLabel.Name = "ID_utenteLabel"
        ID_utenteLabel.Size = New System.Drawing.Size(54, 13)
        ID_utenteLabel.TabIndex = 3
        ID_utenteLabel.Text = "ID utente:"
        '
        'Data_registrazioneLabel
        '
        Data_registrazioneLabel.AutoSize = True
        Data_registrazioneLabel.Location = New System.Drawing.Point(232, 78)
        Data_registrazioneLabel.Name = "Data_registrazioneLabel"
        Data_registrazioneLabel.Size = New System.Drawing.Size(93, 13)
        Data_registrazioneLabel.TabIndex = 5
        Data_registrazioneLabel.Text = "data registrazione:"
        '
        'AliDBDataSet
        '
        Me.AliDBDataSet.DataSetName = "AliDBDataSet"
        Me.AliDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtentiBindingSource
        '
        Me.UtentiBindingSource.DataMember = "utenti"
        Me.UtentiBindingSource.DataSource = Me.AliDBDataSet
        '
        'UtentiTableAdapter
        '
        Me.UtentiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.operatoriTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Alimentis.AliDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.utentiTableAdapter = Me.UtentiTableAdapter
        '
        'UtentiBindingNavigator
        '
        Me.UtentiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UtentiBindingNavigator.BindingSource = Me.UtentiBindingSource
        Me.UtentiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UtentiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UtentiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UtentiBindingNavigatorSaveItem})
        Me.UtentiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UtentiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UtentiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UtentiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UtentiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UtentiBindingNavigator.Name = "UtentiBindingNavigator"
        Me.UtentiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UtentiBindingNavigator.Size = New System.Drawing.Size(1218, 25)
        Me.UtentiBindingNavigator.TabIndex = 0
        Me.UtentiBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UtentiBindingNavigatorSaveItem
        '
        Me.UtentiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UtentiBindingNavigatorSaveItem.Image = CType(resources.GetObject("UtentiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UtentiBindingNavigatorSaveItem.Name = "UtentiBindingNavigatorSaveItem"
        Me.UtentiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UtentiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ID_centroTextBox
        '
        Me.ID_centroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_centro", True))
        Me.ID_centroTextBox.Location = New System.Drawing.Point(68, 74)
        Me.ID_centroTextBox.Name = "ID_centroTextBox"
        Me.ID_centroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_centroTextBox.TabIndex = 2
        '
        'ID_utenteTextBox
        '
        Me.ID_utenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_utente", True))
        Me.ID_utenteTextBox.Location = New System.Drawing.Point(68, 28)
        Me.ID_utenteTextBox.Name = "ID_utenteTextBox"
        Me.ID_utenteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_utenteTextBox.TabIndex = 4
        '
        'Data_registrazioneDateTimePicker
        '
        Me.Data_registrazioneDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.UtentiBindingSource, "data_registrazione", True))
        Me.Data_registrazioneDateTimePicker.Location = New System.Drawing.Point(331, 74)
        Me.Data_registrazioneDateTimePicker.Name = "Data_registrazioneDateTimePicker"
        Me.Data_registrazioneDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Data_registrazioneDateTimePicker.TabIndex = 6
        '
        'G_sesso
        '
        Me.G_sesso.Controls.Add(Me.RadioButton2)
        Me.G_sesso.Controls.Add(Me.RadioButton1)
        Me.G_sesso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource1, "ID_sesso", True))
        Me.G_sesso.Location = New System.Drawing.Point(73, 125)
        Me.G_sesso.Name = "G_sesso"
        Me.G_sesso.Size = New System.Drawing.Size(124, 79)
        Me.G_sesso.TabIndex = 7
        Me.G_sesso.TabStop = False
        Me.G_sesso.Text = "Genere"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Alimentis.My.MySettings.Default, "F", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton2.Location = New System.Drawing.Point(27, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Femminile"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Alimentis.My.MySettings.Default, "M", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton1.Location = New System.Drawing.Point(27, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Maschile"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'UtentiBindingSource1
        '
        Me.UtentiBindingSource1.DataMember = "utenti"
        Me.UtentiBindingSource1.DataSource = Me.AliDBDataSet
        '
        'F_utente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 751)
        Me.Controls.Add(Me.G_sesso)
        Me.Controls.Add(Data_registrazioneLabel)
        Me.Controls.Add(Me.Data_registrazioneDateTimePicker)
        Me.Controls.Add(ID_utenteLabel)
        Me.Controls.Add(Me.ID_utenteTextBox)
        Me.Controls.Add(ID_centroLabel)
        Me.Controls.Add(Me.ID_centroTextBox)
        Me.Controls.Add(Me.UtentiBindingNavigator)
        Me.Name = "F_utente"
        Me.Text = "Form1"
        CType(Me.AliDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtentiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UtentiBindingNavigator.ResumeLayout(False)
        Me.UtentiBindingNavigator.PerformLayout()
        Me.G_sesso.ResumeLayout(False)
        Me.G_sesso.PerformLayout()
        CType(Me.UtentiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AliDBDataSet As Alimentis.AliDBDataSet
    Friend WithEvents UtentiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtentiTableAdapter As Alimentis.AliDBDataSetTableAdapters.utentiTableAdapter
    Friend WithEvents TableAdapterManager As Alimentis.AliDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UtentiBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UtentiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_centroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_utenteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_registrazioneDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents G_sesso As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents UtentiBindingSource1 As System.Windows.Forms.BindingSource
End Class
