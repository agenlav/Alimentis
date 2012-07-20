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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_utente))
        Dim ID_centroLabel As System.Windows.Forms.Label
        Me.AliDBDataSet = New Alimentis.AliDBDataSet()
        Me.UtentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtentiTableAdapter = New Alimentis.AliDBDataSetTableAdapters.utentiTableAdapter()
        Me.TableAdapterManager = New Alimentis.AliDBDataSetTableAdapters.TableAdapterManager()
        Me.UtentiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.UtentiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_centroTextBox = New System.Windows.Forms.TextBox()
        ID_centroLabel = New System.Windows.Forms.Label()
        CType(Me.AliDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtentiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtentiBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        Me.UtentiBindingNavigator.Size = New System.Drawing.Size(311, 25)
        Me.UtentiBindingNavigator.TabIndex = 0
        Me.UtentiBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 15)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'UtentiBindingNavigatorSaveItem
        '
        Me.UtentiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UtentiBindingNavigatorSaveItem.Image = CType(resources.GetObject("UtentiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UtentiBindingNavigatorSaveItem.Name = "UtentiBindingNavigatorSaveItem"
        Me.UtentiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.UtentiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'ID_centroLabel
        '
        ID_centroLabel.AutoSize = True
        ID_centroLabel.Location = New System.Drawing.Point(131, 58)
        ID_centroLabel.Name = "ID_centroLabel"
        ID_centroLabel.Size = New System.Drawing.Size(54, 13)
        ID_centroLabel.TabIndex = 1
        ID_centroLabel.Text = "ID centro:"
        '
        'ID_centroTextBox
        '
        Me.ID_centroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtentiBindingSource, "ID_centro", True))
        Me.ID_centroTextBox.Location = New System.Drawing.Point(191, 55)
        Me.ID_centroTextBox.Name = "ID_centroTextBox"
        Me.ID_centroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_centroTextBox.TabIndex = 2
        '
        'F_utente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 262)
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
End Class
