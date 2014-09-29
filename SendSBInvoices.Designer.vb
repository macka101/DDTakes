<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendSBInvoices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendSBInvoices))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSend = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSelect = New DevExpress.XtraBars.BarButtonItem()
        Me.rpProcess = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgProcess = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.grdInvoices = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnSend, Me.btnSelect})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpProcess})
        Me.RibbonControl.Size = New System.Drawing.Size(442, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnSend
        '
        Me.btnSend.Caption = "Send"
        Me.btnSend.Id = 1
        Me.btnSend.ImageIndex = 24
        Me.btnSend.Name = "btnSend"
        '
        'btnSelect
        '
        Me.btnSelect.Caption = "Select"
        Me.btnSelect.Id = 2
        Me.btnSelect.ImageIndex = 12
        Me.btnSelect.Name = "btnSelect"
        '
        'rpProcess
        '
        Me.rpProcess.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgProcess})
        Me.rpProcess.MergeOrder = 2
        Me.rpProcess.Name = "rpProcess"
        Me.rpProcess.Text = "Sage2CRM"
        '
        'rpgProcess
        '
        Me.rpgProcess.ItemLinks.Add(Me.btnSelect)
        Me.rpgProcess.ItemLinks.Add(Me.btnSend)
        Me.rpgProcess.MergeOrder = 3
        Me.rpgProcess.Name = "rpgProcess"
        Me.rpgProcess.Text = "Process"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'grdInvoices
        '
        Me.grdInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdInvoices.Location = New System.Drawing.Point(0, 144)
        Me.grdInvoices.MainView = Me.GridView1
        Me.grdInvoices.MenuManager = Me.RibbonControl
        Me.grdInvoices.Name = "grdInvoices"
        Me.grdInvoices.ShowOnlyPredefinedDetails = True
        Me.grdInvoices.Size = New System.Drawing.Size(442, 274)
        Me.grdInvoices.TabIndex = 4
        Me.grdInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdInvoices
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
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
        'SendSBInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 449)
        Me.Controls.Add(Me.grdInvoices)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "SendSBInvoices"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Self Billing Invoices"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnSend As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grdInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SharedImageCollection1 As DevExpress.Utils.SharedImageCollection
    Friend WithEvents rpProcess As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgProcess As DevExpress.XtraBars.Ribbon.RibbonPageGroup


End Class
