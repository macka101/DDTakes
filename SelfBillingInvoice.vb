Imports System

Public Class SelfBillingInvoice

    Private Sub ReceiptedInvoice_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Vw_InvoiceTemplateAdapter1.Fill(Invoice1.vw_InvoiceTemplate, CInt(Parameter1.Value))
    End Sub

    Private Sub XrLabelAddress_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)

    End Sub

    Private Sub ReportHeader_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint

    End Sub

    Private Sub XrLabelAddress_BeforePrint_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabelAddress.BeforePrint
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
End Class