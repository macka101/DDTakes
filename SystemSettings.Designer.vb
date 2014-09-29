<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemSettings
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemSettings))
        Me.Vw_InvoiceTemplateAdapter = New InvoiceTableAdapters.vw_InvoiceTemplateAdapter()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.SystemSettingsConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.teTakePayment = New DevExpress.XtraEditors.TextEdit()
        Me.teMakePayment = New DevExpress.XtraEditors.TextEdit()
        Me.btnAdhocPath = New DevExpress.XtraEditors.SimpleButton()
        Me.tePaymentPath = New DevExpress.XtraEditors.TextEdit()
        Me.btnSagePath = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDDPath = New DevExpress.XtraEditors.SimpleButton()
        Me.teMailServer = New DevExpress.XtraEditors.TextEdit()
        Me.teAccountsConnection = New DevExpress.XtraEditors.TextEdit()
        Me.teSagePath = New DevExpress.XtraEditors.TextEdit()
        Me.teCRMConnection = New DevExpress.XtraEditors.TextEdit()
        Me.tePollingPath = New DevExpress.XtraEditors.TextEdit()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPLDue = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciTakePayment = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.SystemSettingsConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SystemSettingsConvertedLayout.SuspendLayout()
        CType(Me.teTakePayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMakePayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePaymentPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMailServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAccountsConnection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSagePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCRMConnection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePollingPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPLDue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciTakePayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vw_InvoiceTemplateAdapter
        '
        Me.Vw_InvoiceTemplateAdapter.ClearBeforeFill = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(536, 356)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(141, 22)
        Me.btnCancel.StyleController = Me.SystemSettingsConvertedLayout
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'SystemSettingsConvertedLayout
        '
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.teTakePayment)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.teMakePayment)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.btnAdhocPath)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.tePaymentPath)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.btnSagePath)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.btnDDPath)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.teMailServer)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.teAccountsConnection)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.teSagePath)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.teCRMConnection)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.tePollingPath)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.btnCancel)
        Me.SystemSettingsConvertedLayout.Controls.Add(Me.btnOk)
        Me.SystemSettingsConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SystemSettingsConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.SystemSettingsConvertedLayout.Name = "SystemSettingsConvertedLayout"
        Me.SystemSettingsConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(489, 183, 250, 350)
        Me.SystemSettingsConvertedLayout.Root = Me.LayoutControlGroup1
        Me.SystemSettingsConvertedLayout.Size = New System.Drawing.Size(689, 392)
        Me.SystemSettingsConvertedLayout.TabIndex = 12
        '
        'teTakePayment
        '
        Me.teTakePayment.Location = New System.Drawing.Point(407, 253)
        Me.teTakePayment.Name = "teTakePayment"
        Me.teTakePayment.Size = New System.Drawing.Size(175, 20)
        Me.teTakePayment.StyleController = Me.SystemSettingsConvertedLayout
        Me.teTakePayment.TabIndex = 16
        '
        'teMakePayment
        '
        Me.teMakePayment.Location = New System.Drawing.Point(126, 253)
        Me.teMakePayment.Name = "teMakePayment"
        Me.teMakePayment.Size = New System.Drawing.Size(175, 20)
        Me.teMakePayment.StyleController = Me.SystemSettingsConvertedLayout
        Me.teMakePayment.TabIndex = 15
        '
        'btnAdhocPath
        '
        Me.btnAdhocPath.Location = New System.Drawing.Point(569, 69)
        Me.btnAdhocPath.Name = "btnAdhocPath"
        Me.btnAdhocPath.Size = New System.Drawing.Size(96, 22)
        Me.btnAdhocPath.StyleController = Me.SystemSettingsConvertedLayout
        Me.btnAdhocPath.TabIndex = 14
        Me.btnAdhocPath.Text = "..."
        '
        'tePaymentPath
        '
        Me.tePaymentPath.Location = New System.Drawing.Point(126, 69)
        Me.tePaymentPath.Name = "tePaymentPath"
        Me.tePaymentPath.Size = New System.Drawing.Size(439, 20)
        Me.tePaymentPath.StyleController = Me.SystemSettingsConvertedLayout
        Me.tePaymentPath.TabIndex = 13
        '
        'btnSagePath
        '
        Me.btnSagePath.Location = New System.Drawing.Point(586, 229)
        Me.btnSagePath.Name = "btnSagePath"
        Me.btnSagePath.Size = New System.Drawing.Size(79, 22)
        Me.btnSagePath.StyleController = Me.SystemSettingsConvertedLayout
        Me.btnSagePath.TabIndex = 12
        Me.btnSagePath.Text = "..."
        '
        'btnDDPath
        '
        Me.btnDDPath.Location = New System.Drawing.Point(569, 43)
        Me.btnDDPath.Name = "btnDDPath"
        Me.btnDDPath.Size = New System.Drawing.Size(96, 22)
        Me.btnDDPath.StyleController = Me.SystemSettingsConvertedLayout
        Me.btnDDPath.TabIndex = 11
        Me.btnDDPath.Text = "..."
        '
        'teMailServer
        '
        Me.teMailServer.Location = New System.Drawing.Point(126, 320)
        Me.teMailServer.Name = "teMailServer"
        Me.teMailServer.Size = New System.Drawing.Size(539, 20)
        Me.teMailServer.StyleController = Me.SystemSettingsConvertedLayout
        Me.teMailServer.TabIndex = 6
        '
        'teAccountsConnection
        '
        Me.teAccountsConnection.Location = New System.Drawing.Point(126, 162)
        Me.teAccountsConnection.Name = "teAccountsConnection"
        Me.teAccountsConnection.Size = New System.Drawing.Size(539, 20)
        Me.teAccountsConnection.StyleController = Me.SystemSettingsConvertedLayout
        Me.teAccountsConnection.TabIndex = 10
        '
        'teSagePath
        '
        Me.teSagePath.Location = New System.Drawing.Point(126, 229)
        Me.teSagePath.Name = "teSagePath"
        Me.teSagePath.Size = New System.Drawing.Size(456, 20)
        Me.teSagePath.StyleController = Me.SystemSettingsConvertedLayout
        Me.teSagePath.TabIndex = 4
        '
        'teCRMConnection
        '
        Me.teCRMConnection.Location = New System.Drawing.Point(126, 138)
        Me.teCRMConnection.Name = "teCRMConnection"
        Me.teCRMConnection.Size = New System.Drawing.Size(539, 20)
        Me.teCRMConnection.StyleController = Me.SystemSettingsConvertedLayout
        Me.teCRMConnection.TabIndex = 8
        '
        'tePollingPath
        '
        Me.tePollingPath.Location = New System.Drawing.Point(126, 43)
        Me.tePollingPath.Name = "tePollingPath"
        Me.tePollingPath.Size = New System.Drawing.Size(439, 20)
        Me.tePollingPath.StyleController = Me.SystemSettingsConvertedLayout
        Me.tePollingPath.TabIndex = 6
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(405, 356)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(127, 22)
        Me.btnOk.StyleController = Me.SystemSettingsConvertedLayout
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Ok"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(689, 392)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnCancel
        Me.LayoutControlItem6.CustomizationFormText = "btnCancelitem"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(524, 344)
        Me.LayoutControlItem6.Name = "btnCancelitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(145, 28)
        Me.LayoutControlItem6.Text = "btnCancelitem"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnOk
        Me.LayoutControlItem7.CustomizationFormText = "btnOkitem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(393, 344)
        Me.LayoutControlItem7.Name = "btnOkitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(131, 28)
        Me.LayoutControlItem7.Text = "btnOkitem"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "BottomLine"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem11})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(669, 95)
        Me.LayoutControlGroup2.Text = "BottomLine"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tePollingPath
        Me.LayoutControlItem5.CustomizationFormText = "DD Polling Path"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "tePollingPathitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(545, 26)
        Me.LayoutControlItem5.Text = "DD Polling Path"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnDDPath
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(545, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.tePaymentPath
        Me.LayoutControlItem10.CustomizationFormText = "Payment Path"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(545, 26)
        Me.LayoutControlItem10.Text = "Payment Path"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnAdhocPath
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(545, 26)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Databases"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem2})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 95)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(669, 91)
        Me.LayoutControlGroup3.Text = "Databases"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.teCRMConnection
        Me.LayoutControlItem4.CustomizationFormText = "CRM Database"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "teCRMConnectionitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(645, 24)
        Me.LayoutControlItem4.Text = "CRM Database"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.teAccountsConnection
        Me.LayoutControlItem2.CustomizationFormText = "Accounts Database"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "teAccountsConnectionitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(645, 24)
        Me.LayoutControlItem2.Text = "Accounts Database"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Sage"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem9, Me.lciPLDue, Me.lciTakePayment})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(669, 91)
        Me.LayoutControlGroup4.Text = "Sage"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.teSagePath
        Me.LayoutControlItem3.CustomizationFormText = "Path to Sage "
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "teSagePathitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(562, 24)
        Me.LayoutControlItem3.Text = "Path to Sage "
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnSagePath
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(562, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(83, 48)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'lciPLDue
        '
        Me.lciPLDue.Control = Me.teMakePayment
        Me.lciPLDue.CustomizationFormText = "Make Payment After"
        Me.lciPLDue.Location = New System.Drawing.Point(0, 24)
        Me.lciPLDue.Name = "lciPLDue"
        Me.lciPLDue.Size = New System.Drawing.Size(281, 24)
        Me.lciPLDue.Text = "Make Payment After"
        Me.lciPLDue.TextSize = New System.Drawing.Size(98, 13)
        '
        'lciTakePayment
        '
        Me.lciTakePayment.Control = Me.teTakePayment
        Me.lciTakePayment.CustomizationFormText = "Take Payment After"
        Me.lciTakePayment.Location = New System.Drawing.Point(281, 24)
        Me.lciTakePayment.Name = "lciTakePayment"
        Me.lciTakePayment.Size = New System.Drawing.Size(281, 24)
        Me.lciTakePayment.Text = "Take Payment After"
        Me.lciTakePayment.TextSize = New System.Drawing.Size(98, 13)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Email"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 277)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(669, 67)
        Me.LayoutControlGroup5.Text = "Email"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.teMailServer
        Me.LayoutControlItem1.CustomizationFormText = "Mail Server"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "teMailServeritem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(645, 24)
        Me.LayoutControlItem1.Text = "Mail Server"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(98, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 344)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(393, 28)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'SystemSettings
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(689, 392)
        Me.Controls.Add(Me.SystemSettingsConvertedLayout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SystemSettings"
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        CType(Me.SystemSettingsConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SystemSettingsConvertedLayout.ResumeLayout(False)
        CType(Me.teTakePayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMakePayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePaymentPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMailServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAccountsConnection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSagePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCRMConnection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePollingPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPLDue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciTakePayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Vw_InvoiceTemplateAdapter As InvoiceTableAdapters.vw_InvoiceTemplateAdapter
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tePollingPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teCRMConnection As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teAccountsConnection As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teMailServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSagePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SystemSettingsConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnSagePath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDDPath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents btnAdhocPath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tePaymentPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents teTakePayment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teMakePayment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciPLDue As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciTakePayment As DevExpress.XtraLayout.LayoutControlItem
End Class
