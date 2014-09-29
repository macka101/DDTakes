Imports System

Public Class Statement

    Private Sub ReceiptedInvoice_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Vw_InvoiceTemplateAdapter1.Fill(Invoice1.vw_InvoiceTemplate, CInt(Parameter1.Value))
    End Sub

  

    Private Sub ReportHeader_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint

    End Sub

 
    Private Sub XrLabelAddress_BeforePrint(sender As System.Object, e As System.Drawing.Printing.PrintEventArgs) Handles XrLabelAddress.BeforePrint
        XrLabelAddress.Text = GetCurrentColumnValue("ConsultantName").ToString + Environment.NewLine
        If GetCurrentColumnValue("ConsultantAddress1").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantAddress1").ToString + Environment.NewLine
        End If
        If GetCurrentColumnValue("ConsultantAddress2").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantAddress2").ToString + Environment.NewLine
        End If
        If GetCurrentColumnValue("ConsultantAddress3").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantAddress3").ToString + Environment.NewLine
        End If
        If GetCurrentColumnValue("ConsultantAddress4").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantAddress4").ToString + Environment.NewLine
        End If
        If GetCurrentColumnValue("ConsultantAddress5").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantAddress5").ToString + Environment.NewLine
        End If
        If GetCurrentColumnValue("ConsultantCity").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantCity").ToString + Environment.NewLine
        End If
        If GetCurrentColumnValue("ConsultantCounty").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantCounty").ToString + Environment.NewLine
        End If
        If GetCurrentColumnValue("ConsultantPostcode").ToString.TrimEnd <> "" Then
            XrLabelAddress.Text = XrLabelAddress.Text + GetCurrentColumnValue("ConsultantPostcode").ToString + Environment.NewLine
        End If
    End Sub


    Private Sub XrLabelInvoiceRaised_BeforePrint(sender As System.Object, e As System.Drawing.Printing.PrintEventArgs) Handles XrLabelInvoiceRaised.BeforePrint
        If GetCurrentColumnValue("InsurerName").ToString.Trim = "Self Pay" Then
            XrLabelInvoiceRaised.Text = String.Format("Invoice Raised To {0}", "Patient")
        Else
            XrLabelInvoiceRaised.Text = String.Format("Invoice Raised To {0}", GetCurrentColumnValue("InsurerName").ToString.Trim)
        End If

    End Sub

    Private Sub XrLabelInsurerPaid_BeforePrint(sender As System.Object, e As System.Drawing.Printing.PrintEventArgs) Handles XrLabelInsurerPaid.BeforePrint
        If GetCurrentColumnValue("InsurerName").ToString.Trim = "Self Pay" Then
            XrLabelInsurerPaid.Text = String.Format("{0} paid to {1} directly", "Patient", GetCurrentColumnValue("ConsultantName").ToString.Trim)
        Else
            XrLabelInsurerPaid.Text = String.Format("{0} paid to {1} directly", GetCurrentColumnValue("InsurerName").ToString.Trim, GetCurrentColumnValue("ConsultantName").ToString.Trim)

        End If
    End Sub

    Private Sub XrLabelfeeDue_BeforePrint(sender As System.Object, e As System.Drawing.Printing.PrintEventArgs) Handles XrLabelfeeDue.BeforePrint
        XrLabelfeeDue.Text = String.Format("Fee Due to {0} ", GetCurrentColumnValue("ConsultantName").ToString.Trim)
    End Sub
End Class