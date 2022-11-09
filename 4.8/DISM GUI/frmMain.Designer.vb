<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtWIM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMount = New System.Windows.Forms.TextBox()
        Me.dlgOpenFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenWIM = New System.Windows.Forms.Button()
        Me.btnOpenMount = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDISMLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetWIMInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanupWIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleanupImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseOnlineModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMount = New System.Windows.Forms.Button()
        Me.cmbIndex = New System.Windows.Forms.ComboBox()
        Me.btnDismount = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorkerMount = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerDisMount = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkMountReadOnly = New System.Windows.Forms.CheckBox()
        Me.btnDisplayWIMInfo = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnGetAllDriverInfo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelDriver = New System.Windows.Forms.Button()
        Me.txtDelDriverLocation = New System.Windows.Forms.TextBox()
        Me.chkForceUnsigned = New System.Windows.Forms.CheckBox()
        Me.btnOpnDriverFolder = New System.Windows.Forms.Button()
        Me.txtDriverLocation = New System.Windows.Forms.TextBox()
        Me.btnGetDrivers = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkRecurse = New System.Windows.Forms.CheckBox()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRemovePackagePath = New System.Windows.Forms.Button()
        Me.btnRemovePackageName = New System.Windows.Forms.Button()
        Me.txtPackagePath = New System.Windows.Forms.TextBox()
        Me.txtPackageName = New System.Windows.Forms.TextBox()
        Me.btnGetPackages = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAddPackages = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkIgnoreCheck = New System.Windows.Forms.CheckBox()
        Me.txtPackageFile = New System.Windows.Forms.TextBox()
        Me.btnOpenPackageFile = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnDisableFeature = New System.Windows.Forms.Button()
        Me.chkEnablePkgPath = New System.Windows.Forms.CheckBox()
        Me.chkEnablePkgName = New System.Windows.Forms.CheckBox()
        Me.btnEnableFeature = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFeatPackagePath = New System.Windows.Forms.TextBox()
        Me.txtFeatPackageName = New System.Windows.Forms.TextBox()
        Me.txtFeatureName = New System.Windows.Forms.TextBox()
        Me.btnGetFeatures = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSetEdition = New System.Windows.Forms.Button()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.txtProdKey = New System.Windows.Forms.MaskedTextBox()
        Me.btnSetProdKey = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGetTargetEditions = New System.Windows.Forms.Button()
        Me.btGetCurrentEdition = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnChooseUnAttend = New System.Windows.Forms.Button()
        Me.txtUnattend = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnApplyUnattend = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btnChooseMSP = New System.Windows.Forms.Button()
        Me.txtPatchLocation = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPatchCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtProductCode = New System.Windows.Forms.MaskedTextBox()
        Me.btnCheckAppPatch = New System.Windows.Forms.Button()
        Me.btnGetAppPatchInfo = New System.Windows.Forms.Button()
        Me.btnGetAppPatches = New System.Windows.Forms.Button()
        Me.btnGetAppInfo = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnGetApps = New System.Windows.Forms.Button()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.chkCaptureVerify = New System.Windows.Forms.CheckBox()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.cmbCompression = New System.Windows.Forms.ComboBox()
        Me.lblCompression = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnCaptureDest = New System.Windows.Forms.Button()
        Me.txtCaptureDest = New System.Windows.Forms.TextBox()
        Me.txtCaptureSource = New System.Windows.Forms.TextBox()
        Me.btnCaptureSrc = New System.Windows.Forms.Button()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.chkApplyVerify = New System.Windows.Forms.CheckBox()
        Me.cmbApplyIndex = New System.Windows.Forms.ComboBox()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblDest = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.btnBrowseDest = New System.Windows.Forms.Button()
        Me.txtApplyDest = New System.Windows.Forms.TextBox()
        Me.txtxApplySource = New System.Windows.Forms.TextBox()
        Me.btnBrowseSource = New System.Windows.Forms.Button()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.analyseApply = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.resetBase = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cleanWinSxSapply = New System.Windows.Forms.Button()
        Me.BackgroundWorkerDISMCommand = New System.ComponentModel.BackgroundWorker()
        Me.dlgOpenXML = New System.Windows.Forms.OpenFileDialog()
        Me.dlgOpenMSP = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtWIM
        '
        Me.txtWIM.Location = New System.Drawing.Point(7, 29)
        Me.txtWIM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWIM.Name = "txtWIM"
        Me.txtWIM.Size = New System.Drawing.Size(451, 25)
        Me.txtWIM.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WIM File"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mount Location"
        '
        'txtMount
        '
        Me.txtMount.Location = New System.Drawing.Point(8, 125)
        Me.txtMount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMount.Name = "txtMount"
        Me.txtMount.Size = New System.Drawing.Size(451, 25)
        Me.txtMount.TabIndex = 3
        '
        'dlgOpenFolder
        '
        Me.dlgOpenFolder.SelectedPath = "c:\"
        '
        'btnOpenWIM
        '
        Me.btnOpenWIM.Location = New System.Drawing.Point(481, 24)
        Me.btnOpenWIM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOpenWIM.Name = "btnOpenWIM"
        Me.btnOpenWIM.Size = New System.Drawing.Size(141, 27)
        Me.btnOpenWIM.TabIndex = 4
        Me.btnOpenWIM.Text = "Choose WIM"
        Me.btnOpenWIM.UseVisualStyleBackColor = True
        '
        'btnOpenMount
        '
        Me.btnOpenMount.Location = New System.Drawing.Point(483, 120)
        Me.btnOpenMount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOpenMount.Name = "btnOpenMount"
        Me.btnOpenMount.Size = New System.Drawing.Size(141, 27)
        Me.btnOpenMount.TabIndex = 5
        Me.btnOpenMount.Text = "Choose Folder"
        Me.btnOpenMount.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 30)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDISMLogToolStripMenuItem, Me.GetWIMInfoToolStripMenuItem, Me.CleanupWIMToolStripMenuItem, Me.CleanupImageToolStripMenuItem, Me.UseOnlineModeToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(63, 26)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'OpenDISMLogToolStripMenuItem
        '
        Me.OpenDISMLogToolStripMenuItem.Name = "OpenDISMLogToolStripMenuItem"
        Me.OpenDISMLogToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.OpenDISMLogToolStripMenuItem.Text = "Open DISM Log"
        '
        'GetWIMInfoToolStripMenuItem
        '
        Me.GetWIMInfoToolStripMenuItem.Name = "GetWIMInfoToolStripMenuItem"
        Me.GetWIMInfoToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.GetWIMInfoToolStripMenuItem.Text = "Get Mounted WIM Info"
        '
        'CleanupWIMToolStripMenuItem
        '
        Me.CleanupWIMToolStripMenuItem.Name = "CleanupWIMToolStripMenuItem"
        Me.CleanupWIMToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.CleanupWIMToolStripMenuItem.Text = "Cleanup WIM"
        '
        'CleanupImageToolStripMenuItem
        '
        Me.CleanupImageToolStripMenuItem.Name = "CleanupImageToolStripMenuItem"
        Me.CleanupImageToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.CleanupImageToolStripMenuItem.Text = "Cleanup Image"
        '
        'UseOnlineModeToolStripMenuItem
        '
        Me.UseOnlineModeToolStripMenuItem.CheckOnClick = True
        Me.UseOnlineModeToolStripMenuItem.Name = "UseOnlineModeToolStripMenuItem"
        Me.UseOnlineModeToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.UseOnlineModeToolStripMenuItem.Text = "Use Online Mode"
        Me.UseOnlineModeToolStripMenuItem.Visible = False
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnMount
        '
        Me.btnMount.Location = New System.Drawing.Point(697, 24)
        Me.btnMount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMount.Name = "btnMount"
        Me.btnMount.Size = New System.Drawing.Size(169, 74)
        Me.btnMount.TabIndex = 7
        Me.btnMount.Text = "Mount WIM"
        Me.btnMount.UseVisualStyleBackColor = True
        '
        'cmbIndex
        '
        Me.cmbIndex.FormattingEnabled = True
        Me.cmbIndex.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbIndex.Location = New System.Drawing.Point(637, 29)
        Me.cmbIndex.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbIndex.Name = "cmbIndex"
        Me.cmbIndex.Size = New System.Drawing.Size(39, 23)
        Me.cmbIndex.TabIndex = 8
        '
        'btnDismount
        '
        Me.btnDismount.Enabled = False
        Me.btnDismount.Location = New System.Drawing.Point(697, 105)
        Me.btnDismount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDismount.Name = "btnDismount"
        Me.btnDismount.Size = New System.Drawing.Size(169, 74)
        Me.btnDismount.TabIndex = 10
        Me.btnDismount.Text = "Dismount WIM"
        Me.btnDismount.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(15, 503)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(873, 283)
        Me.txtOutput.TabIndex = 13
        Me.txtOutput.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 485)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "DISM Output"
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(697, 186)
        Me.btnOpenFolder.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(169, 74)
        Me.btnOpenFolder.TabIndex = 15
        Me.btnOpenFolder.Text = "Open Mounted Folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(793, 793)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 27)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Index"
        '
        'BackgroundWorkerMount
        '
        Me.BackgroundWorkerMount.WorkerReportsProgress = True
        Me.BackgroundWorkerMount.WorkerSupportsCancellation = True
        '
        'BackgroundWorkerDisMount
        '
        Me.BackgroundWorkerDisMount.WorkerReportsProgress = True
        Me.BackgroundWorkerDisMount.WorkerSupportsCancellation = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Location = New System.Drawing.Point(15, 31)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(884, 450)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkMountReadOnly)
        Me.TabPage1.Controls.Add(Me.btnDisplayWIMInfo)
        Me.TabPage1.Controls.Add(Me.btnOpenWIM)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtWIM)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnOpenFolder)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtMount)
        Me.TabPage1.Controls.Add(Me.btnOpenMount)
        Me.TabPage1.Controls.Add(Me.btnDismount)
        Me.TabPage1.Controls.Add(Me.btnMount)
        Me.TabPage1.Controls.Add(Me.cmbIndex)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(876, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mount Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkMountReadOnly
        '
        Me.chkMountReadOnly.AutoSize = True
        Me.chkMountReadOnly.Location = New System.Drawing.Point(12, 158)
        Me.chkMountReadOnly.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkMountReadOnly.Name = "chkMountReadOnly"
        Me.chkMountReadOnly.Size = New System.Drawing.Size(101, 19)
        Me.chkMountReadOnly.TabIndex = 19
        Me.chkMountReadOnly.Text = "Read Only"
        Me.chkMountReadOnly.UseVisualStyleBackColor = True
        '
        'btnDisplayWIMInfo
        '
        Me.btnDisplayWIMInfo.Location = New System.Drawing.Point(5, 60)
        Me.btnDisplayWIMInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplayWIMInfo.Name = "btnDisplayWIMInfo"
        Me.btnDisplayWIMInfo.Size = New System.Drawing.Size(165, 27)
        Me.btnDisplayWIMInfo.TabIndex = 18
        Me.btnDisplayWIMInfo.Text = "Display WIM Info"
        Me.btnDisplayWIMInfo.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnGetAllDriverInfo)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.chkForceUnsigned)
        Me.TabPage2.Controls.Add(Me.btnOpnDriverFolder)
        Me.TabPage2.Controls.Add(Me.txtDriverLocation)
        Me.TabPage2.Controls.Add(Me.btnGetDrivers)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Size = New System.Drawing.Size(876, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Driver Management"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnGetAllDriverInfo
        '
        Me.btnGetAllDriverInfo.Location = New System.Drawing.Point(700, 88)
        Me.btnGetAllDriverInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetAllDriverInfo.Name = "btnGetAllDriverInfo"
        Me.btnGetAllDriverInfo.Size = New System.Drawing.Size(169, 74)
        Me.btnGetAllDriverInfo.TabIndex = 14
        Me.btnGetAllDriverInfo.Text = "Get All Driver information from WIM"
        Me.btnGetAllDriverInfo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnDelDriver)
        Me.GroupBox2.Controls.Add(Me.txtDelDriverLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 227)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(615, 75)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delete Drivers"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Driver Name"
        '
        'btnDelDriver
        '
        Me.btnDelDriver.Location = New System.Drawing.Point(421, 40)
        Me.btnDelDriver.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDelDriver.Name = "btnDelDriver"
        Me.btnDelDriver.Size = New System.Drawing.Size(165, 27)
        Me.btnDelDriver.TabIndex = 1
        Me.btnDelDriver.Text = "Delete Driver"
        Me.btnDelDriver.UseVisualStyleBackColor = True
        '
        'txtDelDriverLocation
        '
        Me.txtDelDriverLocation.Location = New System.Drawing.Point(5, 45)
        Me.txtDelDriverLocation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDelDriverLocation.Name = "txtDelDriverLocation"
        Me.txtDelDriverLocation.Size = New System.Drawing.Size(405, 25)
        Me.txtDelDriverLocation.TabIndex = 0
        '
        'chkForceUnsigned
        '
        Me.chkForceUnsigned.AutoSize = True
        Me.chkForceUnsigned.Location = New System.Drawing.Point(13, 78)
        Me.chkForceUnsigned.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkForceUnsigned.Name = "chkForceUnsigned"
        Me.chkForceUnsigned.Size = New System.Drawing.Size(141, 19)
        Me.chkForceUnsigned.TabIndex = 10
        Me.chkForceUnsigned.Text = "Force Unsigned"
        Me.chkForceUnsigned.UseVisualStyleBackColor = True
        '
        'btnOpnDriverFolder
        '
        Me.btnOpnDriverFolder.Location = New System.Drawing.Point(432, 39)
        Me.btnOpnDriverFolder.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOpnDriverFolder.Name = "btnOpnDriverFolder"
        Me.btnOpnDriverFolder.Size = New System.Drawing.Size(167, 27)
        Me.btnOpnDriverFolder.TabIndex = 3
        Me.btnOpnDriverFolder.Text = "Choose Driver Folder"
        Me.btnOpnDriverFolder.UseVisualStyleBackColor = True
        '
        'txtDriverLocation
        '
        Me.txtDriverLocation.Location = New System.Drawing.Point(15, 39)
        Me.txtDriverLocation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDriverLocation.Name = "txtDriverLocation"
        Me.txtDriverLocation.Size = New System.Drawing.Size(408, 25)
        Me.txtDriverLocation.TabIndex = 2
        '
        'btnGetDrivers
        '
        Me.btnGetDrivers.Location = New System.Drawing.Point(700, 7)
        Me.btnGetDrivers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetDrivers.Name = "btnGetDrivers"
        Me.btnGetDrivers.Size = New System.Drawing.Size(169, 74)
        Me.btnGetDrivers.TabIndex = 1
        Me.btnGetDrivers.Text = "Get 3rd Party Driver information from WIM"
        Me.btnGetDrivers.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Drivers Folder Location"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRecurse)
        Me.GroupBox1.Controls.Add(Me.btnAddDriver)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(615, 213)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Drivers"
        '
        'chkRecurse
        '
        Me.chkRecurse.AutoSize = True
        Me.chkRecurse.Checked = True
        Me.chkRecurse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecurse.Location = New System.Drawing.Point(149, 72)
        Me.chkRecurse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkRecurse.Name = "chkRecurse"
        Me.chkRecurse.Size = New System.Drawing.Size(85, 19)
        Me.chkRecurse.TabIndex = 9
        Me.chkRecurse.Text = "Recurse"
        Me.chkRecurse.UseVisualStyleBackColor = True
        '
        'btnAddDriver
        '
        Me.btnAddDriver.Location = New System.Drawing.Point(5, 98)
        Me.btnAddDriver.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(169, 74)
        Me.btnAddDriver.TabIndex = 8
        Me.btnAddDriver.Text = "Add Drivers"
        Me.btnAddDriver.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.btnGetPackages)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(876, 421)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Package Management"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnRemovePackagePath)
        Me.GroupBox4.Controls.Add(Me.btnRemovePackageName)
        Me.GroupBox4.Controls.Add(Me.txtPackagePath)
        Me.GroupBox4.Controls.Add(Me.txtPackageName)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 182)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(687, 183)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Remove Packages"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Package Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 76)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Package Path"
        '
        'btnRemovePackagePath
        '
        Me.btnRemovePackagePath.Location = New System.Drawing.Point(423, 102)
        Me.btnRemovePackagePath.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemovePackagePath.Name = "btnRemovePackagePath"
        Me.btnRemovePackagePath.Size = New System.Drawing.Size(175, 27)
        Me.btnRemovePackagePath.TabIndex = 3
        Me.btnRemovePackagePath.Text = "Remove Package"
        Me.btnRemovePackagePath.UseVisualStyleBackColor = True
        '
        'btnRemovePackageName
        '
        Me.btnRemovePackageName.Location = New System.Drawing.Point(423, 50)
        Me.btnRemovePackageName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemovePackageName.Name = "btnRemovePackageName"
        Me.btnRemovePackageName.Size = New System.Drawing.Size(175, 27)
        Me.btnRemovePackageName.TabIndex = 2
        Me.btnRemovePackageName.Text = "Remove Package"
        Me.btnRemovePackageName.UseVisualStyleBackColor = True
        '
        'txtPackagePath
        '
        Me.txtPackagePath.Location = New System.Drawing.Point(4, 102)
        Me.txtPackagePath.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPackagePath.Name = "txtPackagePath"
        Me.txtPackagePath.Size = New System.Drawing.Size(408, 25)
        Me.txtPackagePath.TabIndex = 1
        '
        'txtPackageName
        '
        Me.txtPackageName.Location = New System.Drawing.Point(4, 50)
        Me.txtPackageName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(408, 25)
        Me.txtPackageName.TabIndex = 0
        '
        'btnGetPackages
        '
        Me.btnGetPackages.Location = New System.Drawing.Point(700, 3)
        Me.btnGetPackages.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetPackages.Name = "btnGetPackages"
        Me.btnGetPackages.Size = New System.Drawing.Size(169, 74)
        Me.btnGetPackages.TabIndex = 9
        Me.btnGetPackages.Text = "Get Packges from WIM"
        Me.btnGetPackages.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAddPackages)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.chkIgnoreCheck)
        Me.GroupBox3.Controls.Add(Me.txtPackageFile)
        Me.GroupBox3.Controls.Add(Me.btnOpenPackageFile)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(688, 171)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Packages"
        '
        'btnAddPackages
        '
        Me.btnAddPackages.Location = New System.Drawing.Point(8, 90)
        Me.btnAddPackages.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddPackages.Name = "btnAddPackages"
        Me.btnAddPackages.Size = New System.Drawing.Size(169, 74)
        Me.btnAddPackages.TabIndex = 14
        Me.btnAddPackages.Text = "Add Packages"
        Me.btnAddPackages.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Package Folder"
        '
        'chkIgnoreCheck
        '
        Me.chkIgnoreCheck.AutoSize = True
        Me.chkIgnoreCheck.Location = New System.Drawing.Point(12, 63)
        Me.chkIgnoreCheck.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkIgnoreCheck.Name = "chkIgnoreCheck"
        Me.chkIgnoreCheck.Size = New System.Drawing.Size(125, 19)
        Me.chkIgnoreCheck.TabIndex = 13
        Me.chkIgnoreCheck.Text = "Ignore Check"
        Me.chkIgnoreCheck.UseVisualStyleBackColor = True
        '
        'txtPackageFile
        '
        Me.txtPackageFile.Location = New System.Drawing.Point(8, 33)
        Me.txtPackageFile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPackageFile.Name = "txtPackageFile"
        Me.txtPackageFile.Size = New System.Drawing.Size(408, 25)
        Me.txtPackageFile.TabIndex = 10
        '
        'btnOpenPackageFile
        '
        Me.btnOpenPackageFile.Location = New System.Drawing.Point(427, 29)
        Me.btnOpenPackageFile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOpenPackageFile.Name = "btnOpenPackageFile"
        Me.btnOpenPackageFile.Size = New System.Drawing.Size(175, 27)
        Me.btnOpenPackageFile.TabIndex = 12
        Me.btnOpenPackageFile.Text = "Choose Package Folder"
        Me.btnOpenPackageFile.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnDisableFeature)
        Me.TabPage4.Controls.Add(Me.chkEnablePkgPath)
        Me.TabPage4.Controls.Add(Me.chkEnablePkgName)
        Me.TabPage4.Controls.Add(Me.btnEnableFeature)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.txtFeatPackagePath)
        Me.TabPage4.Controls.Add(Me.txtFeatPackageName)
        Me.TabPage4.Controls.Add(Me.txtFeatureName)
        Me.TabPage4.Controls.Add(Me.btnGetFeatures)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage4.Size = New System.Drawing.Size(876, 421)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Feature Management"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnDisableFeature
        '
        Me.btnDisableFeature.Location = New System.Drawing.Point(700, 165)
        Me.btnDisableFeature.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisableFeature.Name = "btnDisableFeature"
        Me.btnDisableFeature.Size = New System.Drawing.Size(169, 74)
        Me.btnDisableFeature.TabIndex = 22
        Me.btnDisableFeature.Text = "Disable Feature"
        Me.btnDisableFeature.UseVisualStyleBackColor = True
        '
        'chkEnablePkgPath
        '
        Me.chkEnablePkgPath.AutoSize = True
        Me.chkEnablePkgPath.Location = New System.Drawing.Point(7, 135)
        Me.chkEnablePkgPath.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkEnablePkgPath.Name = "chkEnablePkgPath"
        Me.chkEnablePkgPath.Size = New System.Drawing.Size(18, 17)
        Me.chkEnablePkgPath.TabIndex = 21
        Me.chkEnablePkgPath.UseVisualStyleBackColor = True
        '
        'chkEnablePkgName
        '
        Me.chkEnablePkgName.AutoSize = True
        Me.chkEnablePkgName.Location = New System.Drawing.Point(7, 81)
        Me.chkEnablePkgName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkEnablePkgName.Name = "chkEnablePkgName"
        Me.chkEnablePkgName.Size = New System.Drawing.Size(18, 17)
        Me.chkEnablePkgName.TabIndex = 20
        Me.chkEnablePkgName.UseVisualStyleBackColor = True
        '
        'btnEnableFeature
        '
        Me.btnEnableFeature.Location = New System.Drawing.Point(700, 84)
        Me.btnEnableFeature.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEnableFeature.Name = "btnEnableFeature"
        Me.btnEnableFeature.Size = New System.Drawing.Size(169, 74)
        Me.btnEnableFeature.TabIndex = 19
        Me.btnEnableFeature.Text = "Enable Feature"
        Me.btnEnableFeature.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 110)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Package Path"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 55)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Package Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 3)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Feature Name"
        '
        'txtFeatPackagePath
        '
        Me.txtFeatPackagePath.Enabled = False
        Me.txtFeatPackagePath.Location = New System.Drawing.Point(35, 128)
        Me.txtFeatPackagePath.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFeatPackagePath.Name = "txtFeatPackagePath"
        Me.txtFeatPackagePath.Size = New System.Drawing.Size(564, 25)
        Me.txtFeatPackagePath.TabIndex = 15
        '
        'txtFeatPackageName
        '
        Me.txtFeatPackageName.Enabled = False
        Me.txtFeatPackageName.Location = New System.Drawing.Point(35, 74)
        Me.txtFeatPackageName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFeatPackageName.Name = "txtFeatPackageName"
        Me.txtFeatPackageName.Size = New System.Drawing.Size(564, 25)
        Me.txtFeatPackageName.TabIndex = 12
        '
        'txtFeatureName
        '
        Me.txtFeatureName.Location = New System.Drawing.Point(35, 22)
        Me.txtFeatureName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFeatureName.Name = "txtFeatureName"
        Me.txtFeatureName.Size = New System.Drawing.Size(564, 25)
        Me.txtFeatureName.TabIndex = 11
        '
        'btnGetFeatures
        '
        Me.btnGetFeatures.Location = New System.Drawing.Point(700, 3)
        Me.btnGetFeatures.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetFeatures.Name = "btnGetFeatures"
        Me.btnGetFeatures.Size = New System.Drawing.Size(169, 74)
        Me.btnGetFeatures.TabIndex = 10
        Me.btnGetFeatures.Text = "Get Features from WIM"
        Me.btnGetFeatures.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.btnSetEdition)
        Me.TabPage5.Controls.Add(Me.txtEdition)
        Me.TabPage5.Controls.Add(Me.txtProdKey)
        Me.TabPage5.Controls.Add(Me.btnSetProdKey)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.btnGetTargetEditions)
        Me.TabPage5.Controls.Add(Me.btGetCurrentEdition)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(876, 421)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Edition Servicing"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 92)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Edition"
        '
        'btnSetEdition
        '
        Me.btnSetEdition.Location = New System.Drawing.Point(21, 141)
        Me.btnSetEdition.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSetEdition.Name = "btnSetEdition"
        Me.btnSetEdition.Size = New System.Drawing.Size(172, 27)
        Me.btnSetEdition.TabIndex = 27
        Me.btnSetEdition.Text = "Set Edition"
        Me.btnSetEdition.UseVisualStyleBackColor = True
        '
        'txtEdition
        '
        Me.txtEdition.Location = New System.Drawing.Point(21, 111)
        Me.txtEdition.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(403, 25)
        Me.txtEdition.TabIndex = 26
        '
        'txtProdKey
        '
        Me.txtProdKey.Location = New System.Drawing.Point(21, 22)
        Me.txtProdKey.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtProdKey.Mask = "&&&&&-&&&&&-&&&&&-&&&&&-&&&&&"
        Me.txtProdKey.Name = "txtProdKey"
        Me.txtProdKey.Size = New System.Drawing.Size(403, 25)
        Me.txtProdKey.TabIndex = 25
        '
        'btnSetProdKey
        '
        Me.btnSetProdKey.Location = New System.Drawing.Point(21, 52)
        Me.btnSetProdKey.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSetProdKey.Name = "btnSetProdKey"
        Me.btnSetProdKey.Size = New System.Drawing.Size(172, 27)
        Me.btnSetProdKey.TabIndex = 24
        Me.btnSetProdKey.Text = "Set Product Key"
        Me.btnSetProdKey.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 3)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Product Key"
        '
        'btnGetTargetEditions
        '
        Me.btnGetTargetEditions.Location = New System.Drawing.Point(700, 84)
        Me.btnGetTargetEditions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetTargetEditions.Name = "btnGetTargetEditions"
        Me.btnGetTargetEditions.Size = New System.Drawing.Size(169, 74)
        Me.btnGetTargetEditions.TabIndex = 12
        Me.btnGetTargetEditions.Text = "Get Target Editions"
        Me.btnGetTargetEditions.UseVisualStyleBackColor = True
        '
        'btGetCurrentEdition
        '
        Me.btGetCurrentEdition.Location = New System.Drawing.Point(700, 3)
        Me.btGetCurrentEdition.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btGetCurrentEdition.Name = "btGetCurrentEdition"
        Me.btGetCurrentEdition.Size = New System.Drawing.Size(169, 74)
        Me.btGetCurrentEdition.TabIndex = 11
        Me.btGetCurrentEdition.Text = "Get Current Edition"
        Me.btGetCurrentEdition.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnChooseUnAttend)
        Me.TabPage6.Controls.Add(Me.txtUnattend)
        Me.TabPage6.Controls.Add(Me.Label14)
        Me.TabPage6.Controls.Add(Me.btnApplyUnattend)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(876, 421)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Unattended Servicing"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnChooseUnAttend
        '
        Me.btnChooseUnAttend.Location = New System.Drawing.Point(477, 24)
        Me.btnChooseUnAttend.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnChooseUnAttend.Name = "btnChooseUnAttend"
        Me.btnChooseUnAttend.Size = New System.Drawing.Size(141, 27)
        Me.btnChooseUnAttend.TabIndex = 23
        Me.btnChooseUnAttend.Text = "Choose XML"
        Me.btnChooseUnAttend.UseVisualStyleBackColor = True
        '
        'txtUnattend
        '
        Me.txtUnattend.Location = New System.Drawing.Point(3, 29)
        Me.txtUnattend.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtUnattend.Name = "txtUnattend"
        Me.txtUnattend.Size = New System.Drawing.Size(451, 25)
        Me.txtUnattend.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 3)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Unattend XML File"
        '
        'btnApplyUnattend
        '
        Me.btnApplyUnattend.Location = New System.Drawing.Point(700, 3)
        Me.btnApplyUnattend.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnApplyUnattend.Name = "btnApplyUnattend"
        Me.btnApplyUnattend.Size = New System.Drawing.Size(169, 74)
        Me.btnApplyUnattend.TabIndex = 20
        Me.btnApplyUnattend.Text = "Apply Unattend.xml"
        Me.btnApplyUnattend.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btnChooseMSP)
        Me.TabPage7.Controls.Add(Me.txtPatchLocation)
        Me.TabPage7.Controls.Add(Me.Label18)
        Me.TabPage7.Controls.Add(Me.txtPatchCode)
        Me.TabPage7.Controls.Add(Me.txtProductCode)
        Me.TabPage7.Controls.Add(Me.btnCheckAppPatch)
        Me.TabPage7.Controls.Add(Me.btnGetAppPatchInfo)
        Me.TabPage7.Controls.Add(Me.btnGetAppPatches)
        Me.TabPage7.Controls.Add(Me.btnGetAppInfo)
        Me.TabPage7.Controls.Add(Me.Label17)
        Me.TabPage7.Controls.Add(Me.Label16)
        Me.TabPage7.Controls.Add(Me.btnGetApps)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(876, 421)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Application Servicing"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'btnChooseMSP
        '
        Me.btnChooseMSP.Location = New System.Drawing.Point(477, 114)
        Me.btnChooseMSP.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnChooseMSP.Name = "btnChooseMSP"
        Me.btnChooseMSP.Size = New System.Drawing.Size(141, 27)
        Me.btnChooseMSP.TabIndex = 41
        Me.btnChooseMSP.Text = "Choose MSP"
        Me.btnChooseMSP.UseVisualStyleBackColor = True
        '
        'txtPatchLocation
        '
        Me.txtPatchLocation.Location = New System.Drawing.Point(8, 117)
        Me.txtPatchLocation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPatchLocation.Name = "txtPatchLocation"
        Me.txtPatchLocation.Size = New System.Drawing.Size(403, 25)
        Me.txtPatchLocation.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 93)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 15)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "MSP File"
        '
        'txtPatchCode
        '
        Me.txtPatchCode.Location = New System.Drawing.Point(8, 67)
        Me.txtPatchCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPatchCode.Mask = "{&&&&&&&&-&&&&-&&&&-&&&&-&&&&&&&&&&&&}"
        Me.txtPatchCode.Name = "txtPatchCode"
        Me.txtPatchCode.Size = New System.Drawing.Size(403, 25)
        Me.txtPatchCode.TabIndex = 38
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(8, 22)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtProductCode.Mask = "{&&&&&&&&-&&&&-&&&&-&&&&-&&&&&&&&&&&&}"
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(403, 25)
        Me.txtProductCode.TabIndex = 37
        '
        'btnCheckAppPatch
        '
        Me.btnCheckAppPatch.Location = New System.Drawing.Point(700, 327)
        Me.btnCheckAppPatch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCheckAppPatch.Name = "btnCheckAppPatch"
        Me.btnCheckAppPatch.Size = New System.Drawing.Size(169, 74)
        Me.btnCheckAppPatch.TabIndex = 36
        Me.btnCheckAppPatch.Text = "Check App Patch"
        Me.btnCheckAppPatch.UseVisualStyleBackColor = True
        '
        'btnGetAppPatchInfo
        '
        Me.btnGetAppPatchInfo.Location = New System.Drawing.Point(700, 246)
        Me.btnGetAppPatchInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetAppPatchInfo.Name = "btnGetAppPatchInfo"
        Me.btnGetAppPatchInfo.Size = New System.Drawing.Size(169, 74)
        Me.btnGetAppPatchInfo.TabIndex = 35
        Me.btnGetAppPatchInfo.Text = "Get Application Patch Info"
        Me.btnGetAppPatchInfo.UseVisualStyleBackColor = True
        '
        'btnGetAppPatches
        '
        Me.btnGetAppPatches.Location = New System.Drawing.Point(700, 165)
        Me.btnGetAppPatches.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetAppPatches.Name = "btnGetAppPatches"
        Me.btnGetAppPatches.Size = New System.Drawing.Size(169, 74)
        Me.btnGetAppPatches.TabIndex = 34
        Me.btnGetAppPatches.Text = "Get Application Patches"
        Me.btnGetAppPatches.UseVisualStyleBackColor = True
        '
        'btnGetAppInfo
        '
        Me.btnGetAppInfo.Location = New System.Drawing.Point(700, 84)
        Me.btnGetAppInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetAppInfo.Name = "btnGetAppInfo"
        Me.btnGetAppInfo.Size = New System.Drawing.Size(169, 74)
        Me.btnGetAppInfo.TabIndex = 33
        Me.btnGetAppInfo.Text = "Get Application Info"
        Me.btnGetAppInfo.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 48)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 15)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "PatchCode"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(0, 3)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 15)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "ProductCode"
        '
        'btnGetApps
        '
        Me.btnGetApps.Location = New System.Drawing.Point(700, 3)
        Me.btnGetApps.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnGetApps.Name = "btnGetApps"
        Me.btnGetApps.Size = New System.Drawing.Size(169, 74)
        Me.btnGetApps.TabIndex = 12
        Me.btnGetApps.Text = "Get Applications"
        Me.btnGetApps.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.chkCaptureVerify)
        Me.TabPage8.Controls.Add(Me.btnAppend)
        Me.TabPage8.Controls.Add(Me.cmbCompression)
        Me.TabPage8.Controls.Add(Me.lblCompression)
        Me.TabPage8.Controls.Add(Me.lblName)
        Me.TabPage8.Controls.Add(Me.txtName)
        Me.TabPage8.Controls.Add(Me.btnCreate)
        Me.TabPage8.Controls.Add(Me.Label20)
        Me.TabPage8.Controls.Add(Me.Label21)
        Me.TabPage8.Controls.Add(Me.btnCaptureDest)
        Me.TabPage8.Controls.Add(Me.txtCaptureDest)
        Me.TabPage8.Controls.Add(Me.txtCaptureSource)
        Me.TabPage8.Controls.Add(Me.btnCaptureSrc)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(876, 421)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Capture Image"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'chkCaptureVerify
        '
        Me.chkCaptureVerify.AutoSize = True
        Me.chkCaptureVerify.Location = New System.Drawing.Point(123, 145)
        Me.chkCaptureVerify.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkCaptureVerify.Name = "chkCaptureVerify"
        Me.chkCaptureVerify.Size = New System.Drawing.Size(77, 19)
        Me.chkCaptureVerify.TabIndex = 46
        Me.chkCaptureVerify.Text = "Verify"
        Me.chkCaptureVerify.UseVisualStyleBackColor = True
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(700, 84)
        Me.btnAppend.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(169, 74)
        Me.btnAppend.TabIndex = 45
        Me.btnAppend.Text = "&Append"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'cmbCompression
        '
        Me.cmbCompression.FormattingEnabled = True
        Me.cmbCompression.Items.AddRange(New Object() {"None", "Fast", "Maximum"})
        Me.cmbCompression.Location = New System.Drawing.Point(123, 114)
        Me.cmbCompression.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbCompression.Name = "cmbCompression"
        Me.cmbCompression.Size = New System.Drawing.Size(105, 23)
        Me.cmbCompression.TabIndex = 44
        '
        'lblCompression
        '
        Me.lblCompression.AutoSize = True
        Me.lblCompression.Location = New System.Drawing.Point(20, 121)
        Me.lblCompression.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompression.Name = "lblCompression"
        Me.lblCompression.Size = New System.Drawing.Size(103, 15)
        Me.lblCompression.TabIndex = 43
        Me.lblCompression.Text = "Compression:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(63, 87)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 15)
        Me.lblName.TabIndex = 42
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(121, 83)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(392, 25)
        Me.txtName.TabIndex = 34
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(700, 3)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(169, 74)
        Me.btnCreate.TabIndex = 40
        Me.btnCreate.Text = "&Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 57)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 15)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Destination:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(55, 27)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 15)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Source:"
        '
        'btnCaptureDest
        '
        Me.btnCaptureDest.Location = New System.Drawing.Point(523, 51)
        Me.btnCaptureDest.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCaptureDest.Name = "btnCaptureDest"
        Me.btnCaptureDest.Size = New System.Drawing.Size(100, 27)
        Me.btnCaptureDest.TabIndex = 39
        Me.btnCaptureDest.Text = "Browse..."
        Me.btnCaptureDest.UseVisualStyleBackColor = True
        '
        'txtCaptureDest
        '
        Me.txtCaptureDest.Location = New System.Drawing.Point(121, 53)
        Me.txtCaptureDest.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCaptureDest.Name = "txtCaptureDest"
        Me.txtCaptureDest.Size = New System.Drawing.Size(392, 25)
        Me.txtCaptureDest.TabIndex = 37
        '
        'txtCaptureSource
        '
        Me.txtCaptureSource.Location = New System.Drawing.Point(121, 23)
        Me.txtCaptureSource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCaptureSource.Name = "txtCaptureSource"
        Me.txtCaptureSource.Size = New System.Drawing.Size(392, 25)
        Me.txtCaptureSource.TabIndex = 35
        '
        'btnCaptureSrc
        '
        Me.btnCaptureSrc.Location = New System.Drawing.Point(523, 21)
        Me.btnCaptureSrc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCaptureSrc.Name = "btnCaptureSrc"
        Me.btnCaptureSrc.Size = New System.Drawing.Size(100, 27)
        Me.btnCaptureSrc.TabIndex = 36
        Me.btnCaptureSrc.Text = "Browse..."
        Me.btnCaptureSrc.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.chkApplyVerify)
        Me.TabPage9.Controls.Add(Me.cmbApplyIndex)
        Me.TabPage9.Controls.Add(Me.lblIndex)
        Me.TabPage9.Controls.Add(Me.btnApply)
        Me.TabPage9.Controls.Add(Me.lblDest)
        Me.TabPage9.Controls.Add(Me.lblSource)
        Me.TabPage9.Controls.Add(Me.btnBrowseDest)
        Me.TabPage9.Controls.Add(Me.txtApplyDest)
        Me.TabPage9.Controls.Add(Me.txtxApplySource)
        Me.TabPage9.Controls.Add(Me.btnBrowseSource)
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(876, 421)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Apply Image"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'chkApplyVerify
        '
        Me.chkApplyVerify.AutoSize = True
        Me.chkApplyVerify.Location = New System.Drawing.Point(103, 119)
        Me.chkApplyVerify.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkApplyVerify.Name = "chkApplyVerify"
        Me.chkApplyVerify.Size = New System.Drawing.Size(77, 19)
        Me.chkApplyVerify.TabIndex = 41
        Me.chkApplyVerify.Text = "Verify"
        Me.chkApplyVerify.UseVisualStyleBackColor = True
        '
        'cmbApplyIndex
        '
        Me.cmbApplyIndex.FormattingEnabled = True
        Me.cmbApplyIndex.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbApplyIndex.Location = New System.Drawing.Point(103, 87)
        Me.cmbApplyIndex.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbApplyIndex.Name = "cmbApplyIndex"
        Me.cmbApplyIndex.Size = New System.Drawing.Size(39, 23)
        Me.cmbApplyIndex.TabIndex = 40
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.Location = New System.Drawing.Point(47, 87)
        Me.lblIndex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(55, 15)
        Me.lblIndex.TabIndex = 39
        Me.lblIndex.Text = "Index:"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(700, 3)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(169, 74)
        Me.btnApply.TabIndex = 37
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblDest
        '
        Me.lblDest.AutoSize = True
        Me.lblDest.Location = New System.Drawing.Point(11, 57)
        Me.lblDest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDest.Name = "lblDest"
        Me.lblDest.Size = New System.Drawing.Size(103, 15)
        Me.lblDest.TabIndex = 38
        Me.lblDest.Text = "Destination:"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(36, 20)
        Me.lblSource.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(63, 15)
        Me.lblSource.TabIndex = 35
        Me.lblSource.Text = "Source:"
        '
        'btnBrowseDest
        '
        Me.btnBrowseDest.Location = New System.Drawing.Point(504, 50)
        Me.btnBrowseDest.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBrowseDest.Name = "btnBrowseDest"
        Me.btnBrowseDest.Size = New System.Drawing.Size(100, 27)
        Me.btnBrowseDest.TabIndex = 36
        Me.btnBrowseDest.Text = "Browse..."
        Me.btnBrowseDest.UseVisualStyleBackColor = True
        '
        'txtApplyDest
        '
        Me.txtApplyDest.Location = New System.Drawing.Point(103, 53)
        Me.txtApplyDest.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtApplyDest.Name = "txtApplyDest"
        Me.txtApplyDest.Size = New System.Drawing.Size(392, 25)
        Me.txtApplyDest.TabIndex = 34
        '
        'txtxApplySource
        '
        Me.txtxApplySource.Location = New System.Drawing.Point(103, 16)
        Me.txtxApplySource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtxApplySource.Name = "txtxApplySource"
        Me.txtxApplySource.Size = New System.Drawing.Size(392, 25)
        Me.txtxApplySource.TabIndex = 32
        '
        'btnBrowseSource
        '
        Me.btnBrowseSource.AutoSize = True
        Me.btnBrowseSource.Location = New System.Drawing.Point(504, 16)
        Me.btnBrowseSource.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBrowseSource.Name = "btnBrowseSource"
        Me.btnBrowseSource.Size = New System.Drawing.Size(119, 29)
        Me.btnBrowseSource.TabIndex = 33
        Me.btnBrowseSource.Text = "Browse..."
        Me.btnBrowseSource.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.GroupBox6)
        Me.TabPage10.Controls.Add(Me.GroupBox5)
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(876, 421)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Clean WinSxS"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.analyseApply)
        Me.GroupBox6.Location = New System.Drawing.Point(26, 25)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(804, 144)
        Me.GroupBox6.TabIndex = 40
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Analyze"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(327, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Creates a report of the component store."
        '
        'analyseApply
        '
        Me.analyseApply.Location = New System.Drawing.Point(612, 37)
        Me.analyseApply.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.analyseApply.Name = "analyseApply"
        Me.analyseApply.Size = New System.Drawing.Size(169, 74)
        Me.analyseApply.TabIndex = 38
        Me.analyseApply.Text = "&Apply"
        Me.analyseApply.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.resetBase)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.cleanWinSxSapply)
        Me.GroupBox5.Location = New System.Drawing.Point(26, 201)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(804, 144)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Clean"
        '
        'resetBase
        '
        Me.resetBase.AutoSize = True
        Me.resetBase.BackColor = System.Drawing.Color.Transparent
        Me.resetBase.ForeColor = System.Drawing.SystemColors.Highlight
        Me.resetBase.Location = New System.Drawing.Point(9, 77)
        Me.resetBase.Name = "resetBase"
        Me.resetBase.Size = New System.Drawing.Size(589, 49)
        Me.resetBase.TabIndex = 40
        Me.resetBase.Text = "reset the base of superseded components, which can further reduce the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "component" &
    " store size. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Installed Windows updates can’t be uninstalled "
        Me.resetBase.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(599, 30)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Cleans up the superseded components and reduces the size of the component " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "store" &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cleanWinSxSapply
        '
        Me.cleanWinSxSapply.Location = New System.Drawing.Point(612, 37)
        Me.cleanWinSxSapply.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cleanWinSxSapply.Name = "cleanWinSxSapply"
        Me.cleanWinSxSapply.Size = New System.Drawing.Size(169, 74)
        Me.cleanWinSxSapply.TabIndex = 38
        Me.cleanWinSxSapply.Text = "&Apply"
        Me.cleanWinSxSapply.UseVisualStyleBackColor = True
        '
        'BackgroundWorkerDISMCommand
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 833)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.Text = "DISM GUI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWIM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMount As System.Windows.Forms.TextBox
    Friend WithEvents dlgOpenFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenWIM As System.Windows.Forms.Button
    Friend WithEvents btnOpenMount As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMount As System.Windows.Forms.Button
    Friend WithEvents cmbIndex As System.Windows.Forms.ComboBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDismount As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOpenFolder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenDISMLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorkerMount As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerDisMount As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGetDrivers As System.Windows.Forms.Button
    Friend WithEvents txtDriverLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnOpnDriverFolder As System.Windows.Forms.Button
    Friend WithEvents chkForceUnsigned As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddDriver As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorkerDISMCommand As System.ComponentModel.BackgroundWorker
    Friend WithEvents CleanupWIMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetWIMInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDisplayWIMInfo As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnGetPackages As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPackageFile As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenPackageFile As System.Windows.Forms.Button
    Friend WithEvents btnAddPackages As System.Windows.Forms.Button
    Friend WithEvents chkIgnoreCheck As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetAllDriverInfo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelDriver As System.Windows.Forms.Button
    Friend WithEvents txtDelDriverLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRemovePackagePath As System.Windows.Forms.Button
    Friend WithEvents btnRemovePackageName As System.Windows.Forms.Button
    Friend WithEvents txtPackagePath As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRecurse As System.Windows.Forms.CheckBox
    Friend WithEvents btnGetFeatures As System.Windows.Forms.Button
    Friend WithEvents btnEnableFeature As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFeatPackagePath As System.Windows.Forms.TextBox
    Friend WithEvents txtFeatPackageName As System.Windows.Forms.TextBox
    Friend WithEvents txtFeatureName As System.Windows.Forms.TextBox
    Friend WithEvents chkEnablePkgPath As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnablePkgName As System.Windows.Forms.CheckBox
    Friend WithEvents btnDisableFeature As System.Windows.Forms.Button
    Friend WithEvents CleanupImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UseOnlineModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnGetTargetEditions As System.Windows.Forms.Button
    Friend WithEvents btGetCurrentEdition As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnSetProdKey As System.Windows.Forms.Button
    Friend WithEvents txtProdKey As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSetEdition As System.Windows.Forms.Button
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents btnChooseUnAttend As System.Windows.Forms.Button
    Friend WithEvents txtUnattend As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnApplyUnattend As System.Windows.Forms.Button
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents btnGetApps As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnGetAppInfo As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCheckAppPatch As System.Windows.Forms.Button
    Friend WithEvents btnGetAppPatchInfo As System.Windows.Forms.Button
    Friend WithEvents btnGetAppPatches As System.Windows.Forms.Button
    Friend WithEvents txtPatchCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtProductCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnChooseMSP As System.Windows.Forms.Button
    Friend WithEvents txtPatchLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dlgOpenXML As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgOpenMSP As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents cmbCompression As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompression As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnCaptureDest As System.Windows.Forms.Button
    Friend WithEvents txtCaptureDest As System.Windows.Forms.TextBox
    Friend WithEvents txtCaptureSource As System.Windows.Forms.TextBox
    Friend WithEvents btnCaptureSrc As System.Windows.Forms.Button
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents cmbApplyIndex As System.Windows.Forms.ComboBox
    Friend WithEvents lblIndex As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents lblDest As System.Windows.Forms.Label
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents btnBrowseDest As System.Windows.Forms.Button
    Friend WithEvents txtApplyDest As System.Windows.Forms.TextBox
    Friend WithEvents txtxApplySource As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseSource As System.Windows.Forms.Button
    Friend WithEvents chkApplyVerify As System.Windows.Forms.CheckBox
    Friend WithEvents chkCaptureVerify As System.Windows.Forms.CheckBox
    Friend WithEvents chkMountReadOnly As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents cleanWinSxSapply As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents analyseApply As Button
    Friend WithEvents resetBase As CheckBox
    Friend WithEvents Label19 As Label
End Class
