<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankDetails
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BankDetails))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveTOXLS = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUpdateSage = New DevExpress.XtraBars.BarButtonItem()
        Me.BeiProgress = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.btnSaveTOCSV = New DevExpress.XtraBars.BarButtonItem()
        Me.chkNewOnly = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgProcess = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.grdSageAccounts = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSageAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Images = Me.SharedImageCollection1
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.btnRefresh, Me.btnSaveTOXLS, Me.btnUpdateSage, Me.BeiProgress, Me.btnSaveTOCSV, Me.chkNewOnly})
        Me.ribbonControl1.LargeImages = Me.SharedImageCollection1
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 16
        Me.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemProgressBar1, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.ribbonControl1.Size = New System.Drawing.Size(442, 144)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar
        '
        'SharedImageCollection1
        '
        '
        '
        '
        Me.SharedImageCollection1.ImageSource.ImageStream = CType(resources.GetObject("SharedImageCollection1.ImageSource.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(0, "add_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(1, "book_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(2, "cancel_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(3, "close_b_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(4, "copy_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(5, "delete_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(6, "paste_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(7, "printer_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(8, "stop_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(9, "xsl_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(10, "xsl_save_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(11, "paypal_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(12, "refresh_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(13, "bank_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(14, "accounting_next_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(15, "loan_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(16, "calendar_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(17, "program_icon.gif")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(18, "order_ok_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(19, "order_refresh_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(20, "order_remove_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(21, "invoice_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(22, "invoice_next_32.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(23, "software_development_32.png")
        Me.SharedImageCollection1.ParentControl = Me
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 5
        Me.btnRefresh.ImageIndex = 12
        Me.btnRefresh.LargeImageIndex = 12
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnSaveTOXLS
        '
        Me.btnSaveTOXLS.Caption = "Save to XLS"
        Me.btnSaveTOXLS.Id = 6
        Me.btnSaveTOXLS.ImageIndex = 10
        Me.btnSaveTOXLS.LargeImageIndex = 10
        Me.btnSaveTOXLS.Name = "btnSaveTOXLS"
        '
        'btnUpdateSage
        '
        Me.btnUpdateSage.Caption = "Update Sage"
        Me.btnUpdateSage.Id = 7
        Me.btnUpdateSage.ImageIndex = 17
        Me.btnUpdateSage.LargeImageIndex = 17
        Me.btnUpdateSage.Name = "btnUpdateSage"
        '
        'BeiProgress
        '
        Me.BeiProgress.Caption = "Status"
        Me.BeiProgress.Edit = Me.RepositoryItemProgressBar1
        Me.BeiProgress.Id = 10
        Me.BeiProgress.Name = "BeiProgress"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'btnSaveTOCSV
        '
        Me.btnSaveTOCSV.Caption = "Save TO DD"
        Me.btnSaveTOCSV.Id = 11
        Me.btnSaveTOCSV.ImageIndex = 23
        Me.btnSaveTOCSV.LargeImageIndex = 23
        Me.btnSaveTOCSV.Name = "btnSaveTOCSV"
        '
        'chkNewOnly
        '
        Me.chkNewOnly.Caption = "New Only"
        Me.chkNewOnly.Edit = Me.RepositoryItemCheckEdit2
        Me.chkNewOnly.Id = 15
        Me.chkNewOnly.ImageIndex = 21
        Me.chkNewOnly.LargeImageIndex = 21
        Me.chkNewOnly.Name = "chkNewOnly"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgProcess})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Sage2CRM"
        '
        'rpgProcess
        '
        Me.rpgProcess.ItemLinks.Add(Me.chkNewOnly)
        Me.rpgProcess.ItemLinks.Add(Me.btnRefresh)
        Me.rpgProcess.ItemLinks.Add(Me.btnSaveTOCSV)
        Me.rpgProcess.ItemLinks.Add(Me.btnSaveTOXLS)
        Me.rpgProcess.ItemLinks.Add(Me.btnUpdateSage)
        Me.rpgProcess.MergeOrder = 2
        Me.rpgProcess.Name = "rpgProcess"
        Me.rpgProcess.Text = "Process"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BeiProgress)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'grdSageAccounts
        '
        Me.grdSageAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSageAccounts.Location = New System.Drawing.Point(0, 144)
        Me.grdSageAccounts.MainView = Me.GridView1
        Me.grdSageAccounts.Name = "grdSageAccounts"
        Me.grdSageAccounts.Size = New System.Drawing.Size(442, 274)
        Me.grdSageAccounts.TabIndex = 2
        Me.grdSageAccounts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdSageAccounts
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'BankDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 449)
        Me.Controls.Add(Me.grdSageAccounts)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "BankDetails"
        Me.Ribbon = Me.ribbonControl1
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "BankDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSageAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgProcess As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents grdSageAccounts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SharedImageCollection1 As DevExpress.Utils.SharedImageCollection
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveTOXLS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUpdateSage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BeiProgress As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnSaveTOCSV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkNewOnly As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit


End Class
