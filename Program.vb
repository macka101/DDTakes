﻿
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace Sage2CRM
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            DevExpress.Skins.SkinManager.EnableFormSkins()
            DevExpress.Skins.SkinManager.EnableMdiFormSkins()
            XpoDefault.RegisterBonusProviders()
            Dim CnString = Sage2CRMSettings.GetSetting("ACCOUNTSCONNECTION")
            If CnString = "" Then
                Sage2CRMSettings.SetSetting("ACCOUNTSCONNECTION", "Data Source=ALLIANCE-SQL;Initial Catalog=CRM;integrated security=SSPI")
            End If
            CnString = Sage2CRMSettings.GetSetting("CRMCONNECTION")
            If CnString = "" Then
                Sage2CRMSettings.SetSetting("CRMCONNECTION", "Data Source=ALLIANCE-SQL;Initial Catalog=CRM;integrated security=SSPI")
            End If

            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly)
            Application.Run(New DDPayments())
        End Sub
    End Class
End Namespace
