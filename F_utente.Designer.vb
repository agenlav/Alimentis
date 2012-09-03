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
        Dim ID_nazionalitaLabel As System.Windows.Forms.Label
        Dim ID_comune_residenzaLabel As System.Windows.Forms.Label
        Dim ID_dimoraLabel As System.Windows.Forms.Label
        Dim ID_tipo_alloggioLabel As System.Windows.Forms.Label
        Dim ID_nucleo_familiareLabel As System.Windows.Forms.Label
        Dim Numero_conviventiLabel As System.Windows.Forms.Label
        Dim ID_partnerLabel As System.Windows.Forms.Label
        Dim ID_figli_conviventiLabel As System.Windows.Forms.Label
        Dim Lavoro_esteroLabel As System.Windows.Forms.Label
        Dim Lavoro_italiaLabel As System.Windows.Forms.Label
        Dim ID_condizione_professionaleLabel As System.Windows.Forms.Label
        Dim ID_redditto_mensileLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_utente))
        Dim ID_altro_reddittoLabel As System.Windows.Forms.Label
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
        Me.PaesiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaesiTableAdapter = New Alimentis.AliDBDataSetTableAdapters.paesiTableAdapter()
        Me.ID_comune_residenzaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_dimoraComboBox = New System.Windows.Forms.ComboBox()
        Me.DimoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DimoraTableAdapter = New Alimentis.AliDBDataSetTableAdapters.dimoraTableAdapter()
        Me.ID_tipo_alloggioComboBox = New System.Windows.Forms.ComboBox()
        Me.AlloggioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlloggioTableAdapter = New Alimentis.AliDBDataSetTableAdapters.alloggioTableAdapter()
        Me.ID_nucleo_familiareComboBox = New System.Windows.Forms.ComboBox()
        Me.NucleofamiliareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nucleo_familiareTableAdapter = New Alimentis.AliDBDataSetTableAdapters.nucleo_familiareTableAdapter()
        Me.Numero_conviventiTextBox = New System.Windows.Forms.TextBox()
        Me.ID_partnerComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_figli_conviventiComboBox = New System.Windows.Forms.ComboBox()
        Me.Lavoro_esteroTextBox = New System.Windows.Forms.TextBox()
        Me.Lavoro_italiaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_condizione_professionaleComboBox = New System.Windows.Forms.ComboBox()
        Me.CondizioneprofessionaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Condizione_professionaleTableAdapter = New Alimentis.AliDBDataSetTableAdapters.condizione_professionaleTableAdapter()
        Me.ID_redditto_mensileComboBox = New System.Windows.Forms.ComboBox()
        Me.RedditoindividualeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reddito_individualeTableAdapter = New Alimentis.AliDBDataSetTableAdapters.reddito_individualeTableAdapter()
        Me.ID_altro_reddittoComboBox = New System.Windows.Forms.ComboBox()
        Me.AliDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AltriredditiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Altri_redditiTableAdapter = New Alimentis.AliDBDataSetTableAdapters.altri_redditiTableAdapter()
        ID_centroLabel = New System.Windows.Forms.Label()
        ID_utenteLabel = New System.Windows.Forms.Label()
        Data_registrazioneLabel = New System.Windows.Forms.Label()
        ID_sessoLabel = New System.Windows.Forms.Label()
        ID_titolo_studioLabel = New System.Windows.Forms.Label()
        ID_stato_civileLabel = New System.Windows.Forms.Label()
        ID_cittadinanzaLabel = New System.Windows.Forms.Label()
        ID_nazionalitaLabel = New System.Windows.Forms.Label()
        ID_comune_residenzaLabel = New System.Windows.Forms.Label()
        ID_dimoraLabel = New System.Windows.Forms.Label()
        ID_tipo_alloggioLabel = New System.Windows.Forms.Label()
        ID_nucleo_familiareLabel = New System.Windows.Forms.Label()
        Numero_conviventiLabel = New System.Windows.Forms.Label()
        ID_partnerLabel = New System.Windows.Forms.Label()
        ID_figli_conviventiLabel = New System.Windows.Forms.Label()
        Lavoro_esteroLabel = New System.Windows.Forms.Label()
        Lavoro_italiaLabel = New System.Windows.Forms.Label()
        ID_condizione_professionaleLabel = New System.Windows.Forms.Label()
        ID_redditto_mensileLabel = New System.Windows.Forms.Label()
        ID_altro_reddittoLabel = New System.Windows.Forms.Label()
        CType(Me.AliDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtentiBindingNavigator.SuspendLayout()
        CType(Me.OperatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitolostudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatocivileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CittadinanzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaesiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DimoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlloggioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NucleofamiliareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CondizioneprofessionaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedditoindividualeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AliDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltriredditiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        ID_sessoLabel.Location = New System.Drawing.Point(14, 123)
        ID_sessoLabel.Name = "ID_sessoLabel"
        ID_sessoLabel.Size = New System.Drawing.Size(45, 13)
        ID_sessoLabel.TabIndex = 13
        ID_sessoLabel.Text = "Genere:"
        '
        'ID_titolo_studioLabel
        '
        ID_titolo_studioLabel.AutoSize = True
        ID_titolo_studioLabel.Location = New System.Drawing.Point(14, 171)
        ID_titolo_studioLabel.Name = "ID_titolo_studioLabel"
        ID_titolo_studioLabel.Size = New System.Drawing.Size(67, 13)
        ID_titolo_studioLabel.TabIndex = 14
        ID_titolo_studioLabel.Text = "Titolo studio:"
        '
        'ID_stato_civileLabel
        '
        ID_stato_civileLabel.AutoSize = True
        ID_stato_civileLabel.Location = New System.Drawing.Point(16, 218)
        ID_stato_civileLabel.Name = "ID_stato_civileLabel"
        ID_stato_civileLabel.Size = New System.Drawing.Size(62, 13)
        ID_stato_civileLabel.TabIndex = 15
        ID_stato_civileLabel.Text = "Stato civile:"
        '
        'ID_cittadinanzaLabel
        '
        ID_cittadinanzaLabel.AutoSize = True
        ID_cittadinanzaLabel.Location = New System.Drawing.Point(16, 271)
        ID_cittadinanzaLabel.Name = "ID_cittadinanzaLabel"
        ID_cittadinanzaLabel.Size = New System.Drawing.Size(68, 13)
        ID_cittadinanzaLabel.TabIndex = 16
        ID_cittadinanzaLabel.Text = "Cittadinanza:"
        '
        'ID_nazionalitaLabel
        '
        ID_nazionalitaLabel.AutoSize = True
        ID_nazionalitaLabel.Location = New System.Drawing.Point(16, 318)
        ID_nazionalitaLabel.Name = "ID_nazionalitaLabel"
        ID_nazionalitaLabel.Size = New System.Drawing.Size(62, 13)
        ID_nazionalitaLabel.TabIndex = 17
        ID_nazionalitaLabel.Text = "Nazionalità:"
        AddHandler ID_nazionalitaLabel.Click, AddressOf Me.ID_nazionalitaLabel_Click
        '
        'ID_comune_residenzaLabel
        '
        ID_comune_residenzaLabel.AutoSize = True
        ID_comune_residenzaLabel.Location = New System.Drawing.Point(16, 367)
        ID_comune_residenzaLabel.Name = "ID_comune_residenzaLabel"
        ID_comune_residenzaLabel.Size = New System.Drawing.Size(108, 13)
        ID_comune_residenzaLabel.TabIndex = 18
        ID_comune_residenzaLabel.Text = "Comune di residenza:"
        AddHandler ID_comune_residenzaLabel.Click, AddressOf Me.ID_comune_residenzaLabel_Click
        '
        'ID_dimoraLabel
        '
        ID_dimoraLabel.AutoSize = True
        ID_dimoraLabel.Location = New System.Drawing.Point(16, 417)
        ID_dimoraLabel.Name = "ID_dimoraLabel"
        ID_dimoraLabel.Size = New System.Drawing.Size(98, 13)
        ID_dimoraLabel.TabIndex = 19
        ID_dimoraLabel.Text = "Tipologia di dimora:"
        AddHandler ID_dimoraLabel.Click, AddressOf Me.ID_dimoraLabel_Click
        '
        'ID_tipo_alloggioLabel
        '
        ID_tipo_alloggioLabel.AutoSize = True
        ID_tipo_alloggioLabel.Location = New System.Drawing.Point(14, 468)
        ID_tipo_alloggioLabel.Name = "ID_tipo_alloggioLabel"
        ID_tipo_alloggioLabel.Size = New System.Drawing.Size(103, 13)
        ID_tipo_alloggioLabel.TabIndex = 21
        ID_tipo_alloggioLabel.Text = "Tipologia di alloggio:"
        '
        'ID_nucleo_familiareLabel
        '
        ID_nucleo_familiareLabel.AutoSize = True
        ID_nucleo_familiareLabel.Location = New System.Drawing.Point(16, 519)
        ID_nucleo_familiareLabel.Name = "ID_nucleo_familiareLabel"
        ID_nucleo_familiareLabel.Size = New System.Drawing.Size(153, 13)
        ID_nucleo_familiareLabel.TabIndex = 23
        ID_nucleo_familiareLabel.Text = "Nucleo familiare (Con chi vive):"
        '
        'Numero_conviventiLabel
        '
        Numero_conviventiLabel.AutoSize = True
        Numero_conviventiLabel.Location = New System.Drawing.Point(355, 519)
        Numero_conviventiLabel.Name = "Numero_conviventiLabel"
        Numero_conviventiLabel.Size = New System.Drawing.Size(99, 13)
        Numero_conviventiLabel.TabIndex = 25
        Numero_conviventiLabel.Text = "Numero conviventi:"
        '
        'ID_partnerLabel
        '
        ID_partnerLabel.AutoSize = True
        ID_partnerLabel.Location = New System.Drawing.Point(16, 573)
        ID_partnerLabel.Name = "ID_partnerLabel"
        ID_partnerLabel.Size = New System.Drawing.Size(100, 13)
        ID_partnerLabel.TabIndex = 27
        ID_partnerLabel.Text = "Partner convivente:"
        '
        'ID_figli_conviventiLabel
        '
        ID_figli_conviventiLabel.AutoSize = True
        ID_figli_conviventiLabel.Location = New System.Drawing.Point(164, 573)
        ID_figli_conviventiLabel.Name = "ID_figli_conviventiLabel"
        ID_figli_conviventiLabel.Size = New System.Drawing.Size(80, 13)
        ID_figli_conviventiLabel.TabIndex = 29
        ID_figli_conviventiLabel.Text = "Figli conviventi:"
        '
        'Lavoro_esteroLabel
        '
        Lavoro_esteroLabel.AutoSize = True
        Lavoro_esteroLabel.Location = New System.Drawing.Point(526, 218)
        Lavoro_esteroLabel.Name = "Lavoro_esteroLabel"
        Lavoro_esteroLabel.Size = New System.Drawing.Size(236, 13)
        Lavoro_esteroLabel.TabIndex = 31
        Lavoro_esteroLabel.Text = "Lavoro svolto nella patria di origine (per stranieri):"
        AddHandler Lavoro_esteroLabel.Click, AddressOf Me.Lavoro_esteroLabel_Click
        '
        'Lavoro_italiaLabel
        '
        Lavoro_italiaLabel.AutoSize = True
        Lavoro_italiaLabel.Location = New System.Drawing.Point(526, 271)
        Lavoro_italiaLabel.Name = "Lavoro_italiaLabel"
        Lavoro_italiaLabel.Size = New System.Drawing.Size(109, 13)
        Lavoro_italiaLabel.TabIndex = 33
        Lavoro_italiaLabel.Text = "Lavoro svolto in italia:"
        '
        'ID_condizione_professionaleLabel
        '
        ID_condizione_professionaleLabel.AutoSize = True
        ID_condizione_professionaleLabel.Location = New System.Drawing.Point(526, 171)
        ID_condizione_professionaleLabel.Name = "ID_condizione_professionaleLabel"
        ID_condizione_professionaleLabel.Size = New System.Drawing.Size(127, 13)
        ID_condizione_professionaleLabel.TabIndex = 35
        ID_condizione_professionaleLabel.Text = "Condizione professionale:"
        '
        'ID_redditto_mensileLabel
        '
        ID_redditto_mensileLabel.AutoSize = True
        ID_redditto_mensileLabel.Location = New System.Drawing.Point(526, 318)
        ID_redditto_mensileLabel.Name = "ID_redditto_mensileLabel"
        ID_redditto_mensileLabel.Size = New System.Drawing.Size(88, 13)
        ID_redditto_mensileLabel.TabIndex = 37
        ID_redditto_mensileLabel.Text = "Redditto mensile:"
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
        Me.TableAdapterManager.altri_problemiTableAdapter = Nothing
        Me.TableAdapterManager.altri_redditiTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bisogni_immigrazioneTableAdapter = Nothing
        Me.TableAdapterManager.cittadinanzaTableAdapter = Nothing
        Me.TableAdapterManager.condizione_professionaleTableAdapter = Nothing
        Me.TableAdapterManager.detenzioneTableAdapter = Nothing
        Me.TableAdapterManager.dimoraTableAdapter = Nothing
        Me.TableAdapterManager.dipendenzeTableAdapter = Nothing
        Me.TableAdapterManager.handicap_disabilitaTableAdapter = Nothing
        Me.TableAdapterManager.nucleo_familiareTableAdapter = Nothing
        Me.TableAdapterManager.operatoriTableAdapter = Nothing
        Me.TableAdapterManager.paesiTableAdapter = Nothing
        Me.TableAdapterManager.problemi_economiciTableAdapter = Nothing
        Me.TableAdapterManager.problemi_familiariTableAdapter = Nothing
        Me.TableAdapterManager.problemi_lavoroTableAdapter = Nothing
        Me.TableAdapterManager.problemi_saluteTableAdapter = Nothing
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
        Me.ID_sessoComboBox.Location = New System.Drawing.Point(15, 142)
        Me.ID_sessoComboBox.Name = "ID_sessoComboBox"
        Me.ID_sessoComboBox.Size = New System.Drawing.Size(61, 21)
        Me.ID_sessoComboBox.TabIndex = 14
        '
        'ID_titolo_studioComboBox
        '
        Me.ID_titolo_studioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_titolo_studio", True))
        Me.ID_titolo_studioComboBox.DataSource = Me.TitolostudioBindingSource
        Me.ID_titolo_studioComboBox.DisplayMember = "descrizione"
        Me.ID_titolo_studioComboBox.FormattingEnabled = True
        Me.ID_titolo_studioComboBox.Location = New System.Drawing.Point(15, 187)
        Me.ID_titolo_studioComboBox.Name = "ID_titolo_studioComboBox"
        Me.ID_titolo_studioComboBox.Size = New System.Drawing.Size(320, 21)
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
        Me.ID_stato_civileComboBox.Location = New System.Drawing.Point(17, 234)
        Me.ID_stato_civileComboBox.Name = "ID_stato_civileComboBox"
        Me.ID_stato_civileComboBox.Size = New System.Drawing.Size(320, 21)
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
        Me.ID_cittadinanzaComboBox.Location = New System.Drawing.Point(15, 287)
        Me.ID_cittadinanzaComboBox.Name = "ID_cittadinanzaComboBox"
        Me.ID_cittadinanzaComboBox.Size = New System.Drawing.Size(320, 21)
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
        'ID_nazionalitaComboBox
        '
        Me.ID_nazionalitaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_nazionalita", True))
        Me.ID_nazionalitaComboBox.DataSource = Me.PaesiBindingSource
        Me.ID_nazionalitaComboBox.DisplayMember = "nome"
        Me.ID_nazionalitaComboBox.FormattingEnabled = True
        Me.ID_nazionalitaComboBox.Location = New System.Drawing.Point(17, 334)
        Me.ID_nazionalitaComboBox.Name = "ID_nazionalitaComboBox"
        Me.ID_nazionalitaComboBox.Size = New System.Drawing.Size(320, 21)
        Me.ID_nazionalitaComboBox.TabIndex = 18
        Me.ID_nazionalitaComboBox.ValueMember = "ID_paese"
        '
        'PaesiBindingSource
        '
        Me.PaesiBindingSource.DataMember = "paesi"
        Me.PaesiBindingSource.DataSource = Me.AliDBDataSet
        '
        'PaesiTableAdapter
        '
        Me.PaesiTableAdapter.ClearBeforeFill = True
        '
        'ID_comune_residenzaTextBox
        '
        Me.ID_comune_residenzaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_comune_residenza", True))
        Me.ID_comune_residenzaTextBox.Location = New System.Drawing.Point(19, 383)
        Me.ID_comune_residenzaTextBox.Name = "ID_comune_residenzaTextBox"
        Me.ID_comune_residenzaTextBox.Size = New System.Drawing.Size(320, 20)
        Me.ID_comune_residenzaTextBox.TabIndex = 19
        '
        'ID_dimoraComboBox
        '
        Me.ID_dimoraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_dimora", True))
        Me.ID_dimoraComboBox.DataSource = Me.DimoraBindingSource
        Me.ID_dimoraComboBox.DisplayMember = "descrizione"
        Me.ID_dimoraComboBox.FormattingEnabled = True
        Me.ID_dimoraComboBox.Location = New System.Drawing.Point(19, 433)
        Me.ID_dimoraComboBox.Name = "ID_dimoraComboBox"
        Me.ID_dimoraComboBox.Size = New System.Drawing.Size(320, 21)
        Me.ID_dimoraComboBox.TabIndex = 20
        Me.ID_dimoraComboBox.ValueMember = "ID_dimora"
        '
        'DimoraBindingSource
        '
        Me.DimoraBindingSource.DataMember = "dimora"
        Me.DimoraBindingSource.DataSource = Me.AliDBDataSet
        '
        'DimoraTableAdapter
        '
        Me.DimoraTableAdapter.ClearBeforeFill = True
        '
        'ID_tipo_alloggioComboBox
        '
        Me.ID_tipo_alloggioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_tipo_alloggio", True))
        Me.ID_tipo_alloggioComboBox.DataSource = Me.AlloggioBindingSource
        Me.ID_tipo_alloggioComboBox.DisplayMember = "descrizione"
        Me.ID_tipo_alloggioComboBox.FormattingEnabled = True
        Me.ID_tipo_alloggioComboBox.Location = New System.Drawing.Point(19, 484)
        Me.ID_tipo_alloggioComboBox.Name = "ID_tipo_alloggioComboBox"
        Me.ID_tipo_alloggioComboBox.Size = New System.Drawing.Size(320, 21)
        Me.ID_tipo_alloggioComboBox.TabIndex = 22
        Me.ID_tipo_alloggioComboBox.ValueMember = "ID_alloggio"
        '
        'AlloggioBindingSource
        '
        Me.AlloggioBindingSource.DataMember = "alloggio"
        Me.AlloggioBindingSource.DataSource = Me.AliDBDataSet
        '
        'AlloggioTableAdapter
        '
        Me.AlloggioTableAdapter.ClearBeforeFill = True
        '
        'ID_nucleo_familiareComboBox
        '
        Me.ID_nucleo_familiareComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_nucleo_familiare", True))
        Me.ID_nucleo_familiareComboBox.DataSource = Me.NucleofamiliareBindingSource
        Me.ID_nucleo_familiareComboBox.DisplayMember = "descrizione"
        Me.ID_nucleo_familiareComboBox.FormattingEnabled = True
        Me.ID_nucleo_familiareComboBox.Location = New System.Drawing.Point(19, 535)
        Me.ID_nucleo_familiareComboBox.Name = "ID_nucleo_familiareComboBox"
        Me.ID_nucleo_familiareComboBox.Size = New System.Drawing.Size(318, 21)
        Me.ID_nucleo_familiareComboBox.TabIndex = 24
        Me.ID_nucleo_familiareComboBox.ValueMember = "ID_nucleo_familiare"
        '
        'NucleofamiliareBindingSource
        '
        Me.NucleofamiliareBindingSource.DataMember = "nucleo_familiare"
        Me.NucleofamiliareBindingSource.DataSource = Me.AliDBDataSet
        '
        'Nucleo_familiareTableAdapter
        '
        Me.Nucleo_familiareTableAdapter.ClearBeforeFill = True
        '
        'Numero_conviventiTextBox
        '
        Me.Numero_conviventiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "numero_conviventi", True))
        Me.Numero_conviventiTextBox.Location = New System.Drawing.Point(358, 536)
        Me.Numero_conviventiTextBox.Name = "Numero_conviventiTextBox"
        Me.Numero_conviventiTextBox.Size = New System.Drawing.Size(56, 20)
        Me.Numero_conviventiTextBox.TabIndex = 26
        '
        'ID_partnerComboBox
        '
        Me.ID_partnerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_partner", True))
        Me.ID_partnerComboBox.FormattingEnabled = True
        Me.ID_partnerComboBox.Items.AddRange(New Object() {"SI", "NO"})
        Me.ID_partnerComboBox.Location = New System.Drawing.Point(19, 589)
        Me.ID_partnerComboBox.Name = "ID_partnerComboBox"
        Me.ID_partnerComboBox.Size = New System.Drawing.Size(59, 21)
        Me.ID_partnerComboBox.TabIndex = 28
        '
        'ID_figli_conviventiComboBox
        '
        Me.ID_figli_conviventiComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_figli_conviventi", True))
        Me.ID_figli_conviventiComboBox.FormattingEnabled = True
        Me.ID_figli_conviventiComboBox.Items.AddRange(New Object() {"SI", "NO"})
        Me.ID_figli_conviventiComboBox.Location = New System.Drawing.Point(167, 589)
        Me.ID_figli_conviventiComboBox.Name = "ID_figli_conviventiComboBox"
        Me.ID_figli_conviventiComboBox.Size = New System.Drawing.Size(55, 21)
        Me.ID_figli_conviventiComboBox.TabIndex = 30
        '
        'Lavoro_esteroTextBox
        '
        Me.Lavoro_esteroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "lavoro_estero", True))
        Me.Lavoro_esteroTextBox.Location = New System.Drawing.Point(523, 235)
        Me.Lavoro_esteroTextBox.Name = "Lavoro_esteroTextBox"
        Me.Lavoro_esteroTextBox.Size = New System.Drawing.Size(321, 20)
        Me.Lavoro_esteroTextBox.TabIndex = 32
        '
        'Lavoro_italiaTextBox
        '
        Me.Lavoro_italiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "lavoro_italia", True))
        Me.Lavoro_italiaTextBox.Location = New System.Drawing.Point(523, 288)
        Me.Lavoro_italiaTextBox.Name = "Lavoro_italiaTextBox"
        Me.Lavoro_italiaTextBox.Size = New System.Drawing.Size(321, 20)
        Me.Lavoro_italiaTextBox.TabIndex = 34
        '
        'ID_condizione_professionaleComboBox
        '
        Me.ID_condizione_professionaleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_condizione_professionale", True))
        Me.ID_condizione_professionaleComboBox.DataSource = Me.CondizioneprofessionaleBindingSource
        Me.ID_condizione_professionaleComboBox.DisplayMember = "descrizione"
        Me.ID_condizione_professionaleComboBox.FormattingEnabled = True
        Me.ID_condizione_professionaleComboBox.Location = New System.Drawing.Point(523, 190)
        Me.ID_condizione_professionaleComboBox.Name = "ID_condizione_professionaleComboBox"
        Me.ID_condizione_professionaleComboBox.Size = New System.Drawing.Size(320, 21)
        Me.ID_condizione_professionaleComboBox.TabIndex = 36
        Me.ID_condizione_professionaleComboBox.ValueMember = "ID_condizione_professionale"
        '
        'CondizioneprofessionaleBindingSource
        '
        Me.CondizioneprofessionaleBindingSource.DataMember = "condizione_professionale"
        Me.CondizioneprofessionaleBindingSource.DataSource = Me.AliDBDataSet
        '
        'Condizione_professionaleTableAdapter
        '
        Me.Condizione_professionaleTableAdapter.ClearBeforeFill = True
        '
        'ID_redditto_mensileComboBox
        '
        Me.ID_redditto_mensileComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_redditto_mensile", True))
        Me.ID_redditto_mensileComboBox.DataSource = Me.RedditoindividualeBindingSource
        Me.ID_redditto_mensileComboBox.DisplayMember = "descrizione"
        Me.ID_redditto_mensileComboBox.FormattingEnabled = True
        Me.ID_redditto_mensileComboBox.Location = New System.Drawing.Point(523, 334)
        Me.ID_redditto_mensileComboBox.Name = "ID_redditto_mensileComboBox"
        Me.ID_redditto_mensileComboBox.Size = New System.Drawing.Size(323, 21)
        Me.ID_redditto_mensileComboBox.TabIndex = 38
        Me.ID_redditto_mensileComboBox.ValueMember = "ID_reddito"
        '
        'RedditoindividualeBindingSource
        '
        Me.RedditoindividualeBindingSource.DataMember = "reddito_individuale"
        Me.RedditoindividualeBindingSource.DataSource = Me.AliDBDataSet
        '
        'Reddito_individualeTableAdapter
        '
        Me.Reddito_individualeTableAdapter.ClearBeforeFill = True
        '
        'ID_altro_reddittoLabel
        '
        ID_altro_reddittoLabel.AutoSize = True
        ID_altro_reddittoLabel.Location = New System.Drawing.Point(526, 367)
        ID_altro_reddittoLabel.Name = "ID_altro_reddittoLabel"
        ID_altro_reddittoLabel.Size = New System.Drawing.Size(61, 13)
        ID_altro_reddittoLabel.TabIndex = 39
        ID_altro_reddittoLabel.Text = "Altri redditti:"
        '
        'ID_altro_reddittoComboBox
        '
        Me.ID_altro_reddittoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_altro_redditto", True))
        Me.ID_altro_reddittoComboBox.DataSource = Me.AltriredditiBindingSource
        Me.ID_altro_reddittoComboBox.DisplayMember = "descrizione"
        Me.ID_altro_reddittoComboBox.FormattingEnabled = True
        Me.ID_altro_reddittoComboBox.Location = New System.Drawing.Point(523, 382)
        Me.ID_altro_reddittoComboBox.Name = "ID_altro_reddittoComboBox"
        Me.ID_altro_reddittoComboBox.Size = New System.Drawing.Size(323, 21)
        Me.ID_altro_reddittoComboBox.TabIndex = 40
        Me.ID_altro_reddittoComboBox.ValueMember = "descrizione"
        '
        'AliDBDataSetBindingSource
        '
        Me.AliDBDataSetBindingSource.DataSource = Me.AliDBDataSet
        Me.AliDBDataSetBindingSource.Position = 0
        '
        'AltriredditiBindingSource
        '
        Me.AltriredditiBindingSource.DataMember = "altri_redditi"
        Me.AltriredditiBindingSource.DataSource = Me.AliDBDataSet
        '
        'Altri_redditiTableAdapter
        '
        Me.Altri_redditiTableAdapter.ClearBeforeFill = True
        '
        'F_utente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 751)
        Me.Controls.Add(ID_altro_reddittoLabel)
        Me.Controls.Add(Me.ID_altro_reddittoComboBox)
        Me.Controls.Add(ID_redditto_mensileLabel)
        Me.Controls.Add(Me.ID_redditto_mensileComboBox)
        Me.Controls.Add(ID_condizione_professionaleLabel)
        Me.Controls.Add(Me.ID_condizione_professionaleComboBox)
        Me.Controls.Add(Lavoro_italiaLabel)
        Me.Controls.Add(Me.Lavoro_italiaTextBox)
        Me.Controls.Add(Lavoro_esteroLabel)
        Me.Controls.Add(Me.Lavoro_esteroTextBox)
        Me.Controls.Add(ID_figli_conviventiLabel)
        Me.Controls.Add(Me.ID_figli_conviventiComboBox)
        Me.Controls.Add(ID_partnerLabel)
        Me.Controls.Add(Me.ID_partnerComboBox)
        Me.Controls.Add(Numero_conviventiLabel)
        Me.Controls.Add(Me.Numero_conviventiTextBox)
        Me.Controls.Add(ID_nucleo_familiareLabel)
        Me.Controls.Add(Me.ID_nucleo_familiareComboBox)
        Me.Controls.Add(ID_tipo_alloggioLabel)
        Me.Controls.Add(Me.ID_tipo_alloggioComboBox)
        Me.Controls.Add(ID_dimoraLabel)
        Me.Controls.Add(Me.ID_dimoraComboBox)
        Me.Controls.Add(ID_comune_residenzaLabel)
        Me.Controls.Add(Me.ID_comune_residenzaTextBox)
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
        CType(Me.PaesiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DimoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlloggioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NucleofamiliareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CondizioneprofessionaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedditoindividualeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AliDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltriredditiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PaesiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaesiTableAdapter As Alimentis.AliDBDataSetTableAdapters.paesiTableAdapter
    Friend WithEvents ID_comune_residenzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_dimoraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DimoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DimoraTableAdapter As Alimentis.AliDBDataSetTableAdapters.dimoraTableAdapter
    Friend WithEvents ID_tipo_alloggioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AlloggioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlloggioTableAdapter As Alimentis.AliDBDataSetTableAdapters.alloggioTableAdapter
    Friend WithEvents ID_nucleo_familiareComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NucleofamiliareBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nucleo_familiareTableAdapter As Alimentis.AliDBDataSetTableAdapters.nucleo_familiareTableAdapter
    Friend WithEvents Numero_conviventiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_partnerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_figli_conviventiComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Lavoro_esteroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lavoro_italiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_condizione_professionaleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CondizioneprofessionaleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Condizione_professionaleTableAdapter As Alimentis.AliDBDataSetTableAdapters.condizione_professionaleTableAdapter
    Friend WithEvents ID_redditto_mensileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RedditoindividualeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reddito_individualeTableAdapter As Alimentis.AliDBDataSetTableAdapters.reddito_individualeTableAdapter
    Friend WithEvents ID_altro_reddittoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AliDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AltriredditiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Altri_redditiTableAdapter As Alimentis.AliDBDataSetTableAdapters.altri_redditiTableAdapter
End Class
