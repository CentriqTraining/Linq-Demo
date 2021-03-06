﻿Public Class BuyMoreEmployees
    Private _Employees As List(Of Employee)

    Public Sub New()
        _Employees = InitEmployees()
    End Sub
    Public Function InitEmployees() As List(Of Employee)
        Dim retVal As List(Of Employee) = New List(Of Employee)
        retVal.Add(New Employee() With {.Id = 1, .FirstName = "Michael", .LastName = "Tucker", .Salary= 18.00, .Position = "Manager"})
        retVal.Add(New Employee() With {.Id = 2, .FirstName = "Morgan", .LastName = "Grimes", .Salary=12.00, .Position = "Asst. Manager"})
        retVal.Add(New Employee() With {.Id = 3, .FirstName = "Emmett", .LastName = "Milbarge", .Salary=14.00, .Position = "Asst. Manager", .TerminationDate = CDate("1/31/2012")})
        retVal.Add(New Employee() With {.Id = 4, .FirstName = "Harry", .LastName = "Tang", .Salary=12.00, .Position = "Asst. Manager", .TerminationDate = CDate("1/31/2011")})
        retVal.Add(New Employee() With {.Id = 5, .FirstName = "Diane", .LastName = "Beckman", .Salary=22.00, .Position = "Manager"})
        retVal.Add(New Employee() With {.Id = 6, .FirstName = "John", .LastName = "Casey", .Salary=10.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 7, .FirstName = "Fernando", .Salary=9.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 8, .FirstName = "Bunny", .Salary=9.00, .Position = "Green Shirt"})

        Dim chuck As Employee = New Employee() With {.Id = 9, .FirstName = "Chuck", .LastName = "Bartowski", .Salary=13.00, .Position = "Nerd Herd"}
        chuck.Expenses.Add(New Expense() With {.Description = "Install in Paris", .Cost = 4300})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 30})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 50})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 75})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 240})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 43})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 14})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 400})
        chuck.Expenses.Add(New Expense() With {.Description = "Install", .Cost = 300})
        retVal.Add(chuck)

        retVal.Add(New Employee() With {.Id = 10, .FirstName = "Jeffrey", .LastName = "Barnes", .Salary=11.25, .Position = "Nerd Herd, Apple"})
        retVal.Add(New Employee() With {.Id = 11, .FirstName = "Lester", .LastName = "Patel", .Salary=11.25, .Position = "Nerd Herd, Apple"})
        retVal.Add(New Employee() With {.Id = 12, .FirstName = "Skip", .LastName = "Johnson", .Salary=12.00, .Position = "Nerd Herd"})
        retVal.Add(New Employee() With {.Id = 13, .FirstName = "Anna", .LastName = "Wu", .Salary=9.00, .Position = "Nerd Herd"})
        retVal.Add(New Employee() With {.Id = 14, .FirstName = "Hannah", .LastName = "", .Salary=8.00, .Position = "Nerd Herd", .TerminationDate = CDate("1/31/2012")})
        retVal.Add(New Employee() With {.Id = 15, .FirstName = "Greta", .LastName = "", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 16, .FirstName = "Rick", .LastName = "Noble", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 17, .FirstName = "Victoria", .LastName = "Dunwoody", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 18, .FirstName = "Moses", .LastName = "Finkelstein", .Salary=180.00, .Position = "Founder"})
        retVal.Add(New Employee() With {.Id = 19, .FirstName = "Porter", .LastName = "Bauer", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 20, .FirstName = "Marvin", .LastName = "Gadsby", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 21, .FirstName = "Cecil", .LastName = "Goldenberg", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 22, .FirstName = "Christina", .LastName = "James", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 23, .FirstName = "Ruben", .LastName = "Mango", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 24, .FirstName = "Sal", .LastName = "Sawaya", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 25, .FirstName = "Skye", .LastName = "Stoinitz", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 26, .FirstName = "Leticia", .LastName = "Williams", .Salary=8.00, .Position = "Green Shirt"})
        retVal.Add(New Employee() With {.Id = 27, .FirstName = "Sarah", .LastName = "Yang", .Salary=8.00, .Position = "Green Shirt"})
        Return retVal
    End Function
End Class
