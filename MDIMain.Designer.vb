' Developer Express Code Central Example:
' How to: Merge Ribbon controls
' 
' This example demonstrates the merging mechanism for RibbonControls in action.
' The main and child MDI forms contain RibbonControls. The child form's
' RibbonControl is merged into the main form's RibbonControl when the child form
' is maximized.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1917

Imports Microsoft.VisualBasic
Imports System
Namespace Sage2CRM
    Partial Public Class MDIMain
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.SplashScreen1), True, True)
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.SharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
            Me.btnBankDetails = New DevExpress.XtraBars.BarButtonItem()
            Me.btnDDFiles = New DevExpress.XtraBars.BarButtonItem()
            Me.btnInvoices = New DevExpress.XtraBars.BarButtonItem()
            Me.btnEditSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.btnSendSBInvoices = New DevExpress.XtraBars.BarButtonItem()
            Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.rpgMain = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgEmails = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgSettings = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ApplicationIcon = Global.Resources.Full_Logo_48x48
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Images = Me.SharedImageCollection1
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.btnBankDetails, Me.btnDDFiles, Me.btnInvoices, Me.btnEditSettings, Me.btnSendSBInvoices, Me.BarButtonItem2})
            Me.ribbonControl1.LargeImages = Me.SharedImageCollection1
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 12
            Me.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(687, 144)
            Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
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
            'btnBankDetails
            '
            Me.btnBankDetails.Caption = "Bank Details"
            Me.btnBankDetails.Id = 4
            Me.btnBankDetails.ImageIndex = 13
            Me.btnBankDetails.LargeImageIndex = 13
            Me.btnBankDetails.Name = "btnBankDetails"
            Me.btnBankDetails.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '
            'btnDDFiles
            '
            Me.btnDDFiles.Caption = "Direct Debits"
            Me.btnDDFiles.Id = 5
            Me.btnDDFiles.ImageIndex = 15
            Me.btnDDFiles.LargeImageIndex = 15
            Me.btnDDFiles.Name = "btnDDFiles"
            '
            'btnInvoices
            '
            Me.btnInvoices.Caption = "Post Invoices"
            Me.btnInvoices.Id = 6
            Me.btnInvoices.ImageIndex = 14
            Me.btnInvoices.LargeImageIndex = 14
            Me.btnInvoices.Name = "btnInvoices"
            Me.btnInvoices.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '
            'btnEditSettings
            '
            Me.btnEditSettings.Caption = "Edit Settings"
            Me.btnEditSettings.Id = 8
            Me.btnEditSettings.ImageIndex = 23
            Me.btnEditSettings.LargeImageIndex = 23
            Me.btnEditSettings.Name = "btnEditSettings"
            '
            'btnSendSBInvoices
            '
            Me.btnSendSBInvoices.Caption = "Email Self Billing Invoices"
            Me.btnSendSBInvoices.Id = 9
            Me.btnSendSBInvoices.ImageIndex = 22
            Me.btnSendSBInvoices.LargeImageIndex = 22
            Me.btnSendSBInvoices.Name = "btnSendSBInvoices"
            Me.btnSendSBInvoices.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '
            'BarButtonItem2
            '
            Me.BarButtonItem2.Caption = "Email Invoices"
            Me.BarButtonItem2.Id = 10
            Me.BarButtonItem2.ImageIndex = 21
            Me.BarButtonItem2.LargeImageIndex = 21
            Me.BarButtonItem2.Name = "BarButtonItem2"
            Me.BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '
            'ribbonPage1
            '
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgMain, Me.rpgEmails, Me.rpgSettings})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Sage2CRM"
            '
            'rpgMain
            '
            Me.rpgMain.ItemLinks.Add(Me.btnBankDetails)
            Me.rpgMain.ItemLinks.Add(Me.btnInvoices)
            Me.rpgMain.ItemLinks.Add(Me.btnDDFiles)
            Me.rpgMain.MergeOrder = 1
            Me.rpgMain.Name = "rpgMain"
            Me.rpgMain.Text = "Main"
            Me.rpgMain.Visible = False
            '
            'rpgEmails
            '
            Me.rpgEmails.ItemLinks.Add(Me.btnSendSBInvoices)
            Me.rpgEmails.ItemLinks.Add(Me.BarButtonItem2)
            Me.rpgEmails.MergeOrder = 2
            Me.rpgEmails.Name = "rpgEmails"
            Me.rpgEmails.Text = "Emails"
            Me.rpgEmails.Visible = False
            '
            'rpgSettings
            '
            Me.rpgSettings.ItemLinks.Add(Me.btnEditSettings)
            Me.rpgSettings.MergeOrder = 10
            Me.rpgSettings.Name = "rpgSettings"
            Me.rpgSettings.Text = "Settings"
            '
            'RibbonStatusBar1
            '
            Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 466)
            Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
            Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.RibbonStatusBar1.Size = New System.Drawing.Size(687, 31)
            '
            'MDIMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(687, 497)
            Me.Controls.Add(Me.RibbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "MDIMain"
            Me.Ribbon = Me.ribbonControl1
            Me.StatusBar = Me.RibbonStatusBar1
            Me.Text = "Sage2CRM"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private rpgMain As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents SharedImageCollection1 As DevExpress.Utils.SharedImageCollection
        Friend WithEvents btnBankDetails As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btnDDFiles As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btnInvoices As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Friend WithEvents btnEditSettings As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents rpgSettings As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents btnSendSBInvoices As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents rpgEmails As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    End Class
End Namespace

