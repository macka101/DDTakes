Imports System.Windows.Forms

Public Class AskDate

    Public Property SelectedDate() As Date

        Get
            Return dteDate.EditValue
        End Get

        Set(ByVal Value As Date)
            dteDate.EditValue = Value
        End Set

    End Property


    Public Sub New(ByVal pText As String, ByVal pDate As Date)

        ' This call is required by the designer.
        InitializeComponent()
        lblText.Text = pText
        dteDate.EditValue = pDate
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AskDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class