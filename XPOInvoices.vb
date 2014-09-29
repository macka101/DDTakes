Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class ConnectionHelper
    Const ConnectionString = "XpoProvider=MSSqlServer;data source=alliance-sql;integrated security=SSPI;initial catalog=AccountsData"

    Public Shared Sub Connect(ByVal autoCreationOption As DB.AutoCreateOption)
        Dim CnString = Sage2CRMSettings.GetSetting("CRMCONNECTION")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(CnString, autoCreationOption)
        XpoDefault.Session = Nothing
    End Sub
    Public Shared Function GetConnectionProvider(ByVal autoCreationOption As DB.AutoCreateOption) As DB.IDataStore
        Dim CnString = Sage2CRMSettings.GetSetting("CRMCONNECTION")
        Return XpoDefault.GetConnectionProvider(CnString, autoCreationOption)
    End Function
    Public Shared Function GetConnectionProvider(ByVal autoCreationOption As DB.AutoCreateOption, ByRef objectsToDisposeOnDisconnect() As IDisposable) As DB.IDataStore
        Dim CnString = Sage2CRMSettings.GetSetting("CRMCONNECTION")
        Return XpoDefault.GetConnectionProvider(CnString, autoCreationOption, objectsToDisposeOnDisconnect)
    End Function
    Public Shared Function GetDataLayer(ByVal autoCreationOption As DB.AutoCreateOption) As IDataLayer
        Dim CnString = Sage2CRMSettings.GetSetting("CRMCONNECTION")
        Return XpoDefault.GetDataLayer(CnString, autoCreationOption)
    End Function
End Class
Public Class DirectDebitHeader
    Inherits XPLiteObject
    Dim fdh_headerid As Long
    <Key(True)> _
    Public Property dh_headerid() As Long
        Get
            Return fdh_headerid
        End Get
        Set(ByVal value As Long)
            SetPropertyValue(Of Long)("dh_headerid", fdh_headerid, value)
        End Set
    End Property
    Dim fdh_date As DateTime
    Public Property dh_date() As DateTime
        Get
            Return fdh_date
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(Of DateTime)("dd_date", fdh_date, value)
        End Set
    End Property
    Dim fdh_Posted As Boolean
    Public Property dh_Posted() As Boolean
        Get
            Return fdh_Posted
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("dh_Posted ", fdh_Posted, value)
        End Set
    End Property
    <Association("DebitDetails")> _
    Public ReadOnly Property dh_DebitDetails() As XPCollection(Of DirectDebitDetails)
        Get
            Return GetCollection(Of DirectDebitDetails)("dh_DebitDetails")
        End Get
    End Property
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Sub New()
        MyBase.New(Session.DefaultSession)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub
End Class
Public Class DirectDebitDetails
    Inherits XPLiteObject
    Dim fDD_id As Long
    <Key(True)> _
    Public Property DD_id() As Long
        Get
            Return fDD_id
        End Get
        Set(ByVal value As Long)
            SetPropertyValue(Of Long)("DD_id", fDD_id, value)
        End Set
    End Property
    Dim fdd_DirectDebitHeader As DirectDebitHeader
    <Association("DebitDetails")> _
    Public Property dd_DirectDebitHeader() As DirectDebitHeader
        Get
            Return fdd_DirectDebitHeader
        End Get
        Set(ByVal value As DirectDebitHeader)
            SetPropertyValue(Of DirectDebitHeader)("dd_DirectDebitHeader", fdd_DirectDebitHeader, value)
        End Set
    End Property
    Dim fdd_date As DateTime
    Public Property dd_date() As DateTime
        Get
            Return fdd_date
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(Of DateTime)("dd_date", fdd_date, value)
        End Set
    End Property
    Dim fdd_duedate As DateTime
    Public Property dd_duedate() As DateTime
        Get
            Return fdd_duedate
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(Of DateTime)("dd_duedate", fdd_duedate, value)
        End Set
    End Property
    Dim fdd_account As String
    <Size(10)> _
    Public Property dd_account() As String
        Get
            Return fdd_account
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("dd_account", fdd_account, value)
        End Set
    End Property
    Dim fdd_value As Decimal
    Public Property dd_value() As Decimal
        Get
            Return fdd_value
        End Get
        Set(ByVal value As Decimal)
            SetPropertyValue(Of Decimal)("dd_value", fdd_value, value)
        End Set
    End Property
    Dim fdd_plan As Integer
    Public Property dd_plan() As Integer
        Get
            Return fdd_plan
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("dd_plan", fdd_plan, value)
        End Set
    End Property
    Dim fdd_comment As String
    <Size(60)> _
    Public Property dd_comment() As String
        Get
            Return fdd_comment
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("dd_comment", fdd_comment, value)
        End Set
    End Property
    Dim fdd_paid As Boolean
    Public Property dd_paid() As Boolean
        Get
            Return dd_paid
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("dd_paid ", fdd_paid, value)
        End Set
    End Property
    Dim fdd_posted As Boolean
    Public Property dd_posted() As Boolean
        Get
            Return fdd_posted
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("dd_posted ", fdd_posted, value)
        End Set
    End Property
    <Association("DebitInvoices")> _
    Public ReadOnly Property dd_DebitInvoices() As XPCollection(Of DirectDebitInvoice)
        Get
            Return GetCollection(Of DirectDebitInvoice)("dd_DebitInvoices")
        End Get
    End Property
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Sub New()
        MyBase.New(Session.DefaultSession)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub
End Class



Public Class DirectDebitInvoice
    Inherits XPLiteObject
    Dim fDI_id As Long
    <Key(True)> _
    Public Property DI_id() As Long
        Get
            Return fDI_id
        End Get
        Set(ByVal value As Long)
            SetPropertyValue(Of Long)("DI_id", fDI_id, value)
        End Set
    End Property

    Dim fdi_DirectDebitDetails As DirectDebitDetails
    <Association("DebitInvoices")> _
    Public Property di_DirectDebitDetails() As DirectDebitDetails
        Get
            Return fdi_DirectDebitDetails
        End Get
        Set(ByVal value As DirectDebitDetails)
            SetPropertyValue(Of DirectDebitDetails)("di_DirectDebitDetails", fdi_DirectDebitDetails, value)
        End Set
    End Property

    Dim fdi_date As DateTime
    Public Property di_date() As DateTime
        Get
            Return fdi_date
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(Of DateTime)("dd_date", fdi_date, value)
        End Set
    End Property
    Dim fdi_account As String
    <Size(10)> _
    Public Property di_account() As String
        Get
            Return fdi_account
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("dd_account", fdi_account, value)
        End Set
    End Property
    Dim fdi_invoice As String
    <Size(10)> _
    Public Property di_invoice() As String
        Get
            Return fdi_invoice
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("di_invoice", fdi_invoice, value)
        End Set
    End Property
    Dim fdi_value As Decimal
    Public Property di_value() As Decimal
        Get
            Return fdi_value
        End Get
        Set(ByVal value As Decimal)
            SetPropertyValue(Of Decimal)("di_value", fdi_value, value)
        End Set
    End Property
    Dim fdi_tran_number As Long
    Public Property di_tran_number() As Integer
        Get
            Return fdi_tran_number
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("di_tran_number", fdi_tran_number, value)
        End Set
    End Property

    Dim fdi_headernumber As Long
    Public Property di_headernumber() As Integer
        Get
            Return fdi_headernumber
        End Get
        Set(ByVal value As Integer)
            SetPropertyValue(Of Integer)("di_headernumber", fdi_headernumber, value)
        End Set
    End Property
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Sub New()
        MyBase.New(Session.DefaultSession)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub
End Class


