Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports System.Windows.Forms
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports System.Diagnostics
Imports System.Net.Mail
Imports System


Imports DevExpress.XtraReports

Public Class DDPayments
    Enum SelectType
        Notification = 0
        DDSubmission = 1
    End Enum

    Enum InvoiceProcess
        DD = 0
        PRU = 1
    End Enum

    Dim bCurrentProcess As InvoiceProcess = InvoiceProcess.DD

    Dim duedate As Date
    Dim paydate As Date
    Dim dsEmailCSv As DataSet
    Dim ds As New DataSet
    Dim Session1 As Session = New Session()
    Dim ThisBatch As DirectDebitHeader


    Dim insMail As MailMessage
    Public sPath As String = My.Application.Info.DirectoryPath
    Dim bDoNotEmail As Boolean = True
    Private Sub GetInvoicesFromCrm(ByVal pOption As SelectType)
        duedate = beiSelectionDate.EditValue
        paydate = beiSelectionDate.EditValue
        ds.Clear()
        'Dim sCrmFieldlist As String = "ID, GMCNo as ACCOUNT_REF, furt_invnumber as INV_REF, isnull(furt_invamount, 0) - isnull(furt_pitotal,0) as ConsultantBalance"
        'sCrmFieldlist = sCrmFieldlist & ""
        'Dim sCRMSql As String = "SELECT " & sCrmFieldlist & " from vw_FurtherSageLinkProcess2 "

        Dim sCRMSql As String = "SELECT ThRemitNo, ALLI03.[DOCUMENT].thAcCode, isnull(vConsultant.pers_ddplanref,vConsultant.pers_gmcno) as ddPlanRef, vFurther_1.furt_invnumber AS INV_REF"
        sCRMSql = sCRMSql & ",ALLI03.[DOCUMENT].thUserField1 as DETAILS, ALLI03.[DOCUMENT].thDueDate as DUE_DATE, furt_date as DATE"
        'sCRMSql = sCRMSql & ",ISNULL(vFurther_1.furt_invamount, 0) - ISNULL(vFurther_1.furt_PITotal, 0) AS ConsultantBalance"
        sCRMSql = sCRMSql & ",ISNULL(vFurther_1.furt_invamount, 0)  AS ConsultantBalance"
        sCRMSql = sCRMSql & ",ALLI03.[DOCUMENT].thNetValue AS OUTStanding"
        sCRMSql = sCRMSql & ",vFurther_1.furt_FurtherID AS Id,ALLI03.[DOCUMENT].thOurRef "
        sCRMSql = sCRMSql & "FROM ALLI03.[DOCUMENT] INNER JOIN "
        sCRMSql = sCRMSql & "CRM.CRM.dbo.vFurther AS vFurther_1 ON ALLI03.[DOCUMENT].thYourRef = vFurther_1.furt_invnumber INNER JOIN "
        sCRMSql = sCRMSql & "CRM.CRM.dbo.vOpportunity AS Oppo ON vFurther_1.furt_OpportunityId = Oppo.Oppo_OpportunityId INNER JOIN "
        sCRMSql = sCRMSql & "CRM.CRM.dbo.vSummaryPerson AS vPatient_1 ON vFurther_1.furt_patientid = vPatient_1.Pers_PersonId INNER JOIN "
        sCRMSql = sCRMSql & "CRM.CRM.dbo.vSummaryPerson AS vConsultant ON vFurther_1.furt_conultantid = vConsultant.Pers_PersonId INNER JOIN "
        sCRMSql = sCRMSql & "CRM.CRM.dbo.vSummaryCompany AS vInsurer ON vFurther_1.furt_insurer = vInsurer.Comp_CompanyId "
        sCRMSql = sCRMSql & "WHERE (ALLI03.[DOCUMENT].thUserField5 <> '') AND (ALLI03.[DOCUMENT].thCustSupp = 'S') and "
        sCRMSql = sCRMSql & "vFurther_1.furt_treattype <> 'Diagnostics' AND vFurther_1.furt_processmap = '2' AND ISNULL(vFurther_1.furt_cannotinvoice, N'N') <> 'OH' AND vFurther_1.furt_treattype <> 'Update' and vFurther_1.furt_insurer <> 9531 and vFurther_1.furt_insurer <> 13838"
        '        sCRMSql = sCRMSql & " and datediff(dd, vFurther_1.furt_ddnotificationsent,'2013-10-14') = 0 "
        If pOption = SelectType.Notification Then
            sCRMSql = sCRMSql & String.Format("  AND (ALLI03.[DOCUMENT].thUserField5 ='DD') AND vFurther_1.furt_sagetakedate <= '{0}' And vFurther_1.furt_ddpaymenttaken Is null and vFurther_1.furt_invdate is not null AND (vFurther_1.furt_DDNotificationSent IS NULL) and vConsultant.pers_ddactive = '0' and ThRemitNo = ''", duedate.ToString("yyyy/MM/dd"))
        Else
            If XtraMessageBox.Show("Is this a New Submission Y/N", "New Submission", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                'sCRMSql = sCRMSql & String.Format(" AND (ALLI03.[DOCUMENT].thUserField5 LIKE 'DD Notified%') AND vFurther_1.furt_sagetakedate <= '{0}' and vFurther_1.furt_invdate is not null and vFurther_1.furt_ddnotificationsent is not null and vFurther_1.furt_ddsubmitted is null and vFurther_1.furt_ddpaymenttaken is null and vConsultant.pers_ddactive = '0'", duedate.ToString("yyyy/MM/dd"))
                'sCRMSql = sCRMSql & String.Format(" AND vFurther_1.furt_sagetakedate <= '{0}' and vFurther_1.furt_invdate is not null and vFurther_1.furt_ddnotificationsent is not null and vFurther_1.furt_ddsubmitted is null and vFurther_1.furt_ddpaymenttaken is null and vConsultant.pers_ddactive = '0'", duedate.ToString("yyyy/MM/dd"))
                sCRMSql = sCRMSql & " and ALLI03.[DOCUMENT].thAmountSettled <>   ALLI03.[DOCUMENT].thNetValue  and thOutstanding <> '' "
                sCRMSql = sCRMSql & String.Format(" AND datediff(dd, vFurther_1.furt_ddsubmitted,'{0}') = 0  and vConsultant.pers_ddactive = '0' and ThRemitNo = ''", duedate.ToString("yyyy/MM/dd"))
            Else
                sCRMSql = sCRMSql & " and ALLI03.[DOCUMENT].thAmountSettled <>   ALLI03.[DOCUMENT].thNetValue and thOutstanding <> ''"
                sCRMSql = sCRMSql & String.Format(" AND vFurther_1.furt_sagetakedate <= '{0}' and vFurther_1.furt_invdate is not null and datediff(dd,vFurther_1.furt_invdate,GETDATE())> 45 and vFurther_1.furt_ddnotificationsent is null and vFurther_1.furt_ddsubmitted is null and vConsultant.pers_ddactive = '0' and ThRemitNo = ''", duedate.ToString("yyyy/MM/dd"))

            End If
        End If

        Dim dlg = New DevExpress.Utils.WaitDialogForm("Loading Invoices ...")

        Dim cn As New SqlConnection(sExchConn)
        cn.Open()
        ds.Reset()
        Dim dataAdapter As New SqlDataAdapter(sCRMSql, cn)
        dataAdapter.Fill(ds)
        cn.Close()
        dlg.Close()

        If Not ds.Tables(0).Columns.Contains("Process") Then
            Dim column As DataColumn
            Dim table As DataTable = ds.Tables(0)

            column = New DataColumn
            With column
                .ColumnName = "PROCESS"
                .Caption = "PROCESS"
                .ReadOnly = False
                .DataType = System.Type.GetType("System.Boolean")
                .DefaultValue = True
                .Unique = False
            End With
            table.Columns.Add(column)
        End If

        bsiProgressText.Caption = String.Format("Records ({0})", ds.Tables(0).Rows.Count)

        Me.grdSageInvoices.Visible = True
        Me.grdSageInvoices.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.grdSageInvoices.DataSource = ds.Tables(0)
        SetupInvoiceGrid()
    End Sub
    Private Sub SetupDebitsGrid()
        Me.grdSageInvoices.Visible = False
        Me.GridDirectDebits.Visible = True
        Me.GridDebitInvoices.Visible = False
    End Sub
    Private Sub SetupInvoiceGrid()
        Me.grdSageInvoices.Visible = True
        Me.GridDirectDebits.Visible = False
        Me.GridDebitInvoices.Visible = False
        GridView1.BeginSort()
        Try
            GridView1.ClearSorting()
            GridView1.Columns("thAcCode").SortOrder = ColumnSortOrder.Ascending
        Finally
            GridView1.EndSort()
        End Try

        For Each oCol As GridColumn In Me.GridView1.Columns
            oCol.OptionsColumn.ReadOnly = True
            '            oCol.OptionsColumn.AllowEdit = False
            '   oCol.Visible = False
        Next
        GridView1.Columns("PROCESS").VisibleIndex = 0
        GridView1.Columns("PROCESS").OptionsColumn.ReadOnly = False
        GridView1.Columns("PROCESS").OptionsColumn.AllowEdit = True
        GridView1.Columns("PROCESS").OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

        GridView1.Columns("thAcCode").Caption = "ACCOUNT_REF"
        GridView1.Columns("thAcCode").Visible = True
        '      GridView1.Columns("ACCOUNT_REF").VisibleIndex = 0
        GridView1.Columns("thAcCode").Width = 100

        GridView1.Columns("INV_REF").Caption = "INV_REF"
        GridView1.Columns("INV_REF").Visible = True
        '       GridView1.Columns("INV_REF").VisibleIndex = 4


    End Sub
    Private Sub btnSelectData_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelectData.ItemClick
        'GetInvoices()
        GetInvoicesFromCrm(SelectType.Notification)
        SetupInvoiceGrid()
    End Sub
    Private Sub SendStatements()

        Dim dscons As New DataSet

        If Sage2CRMSettings.GetSetting("SMTPSERVER") = "" Then
            Sage2CRMSettings.SetSetting("SMTPSERVER", "Alliance-Exch")
        End If
        Dim smtpserver As String = Sage2CRMSettings.GetSetting("SMTPSERVER")
        If Sage2CRMSettings.GetSetting("EmailAddress") = "" Then
            Sage2CRMSettings.SetSetting("EmailAddress", "finance@allsurgical.co.uk")
        End If
        Dim financeaddress As String = Sage2CRMSettings.GetSetting("EmailAddress")
        '   financeaddress = financeaddress & ";johnmolloy@allsurgical.co.uk"

        Dim objSMTPClient As Net.Mail.SmtpClient = New Net.Mail.SmtpClient()
        objSMTPClient.Host = smtpserver

        '    Dim eTextLines() As String = {"Dear {0}", _
        '"Advance Notice for Direct Debit Payment.", _
        '"Service User Number:  437995		Payer Reference:	{0}", _
        '"Thank you for paying by Direct Debit.  We will collect your payment of {0:c2} on or just after {1} being working 10 days from the date of this letter.", _
        '"The payment is in respect of the invoices below.  In future, if there is any change to the date, amount or frequency of your Direct Debit, ", _
        '"we will always give you 10 working days notice in advance of your account being debited.", _
        '"Date             Invoice         Amount     ", _
        '"{0}   {1,10}         {2:£#,##0.00}      {3} ", _
        '"Please let us know immediately by telephone on 0121 455 0492 or by email on finance@allsurgical.co.uk should you have any queries about the payment.", _
        '"Yours(sincerely)", _
        '"Finance(Department)", _
        '"Alliance Surgical plc"}


        Dim eTextLines() As String = {"Dear {0}", _
    "Advance Notice for Direct Debit Payment.", _
    "Service User Number:  437995		Payer Reference:	{0}", _
    "Thank you for paying by Direct Debit.  We will collect your payment of {0:c2} on or just after {1} being working 10 days from the date of this letter.", _
    "We will also make payment of {0:c2} to you on receipt of the above.", _
    "The payment is in respect of the statements below.  In future, if there is any change to the date, amount or frequency of your Direct Debit, ", _
    "we will always give you 10 working days notice in advance of your account being debited.", _
    "Date                 Patient     ", _
    "{0}   {1,10}         {2} ", _
    "Please let us know immediately by telephone on 0121 455 0492 or by email on finance@allsurgical.co.uk should you have any queries about the payment.", _
    "Yours(sincerely)", _
    "Finance(Department)", _
    "Alliance Surgical plc"}

        Dim cAccount As String = "£$%"
        Dim iRow As Integer
        Dim oRow As DataRow
        Dim sSagePath As String = ""
        Dim sType As String
        Dim bflag As Boolean

        Dim dTotal As Double
        Dim cTotal As Double

        Dim eBody As String = ""
        Dim eBodyDetails As String = ""

        beiProgress.AutoFillWidth = True
        beiProgress.Caption = "Processing"
        Me.RepositoryItemProgressBar2.Minimum = 0
        RepositoryItemProgressBar2.Maximum = GridView1.RowCount - 1
        GridView1.PostEditor()

        sSagePath = Sage2CRMSettings.GetSetting("SagePath")
        If sSagePath = "" Then
            Sage2CRMSettings.SetSetting("SagePath", "\\ALLIANCE-FS\Company Data\ACCOUNTS\SAGE DATA FILES V2010\EMIS.003\ACCDATA")
            sSagePath = Sage2CRMSettings.GetSetting("SagePath")
        End If

        Try

            While iRow < GridView1.RowCount

                oRow = GridView1.GetDataRow(iRow)
                If oRow.Item("PROCESS") = True Then
                    If cAccount <> CStr(oRow.Item("thAcCode").ToString.Trim) Then
                        If dTotal > 0 Then
                            eBody = eBody & String.Format(eTextLines(3), dTotal, paydate.ToShortDateString) & vbCrLf
                            eBody = eBody & String.Format(eTextLines(4), dTotal - cTotal, paydate.ToShortDateString) & vbCrLf & vbCrLf
                            eBody = eBody & String.Format(eTextLines(5), "") & vbCrLf
                            eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf & vbCrLf
                            eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf
                            eBody = eBody & String.Format("Statement Reconcilation", "") & vbCrLf & vbCrLf
                            eBody = eBody & eBodyDetails & vbCrLf & vbCrLf
                            eBody = eBody & String.Format(eTextLines(9)) & vbCrLf
                            eBody = eBody & String.Format(eTextLines(10)) & vbCrLf
                            eBody = eBody & String.Format(eTextLines(11)) & vbCrLf
                            eBody = eBody & String.Format(eTextLines(12)) & vbCrLf & vbCrLf
                            insMail.Body = eBody
                            objSMTPClient.Send(insMail)
                        End If
                        insMail = New MailMessage
                        dscons.Clear()
                        Dim sSql As String = "SELECT Pers_FullName, pers_invoicename, Pers_FirstName, Pers_LastName, Pers_EmailAddress, pers_invoiceemail FROM vSummaryPerson wHERE  (pers_accode = '" & CStr(oRow.Item("thAcCode").ToString.Trim) & "')"
                        Dim cn As New SqlConnection(My.Settings.CRMConnection)
                        cn.Open()
                        Dim dataAdapter As New SqlDataAdapter(sSql, cn)
                        dataAdapter.Fill(dscons)
                        cn.Close()
                        Dim dsConsFirstname As String = dscons.Tables(0).Rows(0).Item("Pers_FirstName").ToString.Trim
                        Dim dsConsEmail As String = dscons.Tables(0).Rows(0).Item("pers_invoiceemail").ToString.Trim
                        If bDoNotEmail = True Then
                            dsConsEmail = "johnmolloy@allsurgical.co.uk"
                        End If

                        With insMail
                            .Subject = "Direct Debit Notification"
                            .From = New MailAddress("finance@allsurgical.co.uk")
                            If bDoNotEmail = False Then
                                Dim addrArray As String() = financeaddress.Split(";")
                                For Each addrstr As String In addrArray
                                    .Bcc.Add(New MailAddress(addrstr))
                                Next
                                .Bcc.Add(New MailAddress("john.molloy@interactivesp.com"))
                                Dim addrArray1 As String() = dsConsEmail.Split(";")
                                For Each addrstr As String In addrArray1
                                    If addrstr.Length > 0 Then
                                        .To.Add(New MailAddress(addrstr))
                                    End If
                                Next
                            Else
                                .To.Add(New MailAddress(dsConsEmail))
                                .CC.Add(New MailAddress("finance@allsurgical.co.uk"))
                            End If
                        End With
                        dTotal = 0
                        cTotal = 0
                        eBodyDetails = ""
                        cAccount = CStr(oRow.Item("thAcCode").ToString.Trim)

                        '     eBody = String.Format(eTextLines(0), Str(oRow.Item("ConsFirstName").ToString.Trim)) & vbCrLf
                        eBody = String.Format(eTextLines(0), dsConsFirstname) & vbCrLf & vbCrLf
                        eBody = eBody & String.Format(eTextLines(1), "") & vbCrLf & vbCrLf
                        eBody = eBody & String.Format(eTextLines(2), cAccount) & vbCrLf & vbCrLf

                    End If

                    dTotal = dTotal + CDec(oRow.Item("OUTSTANDING").ToString)
                    cTotal = cTotal + CDec(oRow.Item("ConsultantBalance").ToString)

                    Dim Edate As DateTime

                    Edate = DateTime.Parse(oRow.Item("DATE").ToString)

                    eBodyDetails = eBodyDetails & String.Format(eTextLines(8), Edate.ToShortDateString, CStr(oRow.Item("INV_REF").ToString), oRow.Item("DETAILS").ToString) & vbCrLf
                    Dim iFurtherId As Integer = CInt(oRow.Item("INV_REF"))
                    Dim sfile As String = CreateStatementPDF(iFurtherId, "", False)

                    insMail.Attachments.Add(New Net.Mail.Attachment(Trim(sfile)))

                    Try
                        Dim cn As New SqlConnection(Sage2CRMSettings.GetSetting("CRMConnection"))
                        Dim sCmd As New SqlCommand
                        Dim Sstr As String = ""
                        If Debugger.IsAttached = False Then
                            cn.Open()
                            'DEBUG
                            ' Dim Sstr As String = String.Format("Update further set furt_ddnotificationsent= getdate(), furt_sagetakedate = '{0:dd/MMMM/yyyy}' where furt_furtherid = {1}", duedate.ToLongDateString, iFurtherId)
                            sCmd = New SqlCommand(Sstr, cn)
                            sCmd.ExecuteNonQuery()
                            cn.Close()
                        End If

                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical, ex.Message)
                    End Try

                    Try
                        If Debugger.IsAttached = False Then
                            Try
                                Dim cn As New SqlConnection(sExchConn)
                                Dim sCmd As New SqlCommand
                                Dim Sstr As String = ""
                                If bDoNotEmail = False Then
                                    cn.Open()
                                    'DEBUG                                 
                                    '   Dim Sstr As String = String.Format("Update ALLI03.[DOCUMENT] set thDueDate = {0},  thUserField5 = 'DD Notified {1:dd/MMMM/yyyy}' where thOurRef = {1}", duedate.ToLongDateString, CStr(oRow.Item("thOurRef").ToString.Trim))
                                    sCmd = New SqlCommand(Sstr, cn)
                                    sCmd.ExecuteNonQuery()
                                    cn.Close()
                                End If
                            Catch ex As Exception
                                MsgBox("Error", MsgBoxStyle.Critical, ex.Message)
                            End Try
                        End If
                    Catch ex As Exception
                        MsgBox("Error", MsgBoxStyle.Critical, ex.Message)
                    End Try
                    Dim newRow As DataRow = dsEmailCSv.Tables("Notifications").NewRow()
                    newRow("GMC") = cAccount
                    newRow("Invoice") = CStr(oRow.Item("INV_REF").ToString.Trim)
                    newRow("Patient") = oRow.Item("DETAILS").ToString
                    newRow("Consultant") = dscons.Tables(0).Rows(0).Item("Pers_FullName").ToString.Trim()
                    newRow("InvoiceDate") = oRow.Item("DATE")
                    newRow("DueDate") = oRow.Item("DUE_DATE")
                    newRow("Value") = CDbl(oRow.Item("OUTSTANDING"))
                    dsEmailCSv.Tables("Notifications").Rows.Add(newRow)

                End If
                beiProgress.EditValue = iRow
                beiProgress.Refresh()
                iRow = iRow + 1
            End While
            If dTotal > 0 Then
                eBody = eBody & String.Format(eTextLines(3), dTotal, paydate.ToShortDateString) & vbCrLf
                eBody = eBody & String.Format(eTextLines(4), dTotal - cTotal, paydate.ToShortDateString) & vbCrLf & vbCrLf
                eBody = eBody & String.Format(eTextLines(5), "") & vbCrLf
                eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf & vbCrLf
                eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf
                eBody = eBody & String.Format("Statement Reconcilation", "") & vbCrLf & vbCrLf
                eBody = eBody & eBodyDetails & vbCrLf & vbCrLf
                eBody = eBody & String.Format(eTextLines(9)) & vbCrLf
                eBody = eBody & String.Format(eTextLines(10)) & vbCrLf
                eBody = eBody & String.Format(eTextLines(11)) & vbCrLf
                eBody = eBody & String.Format(eTextLines(12)) & vbCrLf & vbCrLf
                insMail.Body = eBody
                objSMTPClient.Send(insMail)
            End If
            EmailFinance()
            dsEmailCSv.Tables("Notifications").Clear()

            MsgBox("All Done", MsgBoxStyle.OkOnly, "Notifications")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub SendNotifications()

        Dim dscons As New DataSet

        If Sage2CRMSettings.GetSetting("SMTPSERVER") = "" Then
            Sage2CRMSettings.SetSetting("SMTPSERVER", "Alliance-Exch")
        End If
        Dim smtpserver As String = Sage2CRMSettings.GetSetting("SMTPSERVER")
        If Sage2CRMSettings.GetSetting("EmailAddress") = "" Then
            Sage2CRMSettings.SetSetting("EmailAddress", "finance@allsurgical.co.uk")
        End If
        Dim financeaddress As String = Sage2CRMSettings.GetSetting("EmailAddress")
        '   financeaddress = financeaddress & ";johnmolloy@allsurgical.co.uk"

        Dim objSMTPClient As Net.Mail.SmtpClient = New Net.Mail.SmtpClient()
        objSMTPClient.Host = smtpserver
        objSMTPClient.UseDefaultCredentials = True


        Dim eTextLines() As String = getEmailText()

        Dim cAccount As String = "£$%"
        Dim iRow As Integer
        Dim oRow As DataRow
        Dim sSagePath As String = ""
        Dim sType As String
        Dim bflag As Boolean

        Dim dTotal As Double
        Dim cTotal As Double

        Dim eBody As String = ""
        Dim eBodyDetails As String = ""

        beiProgress.AutoFillWidth = True
        beiProgress.Caption = "Processing"
        Me.RepositoryItemProgressBar2.Minimum = 0
        RepositoryItemProgressBar2.Maximum = GridView1.RowCount - 1
        GridView1.PostEditor()

        Try

            While iRow < GridView1.RowCount

                oRow = GridView1.GetDataRow(iRow)
                If oRow.Item("PROCESS") = True Then
                    If cAccount <> CStr(oRow.Item("thAcCode").ToString.Trim) Then
                        If dTotal > 0 Then
                            If bCurrentProcess = InvoiceProcess.DD Then
                                eBody = eBody & String.Format(eTextLines(3), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(4), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(5), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(7), "") & vbCrLf
                                eBody = eBody & eBodyDetails & vbCrLf & vbCrLf
                                For itemp As Integer = 9 To UBound(eTextLines) - 1
                                    eBody = eBody & String.Format(eTextLines(itemp)) & vbCrLf
                                Next
                            Else
                                eBody = eBody & String.Format(eTextLines(3), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(4), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(5), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf
                                eBody = eBody & String.Format(eTextLines(7), "") & vbCrLf
                                eBody = eBody & eBodyDetails & vbCrLf & vbCrLf
                                For itemp As Integer = 9 To UBound(eTextLines) - 1
                                    eBody = eBody & String.Format(eTextLines(itemp)) & vbCrLf
                                Next
                            End If
                            insMail.Body = eBody
                            '  objSMTPClient.Send(insMail)
                        End If
                        insMail = New MailMessage
                        dscons.Clear()
                        Dim sSql As String = "SELECT Pers_FullName, pers_invoicename, Pers_FirstName, Pers_LastName, Pers_EmailAddress, pers_invoiceemail FROM vSummaryPerson wHERE  (pers_accode = '" & CStr(oRow.Item("thAcCode").ToString.Trim) & "')"
                        Dim cn As New SqlConnection(My.Settings.CRMConnection)
                        cn.Open()
                        Dim dataAdapter As New SqlDataAdapter(sSql, cn)
                        dataAdapter.Fill(dscons)
                        cn.Close()
                        Dim dsConsFirstname As String = dscons.Tables(0).Rows(0).Item("Pers_FirstName").ToString.Trim
                        Dim dsConsEmail As String = dscons.Tables(0).Rows(0).Item("pers_invoiceemail").ToString.Trim
                        If bDoNotEmail = True Then
                            dsConsEmail = "johnmolloy@allsurgical.co.uk"
                        End If

                        With insMail
                            .Subject = "Direct Debit Notification"
                            .From = New MailAddress("finance@allsurgical.co.uk")
                            If bDoNotEmail = False Then
                                Dim addrArray As String() = financeaddress.Split(";")
                                For Each addrstr As String In addrArray
                                    .Bcc.Add(New MailAddress(addrstr))
                                Next
                                .Bcc.Add(New MailAddress("adrianfearon@allsurgical.co.uk"))
                                Dim addrArray1 As String() = dsConsEmail.Split(";")
                                For Each addrstr As String In addrArray1
                                    If addrstr.Length > 0 Then
                                        .To.Add(New MailAddress(addrstr))
                                    End If
                                Next
                            Else
                                .To.Add(New MailAddress(dsConsEmail))
                                .CC.Add(New MailAddress("finance@allsurgical.co.uk"))
                            End If
                        End With
                        dTotal = 0
                        cTotal = 0
                        eBodyDetails = ""
                        cAccount = CStr(oRow.Item("thAcCode").ToString.Trim)

                        ' eBody = String.Format(eTextLines(0), Str(oRow.Item("ConsFirstName").ToString.Trim)) & vbCrLf
                        eBody = String.Format(eTextLines(0), dsConsFirstname) & vbCrLf & vbCrLf
                        eBody = eBody & String.Format(eTextLines(1), "") & vbCrLf & vbCrLf
                        eBody = eBody & String.Format(eTextLines(2), cAccount) & vbCrLf & vbCrLf

                    End If

                            dTotal = dTotal + CDec(oRow.Item("OUTSTANDING").ToString)
                            cTotal = cTotal + CDec(oRow.Item("ConsultantBalance").ToString)

                            Dim Edate As DateTime

                            Edate = DateTime.Parse(oRow.Item("DATE").ToString)

                            If bCurrentProcess = InvoiceProcess.DD Then
                                'eBodyDetails = eBodyDetails & String.Format(eTextLines(7), InvoiceDate.ToShortDateString, sInvoice, CDec(orow.Item("PurchaseTotal").ToString.Trim), sPatient) & vbCrLf
                                eBodyDetails = eBodyDetails & String.Format(eTextLines(8), Edate.ToShortDateString, oRow.Item("Details").ToString) & vbCrLf
                            Else
                                eBodyDetails = eBodyDetails & String.Format(eTextLines(8), Edate.ToShortDateString, oRow.Item("Details").ToString) & vbCrLf
                            End If
                            Dim iFurtherId As Integer = CInt(oRow.Item("ID"))
                            Dim sfile As String = CreateStatementPDF(iFurtherId, CStr(oRow.Item("INV_REF").ToString), False)

                            insMail.Attachments.Add(New Net.Mail.Attachment(Trim(sfile)))

                            Try

                                ' Update flag in the database to indicate noto
                                Dim cn As New SqlConnection(Sage2CRMSettings.GetSetting("CRMConnection"))
                                Dim sCmd As New SqlCommand
                                Dim Sstr As String = ""
                                If bDoNotEmail = False Then
                                    cn.Open()

                                    'DEBUG
                            Sstr = String.Format("Update further set furt_ddnotificationsent= getdate(), furt_sagetakedate = '{0:dd/MMMM/yyyy}' where furt_furtherid = {1}", duedate.ToLongDateString, iFurtherId)
                            sCmd = New SqlCommand(Sstr, cn)
                            sCmd.ExecuteNonQuery()
                                    cn.Close()
                                End If

                            Catch ex As Exception
                                MsgBox("Error", MsgBoxStyle.Critical, ex.Message)
                            End Try

                            Try
                                Try
                                    Dim cn As New SqlConnection(sExchConn)
                                    Dim sCmd As New SqlCommand
                                    If bDoNotEmail = False Then
                                        ' cn.Open()
                                        'DEBUG                                 
                                        '  Dim Sstr As String = String.Format("Update ALLI03.[DOCUMENT] set thDueDate = {0},  thUserField5 = 'DD Notified '{1:dd/MMMM/yyyy}' where thOurRef = {1}", duedate.ToLongDateString, CStr(oRow.Item("thOurRef").ToString.Trim))
                                        ' sCmd = New SqlCommand(Sstr, cn)
                                        ' sCmd.ExecuteNonQuery()
                                        ' cn.Close()
                                    End If
                                Catch ex As Exception
                                    MsgBox("Error", MsgBoxStyle.Critical, ex.Message)
                                End Try
                            Catch ex As Exception
                                MsgBox("Error", MsgBoxStyle.Critical, ex.Message)
                            End Try
                            Dim newRow As DataRow = dsEmailCSv.Tables("Notifications").NewRow()
                            newRow("GMC") = cAccount
                            newRow("Invoice") = CStr(oRow.Item("INV_REF").ToString.Trim)
                            newRow("Patient") = oRow.Item("DETAILS").ToString
                            newRow("Consultant") = dscons.Tables(0).Rows(0).Item("Pers_FullName").ToString.Trim()
                            newRow("InvoiceDate") = oRow.Item("DATE")
                            newRow("DueDate") = beiSelectionDate.EditValue
                            newRow("Value") = CDbl(oRow.Item("OUTSTANDING"))
                            dsEmailCSv.Tables("Notifications").Rows.Add(newRow)

                End If
                beiProgress.EditValue = iRow
                beiProgress.Refresh()
                iRow = iRow + 1
            End While
            If dTotal > 0 Then
                If bCurrentProcess = InvoiceProcess.DD Then
                    eBody = eBody & String.Format(eTextLines(3), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(4), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(5), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(7), "") & vbCrLf
                    eBody = eBody & eBodyDetails & vbCrLf & vbCrLf
                    For itemp As Integer = 9 To UBound(eTextLines) - 1
                        eBody = eBody & String.Format(eTextLines(itemp)) & vbCrLf
                    Next
                Else
                    eBody = eBody & String.Format(eTextLines(3), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(4), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(5), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(6), "") & vbCrLf
                    eBody = eBody & String.Format(eTextLines(7), "") & vbCrLf
                    eBody = eBody & eBodyDetails & vbCrLf & vbCrLf
                    For itemp As Integer = 9 To UBound(eTextLines) - 1
                        eBody = eBody & String.Format(eTextLines(itemp)) & vbCrLf
                    Next
                End If

                insMail.Body = eBody
                objSMTPClient.Send(insMail)
            End If
            'DEBUG   EmailFinance()
            dsEmailCSv.Tables("Notifications").Clear()
            MsgBox("All Done", MsgBoxStyle.OkOnly, "Notifications")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error")
        End Try

    End Sub
    Private Sub ProcessInvoicesforDD()

        Dim dscons As New DataSet

        Dim cAccount As String = "£$%"
        Dim iRow As Integer
        Dim oRow As DataRow

        Dim thisuow As NestedUnitOfWork

        thisuow = Session1.BeginNestedUnitOfWork

        ThisBatch = New DirectDebitHeader(Session1)
        Dim cDetails As DirectDebitDetails
        Dim cInvoice As DirectDebitInvoice
        Dim dTotal As Double
        Dim cTotal As Double

        GridView1.PostEditor()

        ThisBatch.dh_date = paydate
        ThisBatch.dh_Posted = False

        ThisBatch.Save()
        thisuow.CommitChanges()
        While iRow < GridView1.RowCount
            oRow = GridView1.GetDataRow(iRow)
            If oRow.Item("PROCESS") = True Then
                If cAccount <> CStr(oRow.Item("ddPlanRef").ToString.Trim) Then
                    If iRow > 0 Then
                        cDetails.Save()
                        thisuow.CommitChanges()
                    End If

                    dscons.Clear()
                    Dim sSql As String = "SELECT Pers_FullName, pers_invoicename, Pers_FirstName, Pers_LastName, Pers_EmailAddress, pers_invoiceemail FROM vSummaryPerson wHERE  (pers_accode = '" & CStr(oRow.Item("thAcCode").ToString.Trim) & "')"
                    Dim cn As New SqlConnection(My.Settings.CRMConnection)
                    cn.Open()
                    Dim dataAdapter As New SqlDataAdapter(sSql, cn)
                    dataAdapter.Fill(dscons)
                    cn.Close()
                    Dim dsConsFirstname As String = dscons.Tables(0).Rows(0).Item("Pers_FirstName").ToString.Trim
                    Dim dsConsEmail As String = dscons.Tables(0).Rows(0).Item("pers_invoiceemail").ToString.Trim
                    '  dsConsEmail = "johnmolloy@allsurgical.co.uk"

                    dTotal = 0
                    cTotal = 0
                    cAccount = CStr(oRow.Item("ddPlanRef").ToString.Trim)
                    cDetails = New DirectDebitDetails(Session1)
                    cDetails.dd_account = cAccount
                    cDetails.dd_date = Date.Today
                    cDetails.dd_duedate = duedate
                    cDetails.dd_plan = 1
                    cDetails.dd_comment = ""
                    cDetails.dd_posted = False
                    cDetails.dd_paid = False
                    ThisBatch.dh_DebitDetails.Add(cDetails)
                End If
                If cDetails.dd_comment.Length + CStr(oRow.Item("INV_REF").ToString.Trim).Length < 59 Then
                    If cDetails.dd_comment.Length > 0 Then
                        cDetails.dd_comment = cDetails.dd_comment + "\"
                    End If
                    cDetails.dd_comment = "Inv " & CStr(oRow.Item("INV_REF").ToString.Trim)
                End If
                cInvoice = New DirectDebitInvoice(Session1)
                cInvoice.di_account = cAccount
                cInvoice.di_invoice = CStr(oRow.Item("INV_REF").ToString.Trim)
                cInvoice.di_date = CDate(oRow.Item("DATE"))
                cInvoice.di_value = CDec(String.Format("{0:00}", oRow.Item("ConsultantBalance").ToString))
                dTotal = dTotal + cInvoice.di_value
                cTotal = cTotal + cInvoice.di_value
                ' cInvoice.di_headernumber = CLng(oRow.Item("HEADER_NUMBER").ToString.Trim)
                ' ' cInvoice.di_tran_number = CLng(oRow.Item("TRAN_NUMBER").ToString.Trim)
                cDetails.dd_DebitInvoices.Add(cInvoice)
                cDetails.dd_value = cDetails.dd_value + cInvoice.di_value
                Try
                    Dim cn As New SqlConnection(My.Settings.CRMConnection)
                    Dim sCmd As New SqlCommand
                    cn.Open()
                    Dim Sstr As String = String.Format("Update further set furt_ddsubmitted = getdate() where furt_invnumber = '{0}'", cInvoice.di_invoice)
                    sCmd = New SqlCommand(Sstr, cn)
                    sCmd.ExecuteNonQuery()
                    cn.Close()
                Catch ex As Exception
                End Try
            End If
            iRow = iRow + 1
        End While
        cDetails.Save()
        thisuow.CommitChanges()
    End Sub
    Private Function CreateStatementPDF(ByVal pRefID As Integer, ByVal pInvoiceNo As String, ByVal pPreview As Boolean) As String
        Dim StatementPDF As New Statement

        Dim sFile As String = sPath & "\PDF\" & String.Format("Statement {0}.pdf", pRefID)
        StatementPDF.Parameter1.Value = pRefID
        StatementPDF.CreateDocument()
        If pPreview = True Then
            StatementPDF.RequestParameters = False
            'LPDF.ShowPreview()
        Else
            If Not System.IO.File.Exists(sFile) Then
                StatementPDF.ExportToPdf(sFile)
            End If
            StatementPDF.Dispose()
        End If
        Return sFile
    End Function
    Private Function CreateSLPDF(ByVal pRefID As Integer, ByVal pInvoiceNo As String, ByVal pPreview As Boolean) As String
        Dim SLPDF As New AllianceInvoice

        Dim sFile As String = sPath & "\PDF\" & String.Format("Alliance Invoice {0}.pdf", pRefID)
        SLPDF.Parameter1.Value = pRefID
        SLPDF.CreateDocument()
        If pPreview = True Then
            SLPDF.RequestParameters = False
            'LPDF.ShowPreview()
        Else
            If Not System.IO.File.Exists(sFile) Then
                SLPDF.ExportToPdf(sFile)
            End If
            SLPDF.Dispose()
        End If
        Return sFile
    End Function
    Private Sub LoadPayments(ByVal pBatch As DirectDebitHeader)
        Me.grdSageInvoices.Visible = False
        Me.GridDebitInvoices.Visible = False
        Me.GridDirectDebits.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.GridDirectDebits.BeginUpdate()
        For Each pd In pBatch.dh_DebitDetails
            Debug.Print(pd.DD_id)
        Next

        Me.GridDirectDebits.DataSource = pBatch.dh_DebitDetails
        Me.GridDirectDebits.EndUpdate()
        Me.GridDirectDebits.Visible = True

        For Each oCol As GridColumn In Me.GridView2.Columns
            oCol.Visible = False
        Next

        GridView2.Columns("dd_posted").Caption = "Posted"
        GridView2.Columns("dd_posted").Visible = True
        GridView2.Columns("dd_posted").VisibleIndex = 0

        GridView2.Columns("dd_paid").Caption = "Paid"
        GridView2.Columns("dd_paid").Visible = True
        GridView2.Columns("dd_paid").VisibleIndex = 0

        GridView2.Columns("dd_comment").Caption = "Comments"
        GridView2.Columns("dd_comment").Visible = True
        GridView2.Columns("dd_comment").VisibleIndex = 0

        GridView2.Columns("dd_plan").Caption = "Plan"
        GridView2.Columns("dd_plan").Visible = True
        GridView2.Columns("dd_plan").VisibleIndex = 0

        GridView2.Columns("dd_duedate").Caption = "DateDue"
        GridView2.Columns("dd_duedate").Visible = True
        GridView2.Columns("dd_duedate").VisibleIndex = 0

        GridView2.Columns("dd_value").Caption = "Amount"
        GridView2.Columns("dd_value").Visible = True
        GridView2.Columns("dd_value").VisibleIndex = 0

        GridView2.Columns("dd_account").Caption = "PlanReference"
        GridView2.Columns("dd_account").Visible = True
        GridView2.Columns("dd_account").VisibleIndex = 0

        Me.GridDirectDebits.EndUpdate()
    End Sub
    Private Sub SavePaymentsXLS()

        Dim sfd As SaveFileDialog = New SaveFileDialog()

        sfd.Title = "Save"
        sfd.DefaultExt = "csv"
        sfd.Filter = "*.csv|*.csv"
        sfd.FileName = "DD Payments"



        If sfd.ShowDialog() = DialogResult.OK Then
            'GridView2.Columns("dd_paid").Visible = False
            'GridView2.Columns("dd_posted").Visible = False

            Dim txtoptions As DevExpress.XtraPrinting.TextExportOptions = New DevExpress.XtraPrinting.TextExportOptions()
            txtoptions.Separator = ","
            txtoptions.QuoteStringsWithSeparators = True
            GridView1.ExportToText(sfd.FileName, txtoptions)

            'GridView2.Columns("dd_paid").Visible = True
            'GridView2.Columns("dd_posted").Visible = True

            Dim ps As New ProcessStartInfo
            ps.UseShellExecute = True
            ps.FileName = sfd.FileName
            Process.Start(ps)

        End If


    End Sub
    Private Sub btnSaveXLS_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        SavePaymentsXLS()
    End Sub
    Private Sub DDPayments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not System.IO.Directory.Exists(sPath & "\PDF")) Then
            System.IO.Directory.CreateDirectory(sPath & "\PDF")
        End If

        Dim diFolder As New System.IO.DirectoryInfo(sPath & "\PDF")
        Dim diFileList As System.IO.FileInfo() = diFolder.GetFiles()

        For Each diFile As System.IO.FileInfo In diFileList
            diFile.Delete()
        Next

        If (Not System.IO.Directory.Exists(sPath & "\CSV")) Then
            System.IO.Directory.CreateDirectory(sPath & "\CSV")
        End If

        beiSelectionDate.EditValue = Date.Today
        Me.grdSageInvoices.Visible = False
        Me.GridDirectDebits.Visible = False
        Dim xpcDebits As New XPCollection(Of DirectDebitHeader)(Session1)
        RepositoryItemGridLookUpEdit1.DataSource = xpcDebits
        RepositoryItemGridLookUpEdit1.PopulateViewColumns()
        RepositoryItemGridLookUpEdit1.DisplayMember = "dh_date"
        RepositoryItemGridLookUpEdit1.View.Columns(0).Visible = False
        RepositoryItemGridLookUpEdit1.View.Columns(0).Caption = "Date"
        RepositoryItemGridLookUpEdit1.View.Columns(2).Visible = False
        RepositoryItemGridLookUpEdit1.ValueMember = "dh_id"
        beiDirectDebits.EditValue = 10
        If Debugger.IsAttached Then
            bDoNotEmail = True
        End If
        bDoNotEmail = False
        makeCSVtable()
        Me.GridDirectDebits.Visible = False
        Me.grdSageInvoices.Visible = False
    End Sub
    Private Sub GridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        If e.Column.Name = "colPlan" Then
            If e.IsGetData Then
                e.Value = 1
            End If
        End If
        If e.Column.Name = "colDateDue" Then
            If e.IsGetData Then
                e.Value = Date.Today
            End If
        End If
    End Sub
    Public Sub EmailFinance()

        Dim insMail As New MailMessage

        Dim sNotificationsFile As String = sPath & "\CSV\" & String.Format("Notifications {0:d2}{1:d2}{2:d2}-{3:d2}{4:d2}{5:d2}.csv", DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, DateAndTime.Now.Hour, DateAndTime.Now.Minute, DateAndTime.Now.Second)
        Dim sSubmissionFile As String = sPath & "\CSV\" & String.Format("Submissions {0:d2}{1:d2}{2:d2}-{3:d2}{4:d2}{5:d2}.csv", DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, DateAndTime.Now.Hour, DateAndTime.Now.Minute, DateAndTime.Now.Second)

        If System.IO.File.Exists(sNotificationsFile) Then
            System.IO.File.Delete(sNotificationsFile)
        End If

        If System.IO.File.Exists(sSubmissionFile) Then
            System.IO.File.Delete(sSubmissionFile)
        End If

        If dsEmailCSv.Tables("Notifications").Rows.Count > 0 Then
            ExportDatasetToCsv(dsEmailCSv.Tables("Notifications"), sNotificationsFile)
            insMail.Subject = "Notifications " & Date.Today.ToShortDateString
        End If
        If dsEmailCSv.Tables("Submissions").Rows.Count > 0 Then
            ExportDatasetToCsv(dsEmailCSv.Tables("Submission"), sSubmissionFile)
            insMail.Subject = "Submission " & Date.Today.ToShortDateString
        End If

        If Sage2CRMSettings.GetSetting("SMTPSERVER") = "" Then
            Sage2CRMSettings.SetSetting("SMTPSERVER", "Alliance-Exch")
        End If
        Dim smtpserver As String = Sage2CRMSettings.GetSetting("SMTPSERVER")
        If Sage2CRMSettings.GetSetting("EmailAddress") = "" Then
            Sage2CRMSettings.SetSetting("EmailAddress", "finance@allsurgical.co.uk;KasiaWalijewska@allsurgical.co.uk")
        End If

        Dim financeaddress As String = Sage2CRMSettings.GetSetting("EmailAddress")

        If bDoNotEmail = True Then
            financeaddress = "johnmolloy@allsurgical.co.uk"
        End If

        Dim objSMTPClient As Net.Mail.SmtpClient = New Net.Mail.SmtpClient()
        objSMTPClient.Host = smtpserver

        With insMail

            .From = New MailAddress("finance@allsurgical.co.uk")

            Dim addrArray As String() = financeaddress.Split(";")
            For Each addrstr As String In addrArray
                .To.Add(New MailAddress(addrstr))
            Next
            .Body = .Subject
            If System.IO.File.Exists(sNotificationsFile) Then
                .Attachments.Add(New Attachment(sNotificationsFile))
            End If

            If System.IO.File.Exists(sSubmissionFile) Then
                .Attachments.Add(New Attachment(sSubmissionFile))
            End If

        End With

        objSMTPClient.Send(insMail)

    End Sub
    Private Sub ExportDatasetToCsv(ByVal MyDataTable As DataTable, ByVal sFile As String)

        Dim dr As DataRow
        Dim myString As String
        Dim bFirstField As Boolean = True
        Dim bFirstRow As Boolean = True

        If System.IO.File.Exists(sFile) Then
            System.IO.File.Delete(sFile)
        End If

        Dim myWriter As New System.IO.StreamWriter(sFile)
        myString = ""
        Try
            bFirstField = True
            For Each field As DataColumn In MyDataTable.Columns
                If Not bFirstField Then
                    myString = myString & ","
                End If
                myString = myString & field.ColumnName
                bFirstField = False
            Next
            myString = myString & Environment.NewLine
            For Each dr In MyDataTable.Rows
                bFirstField = True
                For Each field As Object In dr.ItemArray
                    If Not bFirstField Then
                        myString = myString & ","
                    End If
                    myString = myString & field.ToString
                    bFirstField = False
                Next
                'New Line to differentiate next row       
                myString = myString & Environment.NewLine
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Write the String to the Csv File
        myWriter.WriteLine(myString)
        'Clean up
        myWriter.Close()
    End Sub
    Private Sub SaveToBottomline()
        ProcessInvoicesforDD()
        LoadPayments(ThisBatch)

        ' Dim sFile As String = String.Format("{0}\DD {1:d2}{2:d2}{3:d2}-{4:d2}{5:d2}{6:d2}.csv", Sage2CRMSettings.GetSetting("ADHOCPOLLINGPATH"), DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, DateAndTime.Now.Hour, DateAndTime.Now.Minute, DateAndTime.Now.Second)
        Dim sFile As String = String.Format("{0}\DD {1:d2}{2:d2}{3:d2}-{4:d2}{5:d2}{6:d2}.csv", My.Settings.ADHOCPOLLINGPATH, DateAndTime.Now.Year, DateAndTime.Now.Month, DateAndTime.Now.Day, DateAndTime.Now.Hour, DateAndTime.Now.Minute, DateAndTime.Now.Second)
        MsgBox(sFile)
        Dim txtoptions As DevExpress.XtraPrinting.TextExportOptions = New DevExpress.XtraPrinting.TextExportOptions()
        txtoptions.Separator = ","
        txtoptions.QuoteStringsWithSeparators = True

        GridView2.OptionsPrint.PrintHeader = False

        GridView2.Columns("dd_paid").Visible = False
        GridView2.Columns("dd_posted").Visible = False

        GridView2.ExportToText(sFile, txtoptions)
        GridView2.OptionsPrint.PrintHeader = True
        GridView2.Columns("dd_paid").Visible = True
        GridView2.Columns("dd_posted").Visible = True

        '   LoadDDInvoiceDetails(ThisBatch)
    End Sub
    Private Sub LoadDDInvoiceDetails(ByVal pBatch As DirectDebitHeader)
        Me.grdSageInvoices.Visible = False
        Me.GridDirectDebits.Visible = False
        Me.GridDebitInvoices.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Dim xc As XPCollection(Of DirectDebitInvoice)
        GridDebitInvoices.DataSource = pBatch.dh_DebitDetails
        GridDebitInvoices.Visible = True

    End Sub
    Private Sub btnSaveToCSV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveToCSV.ItemClick
        Dim fDate As New AskDate("Process Date", beiSelectionDate.EditValue)
        If fDate.ShowDialog() = DialogResult.OK Then
            duedate = fDate.SelectedDate()
            SaveToBottomline()
        End If

    End Sub

    Private Sub btnLoadPreviousPayments_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadPreviousPayments.ItemClick
        duedate = beiSelectionDate.EditValue
        paydate = beiSelectionDate.EditValue

        Dim connectionString As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;DRIVER=Sage Line 50 v{0};UID={1};PWD={2};DIR={3}", "16", "crm", "crm", Sage2CRMSettings.GetSetting("SAGEPATH"))
        Dim cn1 As OdbcConnection = New OdbcConnection(connectionString)
        Dim sSql As String = "SELECT AUDIT_HEADER.ACCOUNT_REF,  AUDIT_HEADER.TRAN_NUMBER, AUDIT_HEADER.TYPE, AUDIT_HEADER.DATE, AUDIT_HEADER.INV_REF, AUDIT_HEADER.DETAILS,  AUDIT_HEADER.DUE_DATE, AUDIT_HEADER.NET_AMOUNT, AUDIT_HEADER.GROSS_AMOUNT, AUDIT_HEADER.HEADER_NUMBER FROM AUDIT_HEADER AUDIT_HEADER"

        '        sSql = sSql + String.Format(" WHERE (deleted_flag=0 AND type='SI' AND AUDIT_HEADER.OUTSTANDING>0 and AUDIT_HEADER.DUE_DATE<='{0}' and AUDIT_HEADER.ACCOUNT_REF='0123456')", duedate.ToString("yyyy/MM/dd"))
        sSql = sSql + String.Format(" WHERE (deleted_flag=0 AND type='PI' AND AUDIT_HEADER.OUTSTANDING>0 and AUDIT_HEADER.DUE_DATE<='{0}')", duedate.ToString("yyyy/MM/dd"))
        'sSql = sSql + String.Format(" WHERE (deleted_flag=0 AND type='PI')")
        cn1.Open()
        ds.Clear()
        Using command As New OdbcCommand(sSql, cn1)
            Using odbcAdapter As New OdbcDataAdapter(command)
                odbcAdapter.Fill(ds)
            End Using
        End Using
        cn1.Close()
        Me.grdSageInvoices.Visible = True
        Me.grdSageInvoices.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.grdSageInvoices.DataSource = ds.Tables(0)
        SetupInvoiceGrid()
    End Sub

    Private Sub btnSelfBillingInvoice_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelfBillingInvoice.ItemClick
        Dim orow As DataRow
        orow = GridView1.GetFocusedDataRow()
        CreatePLPDF(orow.Item("INV_REF"), orow.Item("INV_REF").ToString, True)
    End Sub
    Private Function CreatePLPDF(ByVal pRefID As Integer, ByVal pInvoiceNo As String, ByVal pPreview As Boolean) As String
        Dim PLPDF As New SelfBillingInvoice

        Dim sFile As String = sPath & "\PDF" & String.Format("Self Billing Invoice {0}.pdf", pInvoiceNo)
        PLPDF.Parameter1.Value = pRefID
        PLPDF.CreateDocument()
        If pPreview = True Then
            PLPDF.RequestParameters = False
            ' PLPDF.ShowPreview()
        Else
            If Not System.IO.File.Exists(sFile) Then
                PLPDF.ExportToPdf(sFile)
            End If
        End If
        Return sFile
    End Function
    Public Sub SavePDF(ByVal pRefID As String, ByVal pFile As String)
        Dim fs As FileStream
        Dim br As BinaryReader
        Dim info As New FileInfo(pFile)
        Dim AttachmentFile() As Byte = Nothing
        fs = New FileStream(info.FullName, FileMode.Open, FileAccess.Read)
        br = New BinaryReader(fs)
        ReDim AttachmentFile(CInt(info.Length))
        AttachmentFile = br.ReadBytes(CInt(info.Length))
        br.Close()
        fs.Close()

        Dim cn As New SqlConnection(My.Settings.CRMConnection)
        cn.Open()

        Dim FSCommand As SqlCommand = Nothing
        FSCommand = New SqlCommand()

        FSCommand.CommandType = CommandType.StoredProcedure
        FSCommand.Connection = cn
        FSCommand.CommandText = "ws_SAGE_SaveFile"
        FSCommand.Parameters.AddWithValue("@entitytype", "Opportunity")
        FSCommand.Parameters.AddWithValue("@leadid", pRefID)

        FSCommand.Parameters.AddWithValue("@filetype", "Invoice")
        FSCommand.Parameters.AddWithValue("@filedate", Date.Today)
        FSCommand.Parameters.AddWithValue("@filename", pFile.Trim)
        FSCommand.Parameters.AddWithValue("@filedescription", pFile.Trim)

        FSCommand.Parameters.AddWithValue("@fileext", ".PDF")
        FSCommand.Parameters.AddWithValue("@filebytes", AttachmentFile)
        FSCommand.ExecuteScalar()
        cn.Close()

    End Sub

    Private Sub BtnSendNotifications_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSendNotifications.ItemClick
        Dim fDate As New AskDate("Proposed Take Date", beiSelectionDate.EditValue)
        If fDate.ShowDialog() = DialogResult.OK Then
            duedate = fDate.SelectedDate()
            'SendStatements()
            SendNotifications()
            '            LoadPayments(ThisBatch)
        End If
        fDate = Nothing
    End Sub
    Public Sub makeCSVtable()

        Dim NotificationsTable As New DataTable("Notifications")

        NotificationsTable.Columns.Add("GMC", Type.GetType("System.String"))
        NotificationsTable.Columns.Add("Invoice", Type.GetType("System.String"))
        NotificationsTable.Columns.Add("Consultant", Type.GetType("System.String"))
        NotificationsTable.Columns.Add("Patient", Type.GetType("System.String"))
        NotificationsTable.Columns.Add("InvoiceDate", Type.GetType("System.DateTime"))
        NotificationsTable.Columns.Add("DueDate", Type.GetType("System.DateTime"))
        NotificationsTable.Columns.Add("Value", Type.GetType("System.String"))

        Dim InvoicesTable As New DataTable("Submissions")

        InvoicesTable.Columns.Add("GMC", Type.GetType("System.String"))
        InvoicesTable.Columns.Add("Invoice", Type.GetType("System.String"))
        InvoicesTable.Columns.Add("Consultant", Type.GetType("System.String"))
        InvoicesTable.Columns.Add("Patient", Type.GetType("System.String"))
        InvoicesTable.Columns.Add("InvoiceDate", Type.GetType("System.DateTime"))
        InvoicesTable.Columns.Add("DueDate", Type.GetType("System.DateTime"))
        InvoicesTable.Columns.Add("Value", Type.GetType("System.String"))

        dsEmailCSv = New DataSet("NotificationsTable")

        dsEmailCSv.Tables.Add(NotificationsTable)
        dsEmailCSv.Tables.Add(InvoicesTable)
    End Sub

    Private Sub bbiSelectSubmissions_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSelectSubmissions.ItemClick
        GetInvoicesFromCrm(SelectType.DDSubmission)
        SetupInvoiceGrid()
    End Sub

    Private Sub bbiSaveXLs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSaveXLs.ItemClick
        Dim sfd As SaveFileDialog = New SaveFileDialog()

        sfd.Title = "Save"
        sfd.DefaultExt = "TXT"
        sfd.Filter = "*.txt|*.txt"
        sfd.FileName = "Selection "

        If sfd.ShowDialog() = DialogResult.OK Then
            'GridView2.Columns("dd_paid").Visible = False
            'GridView2.Columns("dd_posted").Visible = False

            'Dim txtoptions As DevExpress.XtraPrinting.TextExportOptions = New DevExpress.XtraPrinting.TextExportOptions()
            'txtoptions.Separator = ","
            'txtoptions.QuoteStringsWithSeparators = True
            GridView1.ExportToXls(sfd.FileName)

            'GridView2.Columns("dd_paid").Visible = True
            'GridView2.Columns("dd_posted").Visible = True

            Dim ps As New ProcessStartInfo
            ps.UseShellExecute = True
            ps.FileName = sfd.FileName
            Process.Start(ps)

        End If
    End Sub

    Private Sub btnMemberships_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMemberships.ItemClick
        GetMembershipInvoices()
        SetupMembershipGrid()
    End Sub

    Private Sub GetMembershipInvoices()
        Dim sFieldlist As String = "[Reference], [Salutation], [FirstName], [LastName], [DebtorStatus] "
        sFieldlist = sFieldlist & ",[Email]"
        sFieldlist = sFieldlist & ",[PlanReference],[PlanStatus],[RecurranceType]"
        sFieldlist = sFieldlist & ",[AmountRegular],[AmountTotal],[AmountFirst],[AmountLast],[Value1],[Value2],[Value3],[StartDate],[EndDate],[Numberofdebits]"
        Dim sSql As String = "SELECT " & sFieldlist & " from vw_DDAccountsNewAM "
        '  sSql = "SELECT " & sFieldlist & " from vw_DDAccountsNewAM where reference = 'ASTEST1-'"
        Dim sConn As String = Sage2CRMSettings.GetSetting("CRMConnection")
        If sConn = "" Then
            Sage2CRMSettings.SetSetting("CRMConnection", "Data Source=alliance-sql;Initial Catalog=CRM;Integrated Security=True")
            sConn = Sage2CRMSettings.GetSetting("CRMConnection")
        End If
        Try
            Dim cn As New SqlConnection(sConn)
            cn.Open()
            ds.Reset()
            Dim dataAdapter As New SqlDataAdapter(sSql, cn)
            dataAdapter.Fill(ds)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
        Me.grdSageInvoices.Visible = True
        Me.grdSageInvoices.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.grdSageInvoices.DataSource = ds.Tables(0)
    End Sub
    Private Sub SetupMembershipGrid()

        For Each oCol As GridColumn In Me.GridView1.Columns
            oCol.OptionsColumn.AllowEdit = False
        Next
        GridView1.Columns("AmountRegular").DisplayFormat.FormatString = "c2"
        GridView1.Columns("AmountRegular").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        GridView1.Columns("AmountFirst").DisplayFormat.FormatString = "{0:C2}"
        GridView1.Columns("AmountFirst").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        GridView1.Columns("AmountLast").DisplayFormat.FormatString = "{0:C2}"
        GridView1.Columns("AmountLast").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        GridView1.Columns("AmountTotal").DisplayFormat.FormatString = "{0:C2}"
        GridView1.Columns("AmountTotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric


        GridView1.Columns("AmountTotal").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
        GridView1.Columns("AmountTotal").SummaryItem.DisplayFormat = "{0:C2}"
        GridView1.Columns("AmountTotal").SummaryItem.Tag = 1

        GridView1.OptionsView.ShowFooter = True

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
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
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bbiSettings_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiSettings.ItemClick
        Dim dSettings As New SystemSettings()
        dSettings.ShowDialog()
        dSettings.Dispose()
    End Sub
    Private Function getEmailText() As String()
        If bCurrentProcess = InvoiceProcess.DD Then
            Return {"Dear {0}", _
                    "Payment notice in respect of the statements below.", _
                    "", _
                    "Please find enclosed statement/s relating to your most recent Alliance Surgical referred patients. Please note that payment ", _
                    "will be taken by Direct Debit.", _
                    "", _
                    "Payment will be deducted approximately 45 days of the date of consult/treatment taking place.", _
                    "Date              Patient     ", _
                    "{0}   {1} ", _
                    "", _
                    "BACS Payments:    ", _
                    "Alliance Surgical plc", _
                    "Account: 43784142", _
                    "Sort Code: 20-07-71", _
                    "", _
                    "Cheques payable to Alliance Surgical plc, posted to:    ", _
                    "Finance Department", _
                    "Alliance Surgical plc", _
                    "Edgbaston House", _
                    "3 Duchess Place", _
                    "Hagley Road", _
                    "Birmingham", _
                    "B16 8NH"}
        Else
            Return {"Dear {0}", _
                    "Payment notice in respect of the statements below.", _
                    "", _
                    "Please find enclosed statement/s relating to your most recent Alliance Surgical referred patients. Please note that payment ", _
                    "can be made by BACS to the following bank account, or by cheque, made payable to Alliance Surgical plc, and sent to the ", _
                    "address below.", _
                    "Payment is due within 45 days of the date of consult/treatment taking place.", _
                    "Date             Patient     ", _
                    "{0}   {1} ", _
                    "", _
                    "BACS Payments:    ", _
                    "Alliance Surgical plc", _
                    "Account: 43784142", _
                    "Sort Code: 20-07-71", _
                  "", _
                    "Cheques payable to Alliance Surgical plc, posted to:    ", _
                    "Finance Department", _
                    "Alliance Surgical plc", _
                    "Edgbaston House", _
                    "3 Duchess Place", _
                    "Hagley Road", _
                    "Birmingham", _
                    "B16 8NH"}

        End If

    End Function
End Class

