
using System.Collections.Generic;
using System;
public class Employee
{
    private List<Expense> _Expenses = new List<Expense>();
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime TerminationDate { get; set; }

    public List<Expense> Expenses
    { get { return _Expenses; } }
}

public class Expense
{
    public string Description { get; set; }
    public decimal Cost { get; set; }
}
