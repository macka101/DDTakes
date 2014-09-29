Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Ribbon

Namespace Sage2CRM

    Partial Public Class MDIMain
        Inherits RibbonForm
        Public Shared Function TestReferralID() As String
            Return "59773"
        End Function

        Public Shared Function TestfurtherID() As String
            Return "171861"
        End Function

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Enable the form's title bar transparency
            'this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            ' Specify that the merge mechanism should be invoked when a child MDI form is maximized.
            '     Me.ribbonControl1.MdiMergeStyle = RibbonMdiMergeStyle.OnlyWhenMaximized

            'LoadBankDetails()
            Me.Text = String.Format("{0} Version {1}:{2}", Me.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

            Dim sCRMConn As String = GetSetting("CRMConnection")

            If sCRMConn = "" Then
                SetSetting("CRMConnection", "Data Source=alliance-sql;Initial Catalog=CRM;Integrated Security=True")
                sCRMConn = Sage2CRMSettings.GetSetting("CRMConnection")
            End If

            sExchConn = GetSetting("Exchquer")
            If sExchConn = "" Then
                SetSetting("Exchquer", "Data Source=ALLIANCE-MMOL\EXCHEQUER;Initial Catalog=Exchequer;Trusted_Connection=True")
                sExchConn = GetSetting("Exchquer")
            End If

            LoadDDDetails()
        End Sub
        Private Sub btnNew_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            LoadBankDetails()
        End Sub

        Private Sub LoadBankDetails()
            ' Create an MDI child form, containing a RibbonControl
            For Each ChildForm As Form In Me.MdiChildren
                If ChildForm.Tag = "Bank Details" Then
                    ChildForm.Select()
                    Exit Sub
                End If
            Next
            Dim child As New BankDetails()
            child.Tag = "Bank Details"
            child.Text = "Bank Details"

            child.MdiParent = Me
            child.Show()
        End Sub
        Private Sub LoadDDDetails()
            ' Create an MDI child form, containing a RibbonControl
            For Each ChildForm As Form In Me.MdiChildren
                If ChildForm.Tag = "DD Options" Then
                    ChildForm.Select()
                    Exit Sub
                End If
            Next
            Dim child As New DDPayments()
            child.Tag = "DD Options"
            child.Text = "DD Options"
            child.MdiParent = Me
            child.Show()
            child.Select()
        End Sub
        'Private Sub LoadMemberShipDetails()
        '    ' Create an MDI child form, containing a RibbonControl
        '    For Each ChildForm As Form In Me.MdiChildren
        '        If ChildForm.Tag = "Membership Invoices" Then
        '            ChildForm.Select()
        '            Exit Sub
        '        End If
        '    Next
        '    Dim child As New MembershipInvoices()
        '    child.Tag = "Membership Invoices"
        '    child.Text = "Membership Invoices"

        '    child.MdiParent = Me
        '    child.Show()
        'End Sub
        'Private Sub LoadInvoiceDetails()
        '    ' Create an MDI child form, containing a RibbonControl
        '    For Each ChildForm As Form In Me.MdiChildren
        '        If ChildForm.Tag = "Sage Invoices" Then
        '            ChildForm.Select()
        '            Exit Sub
        '        End If
        '    Next
        '    Dim child As New SageInvoices()
        '    child.Tag = "Sage Invoices"
        '    child.Text = "Sage Invoices"

        '    child.MdiParent = Me
        '    child.Show()
        'End Sub
        Private Sub LoadSBInvoiceEmails()
            ' Create an MDI child form, containing a RibbonControl
            For Each ChildForm As Form In Me.MdiChildren
                If ChildForm.Tag = "LoadSBInvoiceEmails" Then
                    ChildForm.Select()
                    Exit Sub
                End If
            Next
            Dim child As New SendSBInvoices()
            child.Tag = "LoadSBInvoiceEmails"
            child.Text = "Self Billing Invoices"

            child.MdiParent = Me
            child.Show()
        End Sub
        Private Sub btnBankDetails_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBankDetails.ItemClick
            LoadBankDetails()
        End Sub

        Private Sub btnDDFiles_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDDFiles.ItemClick
            LoadDDDetails()
        End Sub

        'Private Sub btnInvoices_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInvoices.ItemClick
        '    LoadInvoiceDetails()
        'End Sub

        Private Sub btnEditSettings_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditSettings.ItemClick
            Dim dSettings As New SystemSettings()
            dSettings.ShowDialog()
            dSettings.Dispose()
        End Sub

        Private Sub btnSendSBInvoices_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSendSBInvoices.ItemClick
            LoadSBInvoiceEmails()
        End Sub

        'Private Sub btnMembership_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        '    LoadMemberShipDetails()
        'End Sub
    End Class
End Namespace
