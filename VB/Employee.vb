Public Class Employee

    Private nameField As String
    Public Property Name As String
        Get
            Return nameField
        End Get

        Set(ByVal value As String)
            nameField = value
        End Set
    End Property
    Private addressField As String
    Public Property Address As String
        Get
            Return addressField
        End Get

        Set(ByVal value As String)
            addressField = value
        End Set
    End Property
    Public Sub New(ByVal name As String, ByVal address As String)
        nameField = name
        addressField = address
    End Sub
End Class
