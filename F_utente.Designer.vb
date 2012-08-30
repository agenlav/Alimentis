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
        Dim ID_sessoLabel As System.Windows.Forms.Label
        Dim ID_titolo_studioLabel As System.Windows.Forms.Label
        Dim ID_stato_civileLabel As System.Windows.Forms.Label
        Dim ID_cittadinanzaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_utente))
        Dim ID_nazionalitaLabel As System.Windows.Forms.Label
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
        Me.OperatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperatoriTableAdapter = New Alimentis.AliDBDataSetTableAdapters.operatoriTableAdapter()
        Me.FillBy_titoli_studioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy_titoli_studioToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ID_sessoComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_titolo_studioComboBox = New System.Windows.Forms.ComboBox()
        Me.TitolostudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titolo_studioTableAdapter = New Alimentis.AliDBDataSetTableAdapters.titolo_studioTableAdapter()
        Me.ID_stato_civileComboBox = New System.Windows.Forms.ComboBox()
        Me.StatocivileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stato_civileTableAdapter = New Alimentis.AliDBDataSetTableAdapters.stato_civileTableAdapter()
        Me.ID_cittadinanzaComboBox = New System.Windows.Forms.ComboBox()
        Me.CittadinanzaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CittadinanzaTableAdapter = New Alimentis.AliDBDataSetTableAdapters.cittadinanzaTableAdapter()
        Me.ID_nazionalitaComboBox = New System.Windows.Forms.ComboBox()
        ID_centroLabel = New System.Windows.Forms.Label()
        ID_utenteLabel = New System.Windows.Forms.Label()
        Data_registrazioneLabel = New System.Windows.Forms.Label()
        ID_sessoLabel = New System.Windows.Forms.Label()
        ID_titolo_studioLabel = New System.Windows.Forms.Label()
        ID_stato_civileLabel = New System.Windows.Forms.Label()
        ID_cittadinanzaLabel = New System.Windows.Forms.Label()
        ID_nazionalitaLabel = New System.Windows.Forms.Label()
        CType(Me.AliDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtentiBindingNavigator.SuspendLayout()
        CType(Me.OperatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitolostudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatocivileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CittadinanzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ID_sessoLabel
        '
        ID_sessoLabel.AutoSize = True
        ID_sessoLabel.Location = New System.Drawing.Point(108, 140)
        ID_sessoLabel.Name = "ID_sessoLabel"
        ID_sessoLabel.Size = New System.Drawing.Size(45, 13)
        ID_sessoLabel.TabIndex = 13
        ID_sessoLabel.Text = "Genere:"
        '
        'ID_titolo_studioLabel
        '
        ID_titolo_studioLabel.AutoSize = True
        ID_titolo_studioLabel.Location = New System.Drawing.Point(86, 167)
        ID_titolo_studioLabel.Name = "ID_titolo_studioLabel"
        ID_titolo_studioLabel.Size = New System.Drawing.Size(67, 13)
        ID_titolo_studioLabel.TabIndex = 14
        ID_titolo_studioLabel.Text = "Titolo studio:"
        '
        'ID_stato_civileLabel
        '
        ID_stato_civileLabel.AutoSize = True
        ID_stato_civileLabel.Location = New System.Drawing.Point(91, 194)
        ID_stato_civileLabel.Name = "ID_stato_civileLabel"
        ID_stato_civileLabel.Size = New System.Drawing.Size(62, 13)
        ID_stato_civileLabel.TabIndex = 15
        ID_stato_civileLabel.Text = "Stato civile:"
        '
        'ID_cittadinanzaLabel
        '
        ID_cittadinanzaLabel.AutoSize = True
        ID_cittadinanzaLabel.Location = New System.Drawing.Point(84, 221)
        ID_cittadinanzaLabel.Name = "ID_cittadinanzaLabel"
        ID_cittadinanzaLabel.Size = New System.Drawing.Size(68, 13)
        ID_cittadinanzaLabel.TabIndex = 16
        ID_cittadinanzaLabel.Text = "Cittadinanza:"
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
        Me.TableAdapterManager.alloggioTableAdapter = Nothing
        Me.TableAdapterManager.altri_redditiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cittadinanzaTableAdapter = Nothing
        Me.TableAdapterManager.condizione_professionaleTableAdapter = Nothing
        Me.TableAdapterManager.dimoraTableAdapter = Nothing
        Me.TableAdapterManager.nucleo_familiareTableAdapter = Nothing
        Me.TableAdapterManager.operatoriTableAdapter = Nothing
        Me.TableAdapterManager.paesiTableAdapter = Nothing
        Me.TableAdapterManager.reddito_individualeTableAdapter = Nothing
        Me.TableAdapterManager.stato_civileTableAdapter = Nothing
        Me.TableAdapterManager.titolo_studioTableAdapter = Nothing
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
        'OperatoriBindingSource
        '
        Me.OperatoriBindingSource.DataMember = "operatori"
        Me.OperatoriBindingSource.DataSource = Me.AliDBDataSet
        '
        'OperatoriTableAdapter
        '
        Me.OperatoriTableAdapter.ClearBeforeFill = True
        '
        'FillBy_titoli_studioToolStripButton
        '
        Me.FillBy_titoli_studioToolStripButton.Name = "FillBy_titoli_studioToolStripButton"
        Me.FillBy_titoli_studioToolStripButton.Size = New System.Drawing.Size(23, 23)
        '
        'FillBy_titoli_studioToolStripButton1
        '
        Me.FillBy_titoli_studioToolStripButton1.Name = "FillBy_titoli_studioToolStripButton1"
        Me.FillBy_titoli_studioToolStripButton1.Size = New System.Drawing.Size(23, 23)
        '
        'ID_sessoComboBox
        '
        Me.ID_sessoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_sesso", True))
        Me.ID_sessoComboBox.FormattingEnabled = True
        Me.ID_sessoComboBox.Items.AddRange(New Object() {"M", "F"})
        Me.ID_sessoComboBox.Location = New System.Drawing.Point(159, 134)
        Me.ID_sessoComboBox.Name = "ID_sessoComboBox"
        Me.ID_sessoComboBox.Size = New System.Drawing.Size(52, 21)
        Me.ID_sessoComboBox.TabIndex = 14
        '
        'ID_titolo_studioComboBox
        '
        Me.ID_titolo_studioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_titolo_studio", True))
        Me.ID_titolo_studioComboBox.DataSource = Me.TitolostudioBindingSource
        Me.ID_titolo_studioComboBox.DisplayMember = "descrizione"
        Me.ID_titolo_studioComboBox.FormattingEnabled = True
        Me.ID_titolo_studioComboBox.Location = New System.Drawing.Point(159, 161)
        Me.ID_titolo_studioComboBox.Name = "ID_titolo_studioComboBox"
        Me.ID_titolo_studioComboBox.Size = New System.Drawing.Size(271, 21)
        Me.ID_titolo_studioComboBox.TabIndex = 15
        Me.ID_titolo_studioComboBox.ValueMember = "ID_titolo_studio"
        '
        'TitolostudioBindingSource
        '
        Me.TitolostudioBindingSource.DataMember = "titolo_studio"
        Me.TitolostudioBindingSource.DataSource = Me.AliDBDataSet
        '
        'Titolo_studioTableAdapter
        '
        Me.Titolo_studioTableAdapter.ClearBeforeFill = True
        '
        'ID_stato_civileComboBox
        '
        Me.ID_stato_civileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_stato_civile", True))
        Me.ID_stato_civileComboBox.DataSource = Me.StatocivileBindingSource
        Me.ID_stato_civileComboBox.DisplayMember = "descrizione"
        Me.ID_stato_civileComboBox.FormattingEnabled = True
        Me.ID_stato_civileComboBox.Location = New System.Drawing.Point(159, 188)
        Me.ID_stato_civileComboBox.Name = "ID_stato_civileComboBox"
        Me.ID_stato_civileComboBox.Size = New System.Drawing.Size(271, 21)
        Me.ID_stato_civileComboBox.TabIndex = 16
        Me.ID_stato_civileComboBox.ValueMember = "ID_stato_civile"
        '
        'StatocivileBindingSource
        '
        Me.StatocivileBindingSource.DataMember = "stato_civile"
        Me.StatocivileBindingSource.DataSource = Me.AliDBDataSet
        '
        'Stato_civileTableAdapter
        '
        Me.Stato_civileTableAdapter.ClearBeforeFill = True
        '
        'ID_cittadinanzaComboBox
        '
        Me.ID_cittadinanzaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_cittadinanza", True))
        Me.ID_cittadinanzaComboBox.DataSource = Me.CittadinanzaBindingSource
        Me.ID_cittadinanzaComboBox.DisplayMember = "descrizione"
        Me.ID_cittadinanzaComboBox.FormattingEnabled = True
        Me.ID_cittadinanzaComboBox.Location = New System.Drawing.Point(159, 215)
        Me.ID_cittadinanzaComboBox.Name = "ID_cittadinanzaComboBox"
        Me.ID_cittadinanzaComboBox.Size = New System.Drawing.Size(271, 21)
        Me.ID_cittadinanzaComboBox.TabIndex = 17
        Me.ID_cittadinanzaComboBox.ValueMember = "ID_cittadinanza"
        '
        'CittadinanzaBindingSource
        '
        Me.CittadinanzaBindingSource.DataMember = "cittadinanza"
        Me.CittadinanzaBindingSource.DataSource = Me.AliDBDataSet
        '
        'CittadinanzaTableAdapter
        '
        Me.CittadinanzaTableAdapter.ClearBeforeFill = True
        '
        'ID_nazionalitaLabel
        '
        ID_nazionalitaLabel.AutoSize = True
        ID_nazionalitaLabel.Location = New System.Drawing.Point(79, 247)
        ID_nazionalitaLabel.Name = "ID_nazionalitaLabel"
        ID_nazionalitaLabel.Size = New System.Drawing.Size(74, 13)
        ID_nazionalitaLabel.TabIndex = 17
        ID_nazionalitaLabel.Text = "ID nazionalita:"
        AddHandler ID_nazionalitaLabel.Click, AddressOf Me.ID_nazionalitaLabel_Click
        '
        'ID_nazionalitaComboBox
        '
        Me.ID_nazionalitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_nazionalita", True))
        Me.ID_nazionalitaComboBox.FormattingEnabled = True
        Me.ID_nazionalitaComboBox.Location = New System.Drawing.Point(159, 242)
        Me.ID_nazionalitaComboBox.Name = "ID_nazionalitaComboBox"
        Me.ID_nazionalitaComboBox.Size = New System.Drawing.Size(271, 21)
        Me.ID_nazionalitaComboBox.TabIndex = 18
        '
        'F_utente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 751)
        Me.Controls.Add(ID_nazionalitaLabel)
        Me.Controls.Add(Me.ID_nazionalitaComboBox)
        Me.Controls.Add(ID_cittadinanzaLabel)
        Me.Controls.Add(Me.ID_cittadinanzaComboBox)
        Me.Controls.Add(ID_stato_civileLabel)
        Me.Controls.Add(Me.ID_stato_civileComboBox)
        Me.Controls.Add(ID_titolo_studioLabel)
        Me.Controls.Add(Me.ID_titolo_studioComboBox)
        Me.Controls.Add(ID_sessoLabel)
        Me.Controls.Add(Me.ID_sessoComboBox)
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
        CType(Me.OperatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitolostudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatocivileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CittadinanzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents OperatoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatoriTableAdapter As Alimentis.AliDBDataSetTableAdapters.operatoriTableAdapter
    Friend WithEvents FillBy_titoli_studioToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillBy_titoli_studioToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_sessoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_titolo_studioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TitolostudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titolo_studioTableAdapter As Alimentis.AliDBDataSetTableAdapters.titolo_studioTableAdapter
    Friend WithEvents ID_stato_civileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatocivileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stato_civileTableAdapter As Alimentis.AliDBDataSetTableAdapters.stato_civileTableAdapter
    Friend WithEvents ID_cittadinanzaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CittadinanzaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CittadinanzaTableAdapter As Alimentis.AliDBDataSetTableAdapters.cittadinanzaTableAdapter
    Friend WithEvents ID_nazionalitaComboBox As System.Windows.Forms.ComboBox
End Class
