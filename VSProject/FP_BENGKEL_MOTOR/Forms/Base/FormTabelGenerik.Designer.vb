<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTabelGenerik
    Inherits FormGenerik

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim navigatorTabelDb As System.Windows.Forms.BindingNavigator
        Dim BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
        Dim BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTabelGenerik))
        Dim BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
        Dim BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
        Dim BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
        Dim BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
        Dim BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
        Dim BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
        Dim FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
        Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Dim Label1 As System.Windows.Forms.Label
        Dim FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
        Dim Label2 As System.Windows.Forms.Label
        Dim FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
        Dim Label3 As System.Windows.Forms.Label
        Dim FlowLayoutPanel8 As System.Windows.Forms.FlowLayoutPanel
        Dim Label4 As System.Windows.Forms.Label
        Dim FlowLayoutPanel9 As System.Windows.Forms.FlowLayoutPanel
        Dim Label5 As System.Windows.Forms.Label
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim ToolStrip1 As System.Windows.Forms.ToolStrip
        Dim navTabelFilterProcess As System.Windows.Forms.ToolStripButton
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim navTabelFilterClear As System.Windows.Forms.ToolStripButton
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
        Dim GroupBox3 As System.Windows.Forms.GroupBox
        Dim GroupBox2 As System.Windows.Forms.GroupBox
        Dim FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
        Me.sourceTabel = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetBengkel = New FP_BENGKEL_MOTOR.DataSetBengkel()
        Me.tbPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.btnEditItem = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchFilterAdd = New System.Windows.Forms.Button()
        Me.btnSearchFilterSubtract = New System.Windows.Forms.Button()
        Me.btnSearchFilterMulti = New System.Windows.Forms.Button()
        Me.btnSearchFilterDiv = New System.Windows.Forms.Button()
        Me.btnSearchFilterMod = New System.Windows.Forms.Button()
        Me.btnSearchFilterLess = New System.Windows.Forms.Button()
        Me.btnSearchFilterLessEqual = New System.Windows.Forms.Button()
        Me.btnSearchFilterEqual = New System.Windows.Forms.Button()
        Me.btnSearchFilterParent = New System.Windows.Forms.Button()
        Me.btnSearchFilterMore = New System.Windows.Forms.Button()
        Me.btnSearchFilterMoreEqual = New System.Windows.Forms.Button()
        Me.btnSearchFilterNotEqual = New System.Windows.Forms.Button()
        Me.btnSearchFilterChild = New System.Windows.Forms.Button()
        Me.btnSearchFilterOrKurungBuka = New System.Windows.Forms.Button()
        Me.btnSearchFilterAnd = New System.Windows.Forms.Button()
        Me.btnSearchFilterTrue = New System.Windows.Forms.Button()
        Me.btnSearchFilterIsNull = New System.Windows.Forms.Button()
        Me.btnSearchFilterIn = New System.Windows.Forms.Button()
        Me.btnSearchFilterLike = New System.Windows.Forms.Button()
        Me.btnSearchFilterKurungTutup = New System.Windows.Forms.Button()
        Me.btnSearchFilterOr = New System.Windows.Forms.Button()
        Me.btnSearchFilterFalse = New System.Windows.Forms.Button()
        Me.btnSearchFilterIsNotNull = New System.Windows.Forms.Button()
        Me.btnSearchFilterBetween = New System.Windows.Forms.Button()
        Me.rtbSearchRumusFilter = New System.Windows.Forms.RichTextBox()
        Me.navTabelFilterPosisi = New System.Windows.Forms.ToolStripLabel()
        Me.lbSearchDaftarKolom = New System.Windows.Forms.ListBox()
        Me.btnRefillTable = New System.Windows.Forms.Button()
        Me.viewTabelDb = New System.Windows.Forms.DataGridView()
        Me.scGenerik = New System.Windows.Forms.SplitContainer()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.ckbTampilContainerData = New System.Windows.Forms.CheckBox()
        Me.tabletTabel = New System.Windows.Forms.TabControl()
        Me.tab1Search = New System.Windows.Forms.TabPage()
        Me.scSearch = New System.Windows.Forms.SplitContainer()
        Me.tab2Manipulasi = New System.Windows.Forms.TabPage()
        Me.scManipulasi = New System.Windows.Forms.SplitContainer()
        Me.toolStripManipulasiData = New FP_BENGKEL_MOTOR.InheritedToolStrip()
        Me.inputBtnSwitchToInsert = New System.Windows.Forms.ToolStripButton()
        Me.inputGB = New System.Windows.Forms.GroupBox()
        Me.TBLTombolSubmit = New System.Windows.Forms.TableLayoutPanel()
        Me.inputBtnSubmit = New System.Windows.Forms.Button()
        Me.footerStatusBar = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bgTabelFill = New System.ComponentModel.BackgroundWorker()
        navigatorTabelDb = New System.Windows.Forms.BindingNavigator(Me.components)
        BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Label1 = New System.Windows.Forms.Label()
        FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Label2 = New System.Windows.Forms.Label()
        FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Label3 = New System.Windows.Forms.Label()
        FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Label4 = New System.Windows.Forms.Label()
        FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Label5 = New System.Windows.Forms.Label()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        ToolStrip1 = New System.Windows.Forms.ToolStrip()
        navTabelFilterProcess = New System.Windows.Forms.ToolStripButton()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        navTabelFilterClear = New System.Windows.Forms.ToolStripButton()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        GroupBox3 = New System.Windows.Forms.GroupBox()
        GroupBox2 = New System.Windows.Forms.GroupBox()
        FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        CType(navigatorTabelDb, System.ComponentModel.ISupportInitialize).BeginInit()
        navigatorTabelDb.SuspendLayout()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel8.SuspendLayout()
        FlowLayoutPanel9.SuspendLayout()
        GroupBox1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        FlowLayoutPanel5.SuspendLayout()
        CType(Me.viewTabelDb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scGenerik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scGenerik.Panel1.SuspendLayout()
        Me.scGenerik.Panel2.SuspendLayout()
        Me.scGenerik.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.tabletTabel.SuspendLayout()
        Me.tab1Search.SuspendLayout()
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scSearch.Panel1.SuspendLayout()
        Me.scSearch.Panel2.SuspendLayout()
        Me.scSearch.SuspendLayout()
        Me.tab2Manipulasi.SuspendLayout()
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scManipulasi.Panel1.SuspendLayout()
        Me.scManipulasi.Panel2.SuspendLayout()
        Me.scManipulasi.SuspendLayout()
        Me.toolStripManipulasiData.SuspendLayout()
        Me.inputGB.SuspendLayout()
        Me.TBLTombolSubmit.SuspendLayout()
        Me.footerStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'navigatorTabelDb
        '
        navigatorTabelDb.AddNewItem = Nothing
        navigatorTabelDb.BindingSource = Me.sourceTabel
        navigatorTabelDb.CountItem = BindingNavigatorCountItem
        navigatorTabelDb.CountItemFormat = "dari {0} baris"
        navigatorTabelDb.DeleteItem = Nothing
        navigatorTabelDb.Dock = System.Windows.Forms.DockStyle.Bottom
        navigatorTabelDb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {BindingNavigatorMoveFirstItem, BindingNavigatorMovePreviousItem, BindingNavigatorSeparator, Me.tbPositionItem, BindingNavigatorCountItem, BindingNavigatorSeparator1, BindingNavigatorMoveNextItem, BindingNavigatorMoveLastItem, BindingNavigatorSeparator2, BindingNavigatorAddNewItem, Me.btnEditItem, Me.btnDeleteItem})
        navigatorTabelDb.Location = New System.Drawing.Point(0, 122)
        navigatorTabelDb.MoveFirstItem = BindingNavigatorMoveFirstItem
        navigatorTabelDb.MoveLastItem = BindingNavigatorMoveLastItem
        navigatorTabelDb.MoveNextItem = BindingNavigatorMoveNextItem
        navigatorTabelDb.MovePreviousItem = BindingNavigatorMovePreviousItem
        navigatorTabelDb.Name = "navigatorTabelDb"
        navigatorTabelDb.PositionItem = Me.tbPositionItem
        navigatorTabelDb.Size = New System.Drawing.Size(580, 25)
        navigatorTabelDb.TabIndex = 3
        '
        'sourceTabel
        '
        Me.sourceTabel.AllowNew = False
        Me.sourceTabel.DataSource = Me.DataSetBengkel
        Me.sourceTabel.Position = 0
        '
        'DataSetBengkel
        '
        Me.DataSetBengkel.DataSetName = "DataSetBengkel"
        Me.DataSetBengkel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        BindingNavigatorCountItem.Size = New System.Drawing.Size(72, 22)
        BindingNavigatorCountItem.Text = "dari {0} baris"
        BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'tbPositionItem
        '
        Me.tbPositionItem.AccessibleName = "Position"
        Me.tbPositionItem.AutoSize = False
        Me.tbPositionItem.Name = "tbPositionItem"
        Me.tbPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.tbPositionItem.Text = "1"
        Me.tbPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        BindingNavigatorAddNewItem.Text = "Add new"
        AddHandler BindingNavigatorAddNewItem.Click, AddressOf Me.BindingNavigatorAddNewItem_Click
        '
        'btnEditItem
        '
        Me.btnEditItem.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_edit
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.RightToLeftAutoMirrorImage = True
        Me.btnEditItem.Size = New System.Drawing.Size(47, 22)
        Me.btnEditItem.Text = "Edit"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Image = CType(resources.GetObject("btnDeleteItem.Image"), System.Drawing.Image)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.RightToLeftAutoMirrorImage = True
        Me.btnDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.btnDeleteItem.Text = "Delete"
        '
        'FlowLayoutPanel2
        '
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel1)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel3)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel4)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel8)
        FlowLayoutPanel2.Controls.Add(FlowLayoutPanel9)
        FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        FlowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New System.Drawing.Size(294, 271)
        FlowLayoutPanel2.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Controls.Add(Me.btnSearchFilterAdd)
        FlowLayoutPanel1.Controls.Add(Me.btnSearchFilterSubtract)
        FlowLayoutPanel1.Controls.Add(Me.btnSearchFilterMulti)
        FlowLayoutPanel1.Controls.Add(Me.btnSearchFilterDiv)
        FlowLayoutPanel1.Controls.Add(Me.btnSearchFilterMod)
        FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New System.Drawing.Size(59, 193)
        FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 13)
        Label1.TabIndex = 8
        Label1.Text = "Aritmatika"
        '
        'btnSearchFilterAdd
        '
        Me.btnSearchFilterAdd.Location = New System.Drawing.Point(3, 16)
        Me.btnSearchFilterAdd.Name = "btnSearchFilterAdd"
        Me.btnSearchFilterAdd.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterAdd.TabIndex = 0
        Me.btnSearchFilterAdd.Text = "+"
        Me.btnSearchFilterAdd.UseVisualStyleBackColor = True
        '
        'btnSearchFilterSubtract
        '
        Me.btnSearchFilterSubtract.Location = New System.Drawing.Point(3, 52)
        Me.btnSearchFilterSubtract.Name = "btnSearchFilterSubtract"
        Me.btnSearchFilterSubtract.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterSubtract.TabIndex = 1
        Me.btnSearchFilterSubtract.Text = "-"
        Me.btnSearchFilterSubtract.UseVisualStyleBackColor = True
        '
        'btnSearchFilterMulti
        '
        Me.btnSearchFilterMulti.Location = New System.Drawing.Point(3, 88)
        Me.btnSearchFilterMulti.Name = "btnSearchFilterMulti"
        Me.btnSearchFilterMulti.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterMulti.TabIndex = 2
        Me.btnSearchFilterMulti.Text = "*"
        Me.btnSearchFilterMulti.UseVisualStyleBackColor = True
        '
        'btnSearchFilterDiv
        '
        Me.btnSearchFilterDiv.Location = New System.Drawing.Point(3, 124)
        Me.btnSearchFilterDiv.Name = "btnSearchFilterDiv"
        Me.btnSearchFilterDiv.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterDiv.TabIndex = 3
        Me.btnSearchFilterDiv.Text = "/"
        Me.btnSearchFilterDiv.UseVisualStyleBackColor = True
        '
        'btnSearchFilterMod
        '
        Me.btnSearchFilterMod.Location = New System.Drawing.Point(3, 160)
        Me.btnSearchFilterMod.Name = "btnSearchFilterMod"
        Me.btnSearchFilterMod.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterMod.TabIndex = 4
        Me.btnSearchFilterMod.Text = "%"
        Me.btnSearchFilterMod.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        FlowLayoutPanel3.AutoSize = True
        FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        FlowLayoutPanel3.Controls.Add(Label2)
        FlowLayoutPanel3.Controls.Add(Me.btnSearchFilterLess)
        FlowLayoutPanel3.Controls.Add(Me.btnSearchFilterLessEqual)
        FlowLayoutPanel3.Controls.Add(Me.btnSearchFilterEqual)
        FlowLayoutPanel3.Controls.Add(Me.btnSearchFilterParent)
        FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        FlowLayoutPanel3.Location = New System.Drawing.Point(68, 3)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New System.Drawing.Size(47, 167)
        FlowLayoutPanel3.TabIndex = 1
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(41, 13)
        Label2.TabIndex = 9
        Label2.Text = "Perban"
        '
        'btnSearchFilterLess
        '
        Me.btnSearchFilterLess.Location = New System.Drawing.Point(3, 16)
        Me.btnSearchFilterLess.Name = "btnSearchFilterLess"
        Me.btnSearchFilterLess.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterLess.TabIndex = 0
        Me.btnSearchFilterLess.Text = "<"
        Me.btnSearchFilterLess.UseVisualStyleBackColor = True
        '
        'btnSearchFilterLessEqual
        '
        Me.btnSearchFilterLessEqual.Location = New System.Drawing.Point(3, 52)
        Me.btnSearchFilterLessEqual.Name = "btnSearchFilterLessEqual"
        Me.btnSearchFilterLessEqual.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterLessEqual.TabIndex = 1
        Me.btnSearchFilterLessEqual.Text = "<="
        Me.btnSearchFilterLessEqual.UseVisualStyleBackColor = True
        '
        'btnSearchFilterEqual
        '
        Me.btnSearchFilterEqual.Location = New System.Drawing.Point(3, 88)
        Me.btnSearchFilterEqual.Name = "btnSearchFilterEqual"
        Me.btnSearchFilterEqual.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterEqual.TabIndex = 2
        Me.btnSearchFilterEqual.Text = "="
        Me.btnSearchFilterEqual.UseVisualStyleBackColor = True
        '
        'btnSearchFilterParent
        '
        Me.btnSearchFilterParent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFilterParent.Location = New System.Drawing.Point(3, 124)
        Me.btnSearchFilterParent.Name = "btnSearchFilterParent"
        Me.btnSearchFilterParent.Size = New System.Drawing.Size(40, 40)
        Me.btnSearchFilterParent.TabIndex = 3
        Me.btnSearchFilterParent.Text = "PARENT"
        Me.btnSearchFilterParent.UseVisualStyleBackColor = True
        Me.btnSearchFilterParent.Visible = False
        '
        'FlowLayoutPanel4
        '
        FlowLayoutPanel4.AutoSize = True
        FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        FlowLayoutPanel4.Controls.Add(Label3)
        FlowLayoutPanel4.Controls.Add(Me.btnSearchFilterMore)
        FlowLayoutPanel4.Controls.Add(Me.btnSearchFilterMoreEqual)
        FlowLayoutPanel4.Controls.Add(Me.btnSearchFilterNotEqual)
        FlowLayoutPanel4.Controls.Add(Me.btnSearchFilterChild)
        FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        FlowLayoutPanel4.Location = New System.Drawing.Point(121, 3)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New System.Drawing.Size(46, 167)
        FlowLayoutPanel4.TabIndex = 2
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(39, 13)
        Label3.TabIndex = 10
        Label3.Text = "dingan"
        '
        'btnSearchFilterMore
        '
        Me.btnSearchFilterMore.Location = New System.Drawing.Point(3, 16)
        Me.btnSearchFilterMore.Name = "btnSearchFilterMore"
        Me.btnSearchFilterMore.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterMore.TabIndex = 0
        Me.btnSearchFilterMore.Text = ">"
        Me.btnSearchFilterMore.UseVisualStyleBackColor = True
        '
        'btnSearchFilterMoreEqual
        '
        Me.btnSearchFilterMoreEqual.Location = New System.Drawing.Point(3, 52)
        Me.btnSearchFilterMoreEqual.Name = "btnSearchFilterMoreEqual"
        Me.btnSearchFilterMoreEqual.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterMoreEqual.TabIndex = 1
        Me.btnSearchFilterMoreEqual.Text = ">="
        Me.btnSearchFilterMoreEqual.UseVisualStyleBackColor = True
        '
        'btnSearchFilterNotEqual
        '
        Me.btnSearchFilterNotEqual.Location = New System.Drawing.Point(3, 88)
        Me.btnSearchFilterNotEqual.Name = "btnSearchFilterNotEqual"
        Me.btnSearchFilterNotEqual.Size = New System.Drawing.Size(40, 30)
        Me.btnSearchFilterNotEqual.TabIndex = 2
        Me.btnSearchFilterNotEqual.Text = "<>"
        Me.btnSearchFilterNotEqual.UseVisualStyleBackColor = True
        '
        'btnSearchFilterChild
        '
        Me.btnSearchFilterChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchFilterChild.Location = New System.Drawing.Point(3, 124)
        Me.btnSearchFilterChild.Name = "btnSearchFilterChild"
        Me.btnSearchFilterChild.Size = New System.Drawing.Size(40, 40)
        Me.btnSearchFilterChild.TabIndex = 3
        Me.btnSearchFilterChild.Text = "CHILD"
        Me.btnSearchFilterChild.UseVisualStyleBackColor = True
        Me.btnSearchFilterChild.Visible = False
        '
        'FlowLayoutPanel8
        '
        FlowLayoutPanel8.AutoSize = True
        FlowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        FlowLayoutPanel8.Controls.Add(Label4)
        FlowLayoutPanel8.Controls.Add(Me.btnSearchFilterOrKurungBuka)
        FlowLayoutPanel8.Controls.Add(Me.btnSearchFilterAnd)
        FlowLayoutPanel8.Controls.Add(Me.btnSearchFilterTrue)
        FlowLayoutPanel8.Controls.Add(Me.btnSearchFilterIsNull)
        FlowLayoutPanel8.Controls.Add(Me.btnSearchFilterIn)
        FlowLayoutPanel8.Controls.Add(Me.btnSearchFilterLike)
        FlowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        FlowLayoutPanel8.Location = New System.Drawing.Point(173, 3)
        FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        FlowLayoutPanel8.Size = New System.Drawing.Size(56, 253)
        FlowLayoutPanel8.TabIndex = 3
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(3, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(39, 13)
        Label4.TabIndex = 11
        Label4.Text = "Logika"
        '
        'btnSearchFilterOrKurungBuka
        '
        Me.btnSearchFilterOrKurungBuka.Location = New System.Drawing.Point(3, 16)
        Me.btnSearchFilterOrKurungBuka.Name = "btnSearchFilterOrKurungBuka"
        Me.btnSearchFilterOrKurungBuka.Size = New System.Drawing.Size(50, 30)
        Me.btnSearchFilterOrKurungBuka.TabIndex = 0
        Me.btnSearchFilterOrKurungBuka.Text = "("
        Me.btnSearchFilterOrKurungBuka.UseVisualStyleBackColor = True
        '
        'btnSearchFilterAnd
        '
        Me.btnSearchFilterAnd.Location = New System.Drawing.Point(3, 52)
        Me.btnSearchFilterAnd.Name = "btnSearchFilterAnd"
        Me.btnSearchFilterAnd.Size = New System.Drawing.Size(50, 30)
        Me.btnSearchFilterAnd.TabIndex = 1
        Me.btnSearchFilterAnd.Text = "AND"
        Me.btnSearchFilterAnd.UseVisualStyleBackColor = True
        '
        'btnSearchFilterTrue
        '
        Me.btnSearchFilterTrue.Location = New System.Drawing.Point(3, 88)
        Me.btnSearchFilterTrue.Name = "btnSearchFilterTrue"
        Me.btnSearchFilterTrue.Size = New System.Drawing.Size(50, 30)
        Me.btnSearchFilterTrue.TabIndex = 2
        Me.btnSearchFilterTrue.Text = "TRUE"
        Me.btnSearchFilterTrue.UseVisualStyleBackColor = True
        '
        'btnSearchFilterIsNull
        '
        Me.btnSearchFilterIsNull.Location = New System.Drawing.Point(3, 124)
        Me.btnSearchFilterIsNull.Name = "btnSearchFilterIsNull"
        Me.btnSearchFilterIsNull.Size = New System.Drawing.Size(50, 50)
        Me.btnSearchFilterIsNull.TabIndex = 3
        Me.btnSearchFilterIsNull.Text = "IS NULL"
        Me.btnSearchFilterIsNull.UseVisualStyleBackColor = True
        '
        'btnSearchFilterIn
        '
        Me.btnSearchFilterIn.Location = New System.Drawing.Point(3, 180)
        Me.btnSearchFilterIn.Name = "btnSearchFilterIn"
        Me.btnSearchFilterIn.Size = New System.Drawing.Size(50, 34)
        Me.btnSearchFilterIn.TabIndex = 4
        Me.btnSearchFilterIn.Text = "IN"
        Me.btnSearchFilterIn.UseVisualStyleBackColor = True
        '
        'btnSearchFilterLike
        '
        Me.btnSearchFilterLike.Location = New System.Drawing.Point(3, 220)
        Me.btnSearchFilterLike.Name = "btnSearchFilterLike"
        Me.btnSearchFilterLike.Size = New System.Drawing.Size(50, 30)
        Me.btnSearchFilterLike.TabIndex = 5
        Me.btnSearchFilterLike.Text = "LIKE"
        Me.btnSearchFilterLike.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel9
        '
        FlowLayoutPanel9.AutoSize = True
        FlowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        FlowLayoutPanel9.Controls.Add(Label5)
        FlowLayoutPanel9.Controls.Add(Me.btnSearchFilterKurungTutup)
        FlowLayoutPanel9.Controls.Add(Me.btnSearchFilterOr)
        FlowLayoutPanel9.Controls.Add(Me.btnSearchFilterFalse)
        FlowLayoutPanel9.Controls.Add(Me.btnSearchFilterIsNotNull)
        FlowLayoutPanel9.Controls.Add(Me.btnSearchFilterBetween)
        FlowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        FlowLayoutPanel9.Location = New System.Drawing.Point(235, 3)
        FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        FlowLayoutPanel9.Size = New System.Drawing.Size(56, 217)
        FlowLayoutPanel9.TabIndex = 4
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(0, 13)
        Label5.TabIndex = 11
        '
        'btnSearchFilterKurungTutup
        '
        Me.btnSearchFilterKurungTutup.Location = New System.Drawing.Point(3, 16)
        Me.btnSearchFilterKurungTutup.Name = "btnSearchFilterKurungTutup"
        Me.btnSearchFilterKurungTutup.Size = New System.Drawing.Size(50, 30)
        Me.btnSearchFilterKurungTutup.TabIndex = 0
        Me.btnSearchFilterKurungTutup.Text = ")"
        Me.btnSearchFilterKurungTutup.UseVisualStyleBackColor = True
        '
        'btnSearchFilterOr
        '
        Me.btnSearchFilterOr.Location = New System.Drawing.Point(3, 52)
        Me.btnSearchFilterOr.Name = "btnSearchFilterOr"
        Me.btnSearchFilterOr.Size = New System.Drawing.Size(50, 30)
        Me.btnSearchFilterOr.TabIndex = 1
        Me.btnSearchFilterOr.Text = "OR"
        Me.btnSearchFilterOr.UseVisualStyleBackColor = True
        '
        'btnSearchFilterFalse
        '
        Me.btnSearchFilterFalse.Location = New System.Drawing.Point(3, 88)
        Me.btnSearchFilterFalse.Name = "btnSearchFilterFalse"
        Me.btnSearchFilterFalse.Size = New System.Drawing.Size(50, 30)
        Me.btnSearchFilterFalse.TabIndex = 2
        Me.btnSearchFilterFalse.Text = "FALSE"
        Me.btnSearchFilterFalse.UseVisualStyleBackColor = True
        '
        'btnSearchFilterIsNotNull
        '
        Me.btnSearchFilterIsNotNull.Location = New System.Drawing.Point(3, 124)
        Me.btnSearchFilterIsNotNull.Name = "btnSearchFilterIsNotNull"
        Me.btnSearchFilterIsNotNull.Size = New System.Drawing.Size(50, 50)
        Me.btnSearchFilterIsNotNull.TabIndex = 3
        Me.btnSearchFilterIsNotNull.Text = "IS NOT NULL"
        Me.btnSearchFilterIsNotNull.UseVisualStyleBackColor = True
        '
        'btnSearchFilterBetween
        '
        Me.btnSearchFilterBetween.Location = New System.Drawing.Point(3, 180)
        Me.btnSearchFilterBetween.Name = "btnSearchFilterBetween"
        Me.btnSearchFilterBetween.Size = New System.Drawing.Size(50, 34)
        Me.btnSearchFilterBetween.TabIndex = 4
        Me.btnSearchFilterBetween.Text = "NOT IN"
        Me.btnSearchFilterBetween.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Me.rtbSearchRumusFilter)
        GroupBox1.Controls.Add(ToolStrip1)
        GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        GroupBox1.Location = New System.Drawing.Point(0, 0)
        GroupBox1.MinimumSize = New System.Drawing.Size(242, 177)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(242, 177)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Rumus Filter"
        '
        'rtbSearchRumusFilter
        '
        Me.rtbSearchRumusFilter.AutoWordSelection = True
        Me.rtbSearchRumusFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSearchRumusFilter.HideSelection = False
        Me.rtbSearchRumusFilter.Location = New System.Drawing.Point(3, 16)
        Me.rtbSearchRumusFilter.MinimumSize = New System.Drawing.Size(236, 133)
        Me.rtbSearchRumusFilter.Name = "rtbSearchRumusFilter"
        Me.rtbSearchRumusFilter.Size = New System.Drawing.Size(236, 133)
        Me.rtbSearchRumusFilter.TabIndex = 0
        Me.rtbSearchRumusFilter.Text = ""
        '
        'ToolStrip1
        '
        ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {navTabelFilterProcess, ToolStripSeparator1, navTabelFilterClear, ToolStripSeparator2, ToolStripLabel1, Me.navTabelFilterPosisi})
        ToolStrip1.Location = New System.Drawing.Point(3, 149)
        ToolStrip1.MinimumSize = New System.Drawing.Size(236, 25)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New System.Drawing.Size(236, 25)
        ToolStrip1.TabIndex = 3
        '
        'navTabelFilterProcess
        '
        navTabelFilterProcess.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_roundabout
        navTabelFilterProcess.ImageTransparentColor = System.Drawing.Color.Magenta
        navTabelFilterProcess.Name = "navTabelFilterProcess"
        navTabelFilterProcess.Size = New System.Drawing.Size(67, 22)
        navTabelFilterProcess.Text = "Process"
        AddHandler navTabelFilterProcess.Click, AddressOf Me.EventButtonClick_ProcessFilter
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'navTabelFilterClear
        '
        navTabelFilterClear.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_erase
        navTabelFilterClear.ImageTransparentColor = System.Drawing.Color.Magenta
        navTabelFilterClear.Name = "navTabelFilterClear"
        navTabelFilterClear.Size = New System.Drawing.Size(83, 22)
        navTabelFilterClear.Text = "Clear Filter"
        AddHandler navTabelFilterClear.Click, AddressOf Me.EventButtonClick_ClearFilter
        '
        'ToolStripSeparator2
        '
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New System.Drawing.Size(29, 22)
        ToolStripLabel1.Text = "Pos."
        '
        'navTabelFilterPosisi
        '
        Me.navTabelFilterPosisi.Name = "navTabelFilterPosisi"
        Me.navTabelFilterPosisi.Size = New System.Drawing.Size(13, 22)
        Me.navTabelFilterPosisi.Text = "0"
        '
        'GroupBox3
        '
        GroupBox3.Controls.Add(Me.lbSearchDaftarKolom)
        GroupBox3.Location = New System.Drawing.Point(3, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New System.Drawing.Size(300, 100)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Daftar Kolom"
        '
        'lbSearchDaftarKolom
        '
        Me.lbSearchDaftarKolom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSearchDaftarKolom.HorizontalScrollbar = True
        Me.lbSearchDaftarKolom.Location = New System.Drawing.Point(3, 16)
        Me.lbSearchDaftarKolom.Name = "lbSearchDaftarKolom"
        Me.lbSearchDaftarKolom.Size = New System.Drawing.Size(294, 81)
        Me.lbSearchDaftarKolom.TabIndex = 0
        '
        'GroupBox2
        '
        GroupBox2.Controls.Add(FlowLayoutPanel2)
        GroupBox2.Location = New System.Drawing.Point(3, 109)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New System.Drawing.Size(300, 290)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Operator"
        '
        'FlowLayoutPanel5
        '
        FlowLayoutPanel5.AutoScroll = True
        FlowLayoutPanel5.Controls.Add(GroupBox3)
        FlowLayoutPanel5.Controls.Add(GroupBox2)
        FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        FlowLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        FlowLayoutPanel5.Size = New System.Drawing.Size(323, 173)
        FlowLayoutPanel5.TabIndex = 1
        '
        'btnRefillTable
        '
        Me.btnRefillTable.Location = New System.Drawing.Point(140, 3)
        Me.btnRefillTable.Name = "btnRefillTable"
        Me.btnRefillTable.Size = New System.Drawing.Size(75, 20)
        Me.btnRefillTable.TabIndex = 1
        Me.btnRefillTable.Text = "Refill Table"
        Me.btnRefillTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefillTable.UseVisualStyleBackColor = True
        '
        'viewTabelDb
        '
        Me.viewTabelDb.AllowUserToAddRows = False
        Me.viewTabelDb.AllowUserToDeleteRows = False
        Me.viewTabelDb.AllowUserToResizeRows = False
        Me.viewTabelDb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewTabelDb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.viewTabelDb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.viewTabelDb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewTabelDb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.viewTabelDb.Location = New System.Drawing.Point(0, 26)
        Me.viewTabelDb.Name = "viewTabelDb"
        Me.viewTabelDb.ReadOnly = True
        Me.viewTabelDb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.viewTabelDb.RowTemplate.ErrorText = "#ERROR"
        Me.viewTabelDb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewTabelDb.ShowEditingIcon = False
        Me.viewTabelDb.ShowRowErrors = False
        Me.viewTabelDb.Size = New System.Drawing.Size(580, 96)
        Me.viewTabelDb.TabIndex = 2
        Me.viewTabelDb.VirtualMode = True
        '
        'scGenerik
        '
        Me.scGenerik.BackColor = System.Drawing.Color.Gold
        Me.scGenerik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scGenerik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scGenerik.Location = New System.Drawing.Point(0, 25)
        Me.scGenerik.Name = "scGenerik"
        Me.scGenerik.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scGenerik.Panel1
        '
        Me.scGenerik.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.scGenerik.Panel1.Controls.Add(Me.viewTabelDb)
        Me.scGenerik.Panel1.Controls.Add(navigatorTabelDb)
        Me.scGenerik.Panel1.Controls.Add(Me.panelTop)
        '
        'scGenerik.Panel2
        '
        Me.scGenerik.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.scGenerik.Panel2.Controls.Add(Me.tabletTabel)
        Me.scGenerik.Size = New System.Drawing.Size(584, 364)
        Me.scGenerik.SplitterDistance = 151
        Me.scGenerik.TabIndex = 3
        Me.scGenerik.TabStop = False
        '
        'panelTop
        '
        Me.panelTop.AutoScroll = True
        Me.panelTop.AutoSize = True
        Me.panelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelTop.Controls.Add(Me.btnRefillTable)
        Me.panelTop.Controls.Add(Me.ckbTampilContainerData)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Padding = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.panelTop.Size = New System.Drawing.Size(580, 26)
        Me.panelTop.TabIndex = 0
        '
        'ckbTampilContainerData
        '
        Me.ckbTampilContainerData.AutoSize = True
        Me.ckbTampilContainerData.Checked = True
        Me.ckbTampilContainerData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbTampilContainerData.Location = New System.Drawing.Point(3, 3)
        Me.ckbTampilContainerData.Name = "ckbTampilContainerData"
        Me.ckbTampilContainerData.Size = New System.Drawing.Size(131, 17)
        Me.ckbTampilContainerData.TabIndex = 0
        Me.ckbTampilContainerData.Text = "Tampilkan Data Editor"
        Me.ckbTampilContainerData.UseVisualStyleBackColor = True
        '
        'tabletTabel
        '
        Me.tabletTabel.Controls.Add(Me.tab1Search)
        Me.tabletTabel.Controls.Add(Me.tab2Manipulasi)
        Me.tabletTabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabletTabel.Location = New System.Drawing.Point(0, 0)
        Me.tabletTabel.Name = "tabletTabel"
        Me.tabletTabel.SelectedIndex = 0
        Me.tabletTabel.Size = New System.Drawing.Size(580, 205)
        Me.tabletTabel.TabIndex = 1
        '
        'tab1Search
        '
        Me.tab1Search.AutoScroll = True
        Me.tab1Search.Controls.Add(Me.scSearch)
        Me.tab1Search.Location = New System.Drawing.Point(4, 22)
        Me.tab1Search.Name = "tab1Search"
        Me.tab1Search.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1Search.Size = New System.Drawing.Size(572, 179)
        Me.tab1Search.TabIndex = 0
        Me.tab1Search.Text = "Filterisasi Data"
        Me.tab1Search.UseVisualStyleBackColor = True
        '
        'scSearch
        '
        Me.scSearch.BackColor = System.Drawing.Color.Gold
        Me.scSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scSearch.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scSearch.Location = New System.Drawing.Point(3, 3)
        Me.scSearch.Name = "scSearch"
        '
        'scSearch.Panel1
        '
        Me.scSearch.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.scSearch.Panel1.Controls.Add(FlowLayoutPanel5)
        '
        'scSearch.Panel2
        '
        Me.scSearch.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.scSearch.Panel2.Controls.Add(GroupBox1)
        Me.scSearch.Size = New System.Drawing.Size(566, 173)
        Me.scSearch.SplitterDistance = 323
        Me.scSearch.TabIndex = 2
        Me.scSearch.TabStop = False
        '
        'tab2Manipulasi
        '
        Me.tab2Manipulasi.Controls.Add(Me.scManipulasi)
        Me.tab2Manipulasi.Location = New System.Drawing.Point(4, 22)
        Me.tab2Manipulasi.Name = "tab2Manipulasi"
        Me.tab2Manipulasi.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2Manipulasi.Size = New System.Drawing.Size(572, 179)
        Me.tab2Manipulasi.TabIndex = 1
        Me.tab2Manipulasi.Text = "Manipulasi Data"
        Me.tab2Manipulasi.UseVisualStyleBackColor = True
        '
        'scManipulasi
        '
        Me.scManipulasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scManipulasi.Enabled = False
        Me.scManipulasi.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scManipulasi.IsSplitterFixed = True
        Me.scManipulasi.Location = New System.Drawing.Point(3, 3)
        Me.scManipulasi.Name = "scManipulasi"
        Me.scManipulasi.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scManipulasi.Panel1
        '
        Me.scManipulasi.Panel1.AutoScroll = True
        Me.scManipulasi.Panel1.Controls.Add(Me.toolStripManipulasiData)
        '
        'scManipulasi.Panel2
        '
        Me.scManipulasi.Panel2.Controls.Add(Me.inputGB)
        Me.scManipulasi.Size = New System.Drawing.Size(566, 173)
        Me.scManipulasi.SplitterDistance = 25
        Me.scManipulasi.TabIndex = 0
        Me.scManipulasi.TabStop = False
        '
        'toolStripManipulasiData
        '
        Me.toolStripManipulasiData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripManipulasiData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStripManipulasiData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.inputBtnSwitchToInsert})
        Me.toolStripManipulasiData.Location = New System.Drawing.Point(0, 0)
        Me.toolStripManipulasiData.Name = "toolStripManipulasiData"
        Me.toolStripManipulasiData.Size = New System.Drawing.Size(566, 25)
        Me.toolStripManipulasiData.Stretch = True
        Me.toolStripManipulasiData.TabIndex = 0
        Me.toolStripManipulasiData.TabStop = True
        '
        'inputBtnSwitchToInsert
        '
        Me.inputBtnSwitchToInsert.Image = Global.FP_BENGKEL_MOTOR.My.Resources.Resources.icon_file_plus
        Me.inputBtnSwitchToInsert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.inputBtnSwitchToInsert.Name = "inputBtnSwitchToInsert"
        Me.inputBtnSwitchToInsert.Size = New System.Drawing.Size(159, 22)
        Me.inputBtnSwitchToInsert.Text = "Pindah ke Mode &Tambah"
        '
        'inputGB
        '
        Me.inputGB.Controls.Add(Me.TBLTombolSubmit)
        Me.inputGB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputGB.Location = New System.Drawing.Point(0, 0)
        Me.inputGB.Name = "inputGB"
        Me.inputGB.Size = New System.Drawing.Size(566, 144)
        Me.inputGB.TabIndex = 0
        Me.inputGB.TabStop = False
        Me.inputGB.Text = "Mode manipulasi..."
        '
        'TBLTombolSubmit
        '
        Me.TBLTombolSubmit.AutoScroll = True
        Me.TBLTombolSubmit.ColumnCount = 3
        Me.TBLTombolSubmit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBLTombolSubmit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TBLTombolSubmit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TBLTombolSubmit.Controls.Add(Me.inputBtnSubmit, 1, 0)
        Me.TBLTombolSubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TBLTombolSubmit.Location = New System.Drawing.Point(3, 112)
        Me.TBLTombolSubmit.Name = "TBLTombolSubmit"
        Me.TBLTombolSubmit.RowCount = 1
        Me.TBLTombolSubmit.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TBLTombolSubmit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TBLTombolSubmit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TBLTombolSubmit.Size = New System.Drawing.Size(560, 29)
        Me.TBLTombolSubmit.TabIndex = 999
        '
        'inputBtnSubmit
        '
        Me.inputBtnSubmit.Location = New System.Drawing.Point(242, 3)
        Me.inputBtnSubmit.Name = "inputBtnSubmit"
        Me.inputBtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.inputBtnSubmit.TabIndex = 999
        Me.inputBtnSubmit.Text = "Submit"
        Me.inputBtnSubmit.UseVisualStyleBackColor = True
        '
        'footerStatusBar
        '
        Me.footerStatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.footerStatusBar.Location = New System.Drawing.Point(0, 389)
        Me.footerStatusBar.Name = "footerStatusBar"
        Me.footerStatusBar.Size = New System.Drawing.Size(584, 22)
        Me.footerStatusBar.TabIndex = 0
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(120, 17)
        Me.statusLabel.Text = "ToolStripStatusLabel1"
        '
        'bgTabelFill
        '
        Me.bgTabelFill.WorkerReportsProgress = True
        Me.bgTabelFill.WorkerSupportsCancellation = True
        '
        'FormTabelGenerik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.scGenerik)
        Me.Controls.Add(Me.footerStatusBar)
        Me.Name = "FormTabelGenerik"
        Me.Text = "TabelGenerik"
        Me.Controls.SetChildIndex(Me.footerStatusBar, 0)
        Me.Controls.SetChildIndex(Me.scGenerik, 0)
        CType(navigatorTabelDb, System.ComponentModel.ISupportInitialize).EndInit()
        navigatorTabelDb.ResumeLayout(False)
        navigatorTabelDb.PerformLayout()
        CType(Me.sourceTabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBengkel, System.ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel8.ResumeLayout(False)
        FlowLayoutPanel8.PerformLayout()
        FlowLayoutPanel9.ResumeLayout(False)
        FlowLayoutPanel9.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        FlowLayoutPanel5.ResumeLayout(False)
        CType(Me.viewTabelDb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scGenerik.Panel1.ResumeLayout(False)
        Me.scGenerik.Panel1.PerformLayout()
        Me.scGenerik.Panel2.ResumeLayout(False)
        CType(Me.scGenerik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scGenerik.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.tabletTabel.ResumeLayout(False)
        Me.tab1Search.ResumeLayout(False)
        Me.scSearch.Panel1.ResumeLayout(False)
        Me.scSearch.Panel2.ResumeLayout(False)
        CType(Me.scSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scSearch.ResumeLayout(False)
        Me.tab2Manipulasi.ResumeLayout(False)
        Me.scManipulasi.Panel1.ResumeLayout(False)
        Me.scManipulasi.Panel1.PerformLayout()
        Me.scManipulasi.Panel2.ResumeLayout(False)
        CType(Me.scManipulasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scManipulasi.ResumeLayout(False)
        Me.toolStripManipulasiData.ResumeLayout(False)
        Me.inputGB.ResumeLayout(False)
        Me.TBLTombolSubmit.ResumeLayout(False)
        Me.footerStatusBar.ResumeLayout(False)
        Me.footerStatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected WithEvents sourceTabel As System.Windows.Forms.BindingSource
    Friend WithEvents tab2Manipulasi As TabPage
    Protected Friend WithEvents statusLabel As ToolStripStatusLabel
    Protected Friend WithEvents tabletTabel As TabControl
    Protected Friend WithEvents tab1Search As TabPage
    Protected Friend WithEvents inputGB As GroupBox
    Protected WithEvents DataSetBengkel As DataSetBengkel
    Friend WithEvents TBLTombolSubmit As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents inputBtnSubmit As System.Windows.Forms.Button
    Protected Friend WithEvents scSearch As SplitContainer
    Protected Friend WithEvents footerStatusBar As StatusStrip
    Private WithEvents bgTabelFill As System.ComponentModel.BackgroundWorker
    Private WithEvents navTabelFilterPosisi As ToolStripLabel
    Protected Friend WithEvents rtbSearchRumusFilter As RichTextBox
    Private WithEvents btnSearchFilterAdd As Button
    Private WithEvents btnSearchFilterSubtract As Button
    Private WithEvents btnSearchFilterMulti As Button
    Private WithEvents btnSearchFilterDiv As Button
    Private WithEvents btnSearchFilterMod As Button
    Private WithEvents btnSearchFilterLess As Button
    Private WithEvents btnSearchFilterLessEqual As Button
    Private WithEvents btnSearchFilterEqual As Button
    Private WithEvents btnSearchFilterIn As Button
    Private WithEvents btnSearchFilterAnd As Button
    Private WithEvents btnSearchFilterMore As Button
    Private WithEvents btnSearchFilterMoreEqual As Button
    Private WithEvents btnSearchFilterNotEqual As Button
    Private WithEvents btnSearchFilterLike As Button
    Private WithEvents btnSearchFilterOr As Button
    Private WithEvents btnSearchFilterIsNull As Button
    Private WithEvents btnSearchFilterTrue As Button
    Private WithEvents btnSearchFilterParent As Button
    Private WithEvents btnSearchFilterBetween As Button
    Private WithEvents btnSearchFilterFalse As Button
    Private WithEvents btnSearchFilterChild As Button
    Private WithEvents btnSearchFilterIsNotNull As Button
    Private WithEvents btnSearchFilterOrKurungBuka As Button
    Private WithEvents btnSearchFilterKurungTutup As Button
    Friend WithEvents scGenerik As SplitContainer
    Friend WithEvents ckbTampilContainerData As CheckBox
    Friend WithEvents lbSearchDaftarKolom As ListBox
    Protected Friend WithEvents viewTabelDb As DataGridView
    Protected Friend WithEvents scManipulasi As SplitContainer
    Protected Friend WithEvents panelTop As Panel
    Friend WithEvents btnRefillTable As Button
    Protected Friend WithEvents toolStripManipulasiData As InheritedToolStrip
    Private WithEvents inputBtnSwitchToInsert As ToolStripButton
    Private WithEvents btnEditItem As ToolStripButton
    Private WithEvents btnDeleteItem As ToolStripButton
    Private WithEvents tbPositionItem As ToolStripTextBox
End Class
