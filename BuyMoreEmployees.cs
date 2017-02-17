using System.Collections.Generic;
using System;
public class BuyMoreEmployees
{
    private List<Employee> _Employees;

    public BuyMoreEmployees()
    {
        _Employees = InitEmployees();
    }
    public List<Employee> Employees
    {
        get
        {
            return _Employees;
        }
    }

    private List<Employee> InitEmployees()
    {
        List<Employee> retVal  = new List<Employee>();
        retVal.Add(new Employee()  {ID = 1, FirstName = "Michael", LastName = "Tucker", Salary = 18.00M, Position = "Manager"});
        retVal.Add(new Employee()  {ID = 2, FirstName = "Morgan", LastName = "Grimes", Salary = 12.00M,Position = "Asst. Manager"});
        retVal.Add(new Employee()  {ID = 3, FirstName = "Emmett", LastName = "Milbarge", Salary = 14.00M,Position = "Asst. Manager", TerminationDate = DateTime.Parse("1/31/2012")});
        retVal.Add(new Employee()  {ID = 4, FirstName = "Harry", LastName = "Tang", Salary = 12.00M,Position = "Asst. Manager", TerminationDate = DateTime.Parse("1/31/2011")});
        retVal.Add(new Employee()  {ID = 5, FirstName = "Diane", LastName = "Beckman", Salary = 22.00M,Position = "Manager"});
        retVal.Add(new Employee()  {ID = 6, FirstName = "John", LastName = "Casey", Salary = 10.00M,Position = "Green Shirt"});
        retVal.Add(new Employee()  {ID = 7, FirstName = "Fernando", Salary = 9.00M,Position = "Green Shirt"});
        retVal.Add(new Employee()  {ID = 8, FirstName = "Bunny", Salary = 9.00M,Position = "Green Shirt"});

        Employee chuck = new Employee()  {ID = 9, FirstName = "Chuck", LastName = "Bartowski", Salary = 13.00M, Position = "Nerd Herd"};
        chuck.Expenses.Add(new Expense()  {Description = "Install in Paris", Cost = 4300});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 30});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 50});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 75});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 240});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 43});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 14});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 400});
        chuck.Expenses.Add(new Expense()  {Description = "Install", Cost = 300});
        retVal.Add(chuck);

        retVal.Add(new Employee() { ID = 10, FirstName = "Jeffrey", LastName = "Barnes", Salary = 11.25M, Position = "Nerd Herd, Apple" });
        retVal.Add(new Employee() { ID = 11, FirstName = "Lester", LastName = "Patel", Salary = 11.25M, Position = "Nerd Herd, Apple" });
        retVal.Add(new Employee() { ID = 12, FirstName = "Skip", LastName = "Johnson", Salary = 12.00M, Position = "Nerd Herd" });
        retVal.Add(new Employee() { ID = 13, FirstName = "Anna", LastName = "Wu", Salary = 9.00M, Position = "Nerd Herd", TerminationDate = DateTime.Parse("1/31/2012") });
        retVal.Add(new Employee() { ID = 14, FirstName = "Hannah", LastName = "", Salary = 8.00M, Position = "Nerd Herd", TerminationDate = DateTime.Parse("1/31/2012") });
        retVal.Add(new Employee() { ID = 15, FirstName = "Greta", LastName = "", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2012")});
        retVal.Add(new Employee() { ID = 16, FirstName = "Rick", LastName = "Noble", Salary = 8.00M, Position = "Green Shirt" });
        retVal.Add(new Employee() { ID = 17, FirstName = "Victoria", LastName = "Dunwoody", Salary = 8.00M, Position = "Green Shirt" });
        retVal.Add(new Employee() { ID = 18, FirstName = "Moses", LastName = "Finkelstein", Salary = 180.00M, Position = "Founder" });
        retVal.Add(new Employee() { ID = 19, FirstName = "Porter", LastName = "Bauer", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 20, FirstName = "Marvin", LastName = "Gadsby", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 21, FirstName = "Cecil", LastName = "Goldenberg", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 22, FirstName = "Christina", LastName = "James", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 23, FirstName = "Ruben", LastName = "Mango", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 24, FirstName = "Sal", LastName = "Sawaya", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 25, FirstName = "Skye", LastName = "Stoinitz", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 26, FirstName = "Leticia", LastName = "Williams", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        retVal.Add(new Employee() { ID = 27, FirstName = "Sarah", LastName = "Yang", Salary = 8.00M, Position = "Green Shirt", TerminationDate = DateTime.Parse("1/31/2010") });
        return retVal;
    }
}
