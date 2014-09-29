Imports System.Net.Mail


Public Class SendSBInvoices

    Private Sub btnSend_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSend.ItemClick

        Dim insMail As New MailMessage()

        With insMail
            .From = (New MailAddress("johnmolloy@allsurgical.co.uk"))
            .To.Add(New MailAddress("john.molloy@InteractiveSP.com"))
         
            .Subject = "Self Billing Invoices"
            .Body = "Attached is your Invoices for "
            .CC.Add(New MailAddress("john.molloy@InteractiveSP.com"))

            'Dim strFile As String
            'Dim strAttach() As String = Split(strArgs(6), ";")
            'For Each strFile In strAttach
            '    .Attachments.Add(New Attachment(Trim(strFile)))
            'Next
        End With
        Dim mSmtpClient As SmtpClient = New SmtpClient()

        mSmtpClient.Host = "Alliance-exch"

        mSmtpClient.Send(insMail)


    End Sub

    Private Sub btnSelect_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick

    End Sub
End Class