<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DDPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DDPayments))
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
        Me.btnSelectData = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLoadPreviousPayments = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnUpdateSage = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BtnSendNotifications = New DevExpress.XtraBars.BarButtonItem()
        Me.beiDirectDebits = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnSaveToCSV = New DevExpress.XtraBars.BarButtonItem()
        Me.beiProgress2 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btnSelfBillingInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.beiProgress = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.bbiSelectSubmissions = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.beiSelectionDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.bbiSaveXLs = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMemberships = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPostMemberships = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.bsiProgressText = New DevExpress.XtraBars.BarStaticItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgProcess = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgNotifications = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgSubmissions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgMemberships = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RepositoryItemProgressBar3 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XpcDirectDebits = New DevExpress.Xpo.XPCollection(Me.components)
        Me.grdSageInvoices = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridDirectDebits = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridDebitInvoices = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDI_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldi_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldi_account = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldi_invoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldi_value = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldi_tran_number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldi_headernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpcDirectDebits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSageInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDirectDebits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDebitInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XpCollection1
        '
        Me.XpCollection1.LoadingEnabled = False
        Me.XpCollection1.ObjectType = GetType(DirectDebitInvoice)
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Images = Me.SharedImageCollection1
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnSelectData, Me.btnLoadPreviousPayments, Me.BtnUpdateSage, Me.BarButtonGroup1, Me.BtnSendNotifications, Me.beiDirectDebits, Me.btnSaveToCSV, Me.beiProgress2, Me.btnSelfBillingInvoice, Me.beiProgress, Me.bbiSelectSubmissions, Me.bbiSave, Me.beiSelectionDate, Me.bbiSaveXLs, Me.btnMemberships, Me.btnPostMemberships, Me.bbiSettings, Me.bsiProgressText})
        Me.RibbonControl.LargeImages = Me.SharedImageCollection1
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 34
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemDateEdit3, Me.RepositoryItemProgressBar1, Me.RepositoryItemProgressBar2, Me.RepositoryItemDateEdit4, Me.RepositoryItemProgressBar3})
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(810, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
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
        'btnSelectData
        '
        Me.btnSelectData.Caption = "Select Invoices"
        Me.btnSelectData.Id = 1
        Me.btnSelectData.ImageIndex = 12
        Me.btnSelectData.LargeImageIndex = 12
        Me.btnSelectData.Name = "btnSelectData"
        '
        'btnLoadPreviousPayments
        '
        Me.btnLoadPreviousPayments.Caption = "Load Payments"
        Me.btnLoadPreviousPayments.Id = 4
        Me.btnLoadPreviousPayments.Name = "btnLoadPreviousPayments"
        '
        'BtnUpdateSage
        '
        Me.BtnUpdateSage.Caption = "Update Sage"
        Me.BtnUpdateSage.Id = 5
        Me.BtnUpdateSage.ImageIndex = 17
        Me.BtnUpdateSage.LargeImageIndex = 17
        Me.BtnUpdateSage.Name = "BtnUpdateSage"
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "BarButtonGroup1"
        Me.BarButtonGroup1.Id = 7
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        '
        'BtnSendNotifications
        '
        Me.BtnSendNotifications.Caption = "Send Notifications"
        Me.BtnSendNotifications.Id = 8
        Me.BtnSendNotifications.ImageIndex = 22
        Me.BtnSendNotifications.LargeImageIndex = 22
        Me.BtnSendNotifications.Name = "BtnSendNotifications"
        '
        'beiDirectDebits
        '
        Me.beiDirectDebits.Caption = "Load Debits"
        Me.beiDirectDebits.Edit = Me.RepositoryItemGridLookUpEdit1
        Me.beiDirectDebits.Id = 12
        Me.beiDirectDebits.Name = "beiDirectDebits"
        Me.beiDirectDebits.Width = 100
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'btnSaveToCSV
        '
        Me.btnSaveToCSV.Caption = "Save To Bottomline"
        Me.btnSaveToCSV.Id = 13
        Me.btnSaveToCSV.ImageIndex = 23
        Me.btnSaveToCSV.LargeImageIndex = 23
        Me.btnSaveToCSV.Name = "btnSaveToCSV"
        '
        'beiProgress2
        '
        Me.beiProgress2.Caption = "Status"
        Me.beiProgress2.Edit = Me.RepositoryItemDateEdit3
        Me.beiProgress2.Id = 14
        Me.beiProgress2.Name = "beiProgress2"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        Me.RepositoryItemDateEdit3.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'btnSelfBillingInvoice
        '
        Me.btnSelfBillingInvoice.Caption = "View Self Billing Invoice"
        Me.btnSelfBillingInvoice.Id = 15
        Me.btnSelfBillingInvoice.ImageIndex = 22
        Me.btnSelfBillingInvoice.LargeImageIndex = 22
        Me.btnSelfBillingInvoice.Name = "btnSelfBillingInvoice"
        '
        'beiProgress
        '
        Me.beiProgress.Caption = "Status"
        Me.beiProgress.Edit = Me.RepositoryItemProgressBar2
        Me.beiProgress.Id = 18
        Me.beiProgress.Name = "beiProgress"
        '
        'RepositoryItemProgressBar2
        '
        Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
        '
        'bbiSelectSubmissions
        '
        Me.bbiSelectSubmissions.Caption = "Select Submissions"
        Me.bbiSelectSubmissions.Id = 21
        Me.bbiSelectSubmissions.ImageIndex = 12
        Me.bbiSelectSubmissions.LargeImageIndex = 12
        Me.bbiSelectSubmissions.Name = "bbiSelectSubmissions"
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "BarButtonItem1"
        Me.bbiSave.Id = 22
        Me.bbiSave.Name = "bbiSave"
        '
        'beiSelectionDate
        '
        Me.beiSelectionDate.Caption = "Due Date"
        Me.beiSelectionDate.Edit = Me.RepositoryItemDateEdit4
        Me.beiSelectionDate.Id = 23
        Me.beiSelectionDate.Name = "beiSelectionDate"
        Me.beiSelectionDate.Width = 100
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        Me.RepositoryItemDateEdit4.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'bbiSaveXLs
        '
        Me.bbiSaveXLs.Caption = "Save XLs"
        Me.bbiSaveXLs.Id = 24
        Me.bbiSaveXLs.ImageIndex = 10
        Me.bbiSaveXLs.LargeImageIndex = 10
        Me.bbiSaveXLs.Name = "bbiSaveXLs"
        '
        'btnMemberships
        '
        Me.btnMemberships.Caption = "Select Memberships"
        Me.btnMemberships.Id = 26
        Me.btnMemberships.ImageIndex = 12
        Me.btnMemberships.LargeImageIndex = 12
        Me.btnMemberships.Name = "btnMemberships"
        '
        'btnPostMemberships
        '
        Me.btnPostMemberships.Caption = "Post Memberships"
        Me.btnPostMemberships.Id = 27
        Me.btnPostMemberships.ImageIndex = 17
        Me.btnPostMemberships.LargeImageIndex = 17
        Me.btnPostMemberships.Name = "btnPostMemberships"
        '
        'bbiSettings
        '
        Me.bbiSettings.Caption = "Settings"
        Me.bbiSettings.Id = 30
        Me.bbiSettings.ImageIndex = 23
        Me.bbiSettings.LargeImageIndex = 23
        Me.bbiSettings.Name = "bbiSettings"
        '
        'bsiProgressText
        '
        Me.bsiProgressText.Caption = "Records (0)"
        Me.bsiProgressText.Id = 33
        Me.bsiProgressText.Name = "bsiProgressText"
        Me.bsiProgressText.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgProcess, Me.rpgNotifications, Me.rpgSubmissions, Me.rpgMemberships, Me.rpgOptions})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "DD Options"
        '
        'rpgProcess
        '
        Me.rpgProcess.ItemLinks.Add(Me.beiSelectionDate)
        Me.rpgProcess.ItemLinks.Add(Me.bbiSaveXLs)
        Me.rpgProcess.MergeOrder = 2
        Me.rpgProcess.Name = "rpgProcess"
        Me.rpgProcess.Text = "Selection"
        '
        'rpgNotifications
        '
        Me.rpgNotifications.ItemLinks.Add(Me.btnSelectData)
        Me.rpgNotifications.ItemLinks.Add(Me.BtnSendNotifications)
        Me.rpgNotifications.MergeOrder = 3
        Me.rpgNotifications.Name = "rpgNotifications"
        Me.rpgNotifications.Text = "Notifications"
        '
        'rpgSubmissions
        '
        Me.rpgSubmissions.ItemLinks.Add(Me.bbiSelectSubmissions)
        Me.rpgSubmissions.ItemLinks.Add(Me.btnSaveToCSV)
        Me.rpgSubmissions.MergeOrder = 4
        Me.rpgSubmissions.Name = "rpgSubmissions"
        Me.rpgSubmissions.Text = "Submissions"
        '
        'rpgMemberships
        '
        Me.rpgMemberships.ItemLinks.Add(Me.btnMemberships)
        Me.rpgMemberships.ItemLinks.Add(Me.btnPostMemberships)
        Me.rpgMemberships.Name = "rpgMemberships"
        Me.rpgMemberships.Text = "Memberships"
        '
        'rpgOptions
        '
        Me.rpgOptions.ItemLinks.Add(Me.bbiSettings)
        Me.rpgOptions.Name = "rpgOptions"
        Me.rpgOptions.Text = "Options"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'RepositoryItemProgressBar3
        '
        Me.RepositoryItemProgressBar3.Name = "RepositoryItemProgressBar3"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.bsiProgressText)
        Me.RibbonStatusBar.ItemLinks.Add(Me.beiProgress)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(810, 31)
        '
        'XpcDirectDebits
        '
        Me.XpcDirectDebits.LoadingEnabled = False
        Me.XpcDirectDebits.ObjectType = GetType(DirectDebitInvoice)
        '
        'grdSageInvoices
        '
        Me.grdSageInvoices.Location = New System.Drawing.Point(0, 144)
        Me.grdSageInvoices.MainView = Me.GridView1
        Me.grdSageInvoices.MenuManager = Me.RibbonControl
        Me.grdSageInvoices.Name = "grdSageInvoices"
        Me.grdSageInvoices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdSageInvoices.ShowOnlyPredefinedDetails = True
        Me.grdSageInvoices.Size = New System.Drawing.Size(333, 274)
        Me.grdSageInvoices.TabIndex = 3
        Me.grdSageInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.grdSageInvoices.Visible = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdSageInvoices
        Me.GridView1.Name = "GridView1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridDirectDebits
        '
        Me.GridDirectDebits.Location = New System.Drawing.Point(278, 163)
        Me.GridDirectDebits.MainView = Me.GridView2
        Me.GridDirectDebits.MenuManager = Me.RibbonControl
        Me.GridDirectDebits.Name = "GridDirectDebits"
        Me.GridDirectDebits.ShowOnlyPredefinedDetails = True
        Me.GridDirectDebits.Size = New System.Drawing.Size(333, 274)
        Me.GridDirectDebits.TabIndex = 6
        Me.GridDirectDebits.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.GridDirectDebits.Visible = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridDirectDebits
        Me.GridView2.Name = "GridView2"
        '
        'GridDebitInvoices
        '
        Me.GridDebitInvoices.DataSource = Me.XpCollection1
        Me.GridDebitInvoices.Location = New System.Drawing.Point(511, 150)
        Me.GridDebitInvoices.MainView = Me.GridView3
        Me.GridDebitInvoices.MenuManager = Me.RibbonControl
        Me.GridDebitInvoices.Name = "GridDebitInvoices"
        Me.GridDebitInvoices.ShowOnlyPredefinedDetails = True
        Me.GridDebitInvoices.Size = New System.Drawing.Size(333, 274)
        Me.GridDebitInvoices.TabIndex = 21
        Me.GridDebitInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        Me.GridDebitInvoices.Visible = False
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDI_id, Me.GridColumn1, Me.GridColumn2, Me.coldi_date, Me.coldi_account, Me.coldi_invoice, Me.coldi_value, Me.coldi_tran_number, Me.coldi_headernumber})
        Me.GridView3.GridControl = Me.GridDebitInvoices
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "di_value", Nothing, "")})
        Me.GridView3.Name = "GridView3"
        '
        'colDI_id
        '
        Me.colDI_id.FieldName = "DI_id"
        Me.colDI_id.Name = "colDI_id"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "di_DirectDebitDetails!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "di_DirectDebitDetails!Key"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'coldi_date
        '
        Me.coldi_date.FieldName = "di_date"
        Me.coldi_date.Name = "coldi_date"
        Me.coldi_date.Visible = True
        Me.coldi_date.VisibleIndex = 2
        '
        'coldi_account
        '
        Me.coldi_account.FieldName = "di_account"
        Me.coldi_account.Name = "coldi_account"
        Me.coldi_account.Visible = True
        Me.coldi_account.VisibleIndex = 1
        '
        'coldi_invoice
        '
        Me.coldi_invoice.FieldName = "di_invoice"
        Me.coldi_invoice.Name = "coldi_invoice"
        Me.coldi_invoice.Visible = True
        Me.coldi_invoice.VisibleIndex = 3
        '
        'coldi_value
        '
        Me.coldi_value.FieldName = "di_value"
        Me.coldi_value.Name = "coldi_value"
        Me.coldi_value.Visible = True
        Me.coldi_value.VisibleIndex = 4
        '
        'coldi_tran_number
        '
        Me.coldi_tran_number.FieldName = "di_tran_number"
        Me.coldi_tran_number.Name = "coldi_tran_number"
        '
        'coldi_headernumber
        '
        Me.coldi_headernumber.FieldName = "di_headernumber"
        Me.coldi_headernumber.Name = "coldi_headernumber"
        '
        'DDPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 449)
        Me.Controls.Add(Me.GridDebitInvoices)
        Me.Controls.Add(Me.GridDirectDebits)
        Me.Controls.Add(Me.grdSageInvoices)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DDPayments"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "ExtractDDPayments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpcDirectDebits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSageInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDirectDebits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDebitInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnSelectData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdSageInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SharedImageCollection1 As DevExpress.Utils.SharedImageCollection
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnLoadPreviousPayments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnUpdateSage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents rpgProcess As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridDirectDebits As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnSendNotifications As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents XpcDirectDebits As DevExpress.Xpo.XPCollection
    Friend WithEvents beiDirectDebits As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSaveToCSV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents beiProgress2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnSelfBillingInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents beiProgress As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents GridDebitInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDI_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldi_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldi_account As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldi_invoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldi_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldi_tran_number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldi_headernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bbiSelectSubmissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgNotifications As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgSubmissions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents beiSelectionDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents bbiSaveXLs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMemberships As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPostMemberships As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgMemberships As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsiProgressText As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemProgressBar3 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar


End Class
