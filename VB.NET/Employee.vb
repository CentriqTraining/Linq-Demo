
Public Class Employee
    Private _Expenses As List(Of Expense) = New List(Of Expense)
    Public Property ID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Position As String
    Public Property Salary as Decimal
    Public Property TerminationDate As DateTime

    Public ReadOnly Property Expenses As List(Of Expense)
        Get
            Return _Expenses
        End Get
    End Property
End Class

Public Class Expense
 
    Public Property Description As String
    Public Property Cost As Decimal
End Class
