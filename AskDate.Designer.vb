<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskDate
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
        Me.dteDate = New DevExpress.XtraEditors.DateEdit()
        Me.Vw_InvoiceTemplateAdapter = New InvoiceTableAdapters.vw_InvoiceTemplateAdapter()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lblText = New DevExpress.XtraEditors.LabelControl()
        CType(Me.dteDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dteDate
        '
        Me.dteDate.EditValue = Nothing
        Me.dteDate.Location = New System.Drawing.Point(181, 16)
        Me.dteDate.Name = "dteDate"
        Me.dteDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dteDate.Size = New System.Drawing.Size(100, 20)
        Me.dteDate.TabIndex = 0
        '
        'Vw_InvoiceTemplateAdapter
        '
        Me.Vw_InvoiceTemplateAdapter.ClearBeforeFill = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(127, 56)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(220, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'lblText
        '
        Me.lblText.Location = New System.Drawing.Point(26, 19)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(66, 13)
        Me.lblText.TabIndex = 3
        Me.lblText.Text = "LabelControl1"
        '
        'AskDate
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(307, 91)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dteDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AskDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Date"
        CType(Me.dteDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dteDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Vw_InvoiceTemplateAdapter As InvoiceTableAdapters.vw_InvoiceTemplateAdapter
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblText As DevExpress.XtraEditors.LabelControl
End Class
