Public Class SystemSettings 

    Private Sub teSagePath_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teSagePath.EditValueChanged

    End Sub
    Private Sub teMailServer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teMailServer.EditValueChanged

    End Sub
    Private Sub LabelControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Sage2CRMSettings.SetSetting("SMTPSERVER", teMailServer.Text)
        Sage2CRMSettings.SetSetting("DDPOLLINGPATH", tePollingPath.Text)
        Sage2CRMSettings.SetSetting("ADHOCPOLLINGPATH", tePaymentPath.Text)
        Sage2CRMSettings.SetSetting("SAGEPATH", teSagePath.Text)
        Sage2CRMSettings.SetSetting("CRMCONNECTION", teCRMConnection.Text)
        Sage2CRMSettings.SetSetting("ACCOUNTSCONNECTION", teAccountsConnection.Text)
        Sage2CRMSettings.SetSetting("MAKEPAYMENTDAYS", teMakePayment.Text)
        Sage2CRMSettings.SetSetting("TAKEPAYMENTDAYS", teTakePayment.Text)
        Me.Close()
    End Sub

    Private Sub SystemSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        teMailServer.Text = Sage2CRMSettings.GetSetting("SMTPSERVER")
        tePollingPath.Text = Sage2CRMSettings.GetSetting("DDPOLLINGPATH")
        tePaymentPath.Text = Sage2CRMSettings.GetSetting("ADHOCPOLLINGPATH")
        teSagePath.Text = Sage2CRMSettings.GetSetting("SAGEPATH")
        teCRMConnection.Text = Sage2CRMSettings.GetSetting("CRMCONNECTION")
        teAccountsConnection.Text = Sage2CRMSettings.GetSetting("ACCOUNTSCONNECTION")
        teMakePayment.Text = Sage2CRMSettings.GetSetting("MAKEPAYMENTDAYS")
        teTakePayment.Text = Sage2CRMSettings.GetSetting("TAKEPAYMENTDAYS")

        If teMailServer.Text = "" Then
            teMailServer.Text = "alliance-exch"
        End If
        If teMakePayment.Text = "" Then
            teMakePayment.Text = "14"
        End If

        If teTakePayment.Text = "" Then
            teTakePayment.Text = "45"
        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDDPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDDPath.Click

    End Sub
End Class