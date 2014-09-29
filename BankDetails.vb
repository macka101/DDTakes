Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Diagnostics

Public Class BankDetails
    Dim ds As New DataSet

    Private Sub GetAccounts()
        Dim sSql As String = "SELECT * from vw_DDAccounts where isnull(pers_ddsaved, 'N') in ('N','U')"
        If chkNewOnly.EditValue = False Then
            sSql = "SELECT * from vw_DDAccounts"
        End If
        Dim cn As New SqlConnection(My.Settings.CRMConnection)
        cn.Open()
        ds.Reset()
        Dim dataAdapter As New SqlDataAdapter(sSql, cn)
        dataAdapter.Fill(ds)
        Me.grdSageAccounts.DataBindings.Clear()
        Me.grdSageAccounts.DataSource = Nothing
        Me.grdSageAccounts.DataSource = ds.Tables(0)
        Me.grdSageAccounts.Refresh()
    End Sub
    Private Sub SetupGrid()
        GridView1.Columns("Reference").Caption = "Reference"
        GridView1.Columns("Reference").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        GridView1.Columns("FirstName").Visible = False
        GridView1.Columns("LastName").Caption = "Last Name"
        GridView1.Columns("Address1").Caption = "Address 1"
        GridView1.Columns("Address2").Caption = "Address 2"
        GridView1.Columns("Address3").Caption = "Address 3"
        GridView1.Columns("Address4").Caption = "Address 4"
        GridView1.Columns("City").Caption = "City"
        GridView1.Columns("Postcode").Caption = "Postcode"
        GridView1.Columns("bankaccountname").Caption = "Direct Debit Account Name"
        GridView1.Columns("PlanType").Caption = "Plan Type"
        GridView1.Columns("OnlyAdHocs").Caption = "Only Ad-Hocs"
        GridView1.Columns("PlanReference").Caption = "Plan Reference"
        GridView1.Columns("StartDate").Caption = "Start Date"
        GridView1.Columns("BankSortCode").Caption = "Destination Sort Code"
        GridView1.Columns("bankaccno").Caption = "Destination Account Number"
        GridView1.Columns("pers_ddsaved").Visible = False

    End Sub

    Private Sub BankDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BeiProgress.AutoFillWidth = True
        chkNewOnly.EditValue = True
        LoadData()
    End Sub


    Private Sub btnSyncSage_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'If MessageBox("Update Sage Accounts and Bank details From CRM", vbOKCancel, "Syncronize") = vbOK Then
        '    SyncSageAccounts()
        'End If
    End Sub
    Private Sub LoadData()
        GetAccounts()
        SetupGrid()
    End Sub

    Private Sub btRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        LoadData()
    End Sub

    Private Sub btnSaveTOXLS_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveTOXLS.ItemClick

        Dim sfd As SaveFileDialog = New SaveFileDialog()

        sfd.Title = "Save"
        sfd.DefaultExt = "csv"
        sfd.Filter = "*.csv|*.csv"

        sfd.FileName = "DD Accounts"

        If sfd.ShowDialog() = DialogResult.OK Then

            Dim txtoptions As DevExpress.XtraPrinting.TextExportOptions = New DevExpress.XtraPrinting.TextExportOptions()
            txtoptions.Separator = ","
            txtoptions.QuoteStringsWithSeparators = True
            GridView1.ExportToText(sfd.FileName, txtoptions)

            Dim ps As New ProcessStartInfo
            ps.UseShellExecute = True
            ps.FileName = sfd.FileName
            Process.Start(ps)
        End If
    End Sub

    Private Sub btnRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        GetAccounts()
    End Sub

    Private Sub btnSaveTOCSV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim sFile As String = String.Format("{0}\DDAccounts.csv", My.Settings.PollingPath.Trim)

        Dim txtoptions As DevExpress.XtraPrinting.TextExportOptions = New DevExpress.XtraPrinting.TextExportOptions()
        txtoptions.Separator = ","
        txtoptions.QuoteStringsWithSeparators = True

        GridView1.ExportToText(sFile, txtoptions)

    End Sub

    Private Sub btnSaveTODD(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveTOCSV.ItemClick
        Dim sFile As String = String.Format("{0}\DDAccounts.csv", Sage2CRMSettings.GetSetting("DDPOLLINGPATH"))
        Dim txtoptions As DevExpress.XtraPrinting.TextExportOptions = New DevExpress.XtraPrinting.TextExportOptions()
        txtoptions.Separator = ","
        txtoptions.QuoteStringsWithSeparators = True
        GridView1.OptionsPrint.PrintHeader = False
        GridView1.ExportToText(sFile, txtoptions)
        GridView1.OptionsPrint.PrintHeader = True
        Dim cn As New SqlConnection(My.Settings.CRMConnection)


        Dim sCmd As New SqlCommand
        cn.Open()
        '        sCmd = New SqlCommand("Update person set pers_ddsaved = 'Y' , pers_ddsavedon = getdate() where pers_ddsaved is null  and pers_ddsavedon is null ", cn)
        Dim iRow As Integer = 0
        Dim orow As DataRow

        While iRow < GridView1.RowCount
            orow = GridView1.GetDataRow(iRow)
        Dim sGMC As String = CStr(orow.Item("Reference").ToString.Trim)
            sCmd = New SqlCommand("Update person set pers_ddsaved = 'Y' , pers_ddsavedon = getdate() where pers_gmcno = '" & sGMC & "'", cn)
            sCmd.ExecuteNonQuery()
            iRow = iRow + 1
        End While
        cn.Close()
    End Sub

End Class