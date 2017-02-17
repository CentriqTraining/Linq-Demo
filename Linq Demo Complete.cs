using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new BuyMoreEmployees();

            //•	Get me the employee with ID of 5
            var TheDude2 = ctx.Employees.Find(emp => emp.ID == 5);
            var thedude3 = ctx.Employees.Where(emp => emp.ID == 5).FirstOrDefault();
            var thedude4 = ctx.Employees.FirstOrDefault(emp => emp.ID == 5);
            var thedude5 = (from emp in ctx.Employees
                            where emp.ID == 5
                            select emp).FirstOrDefault();

            //•	Get me the employees sorted by Lastname…
            //then by firstname
            var b = ctx.Employees
                .OrderBy(emp => emp.LastName)
                .ThenBy(emp => emp.FirstName);


            //•	Employees sorted by DateTerminated Descending, 
            //then by last name Ascending
            var c = ctx.Employees
                .OrderByDescending(emp => emp.TerminationDate)
                .ThenBy(emp => emp.FirstName);


            //•	Get me the employees each grouped by Title.
            var d = ctx.Employees.GroupBy(emp => emp.Position);
            foreach (var item in d)
            {
                Console.WriteLine(item.Key);
                foreach (var emp in item)
                {
                    Console.WriteLine(emp.LastName + ", " + emp.FirstName);
                }
            }

            ////•	How many employees have been terminated this year?
            var e = ctx.Employees.Where(emp => emp.TerminationDate.HasValue && emp.TerminationDate.Value.Year == DateTime.Now.Year);

            ////•	All employees terminated
            var f = ctx.Employees.Where(emp => emp.TerminationDate.HasValue);

            ////•	What is the total bill for this employee’s expenses
            var g = ctx.Employees
                .Find(emp => emp.ID == 9)
                .Expenses
                .Sum(exp => exp.Cost);


            ////•	What is the smallest salary
            var h = ctx.Employees.Min(emp => emp.Salary);

            ////•	What is the largest salary
            var i = ctx.Employees.Max(emp => emp.Salary);

            ////•	What is the average employee salary
            var j = ctx.Employees.Average(emp => emp.Salary);

            ////•	I am paging this list in the ASP.NET page…
            ////just give me the first 10 employees
            var k = ctx.Employees.Take(10);

            ////•	I am paging this list in the ASP.NET page…
            ////give me the second 10 employees
            var l = ctx.Employees.Skip(10).Take(10);


            ////•	Just give me the first employee
            var m = ctx.Employees.First();


            ////•	Give me the first employee, unless there are none
            ////…then don’t error please.
            var n = ctx.Employees.FirstOrDefault();

            ////•	Convert my query to a single object.  
            ////I know it will return exactly 1, 
            ////  but error if there are more than one.
            var o = ctx.Employees.Single();


            ////•	Convert my query to a single object.  
            ////I believe it will return exactly 1.  
            ////  Don’t error if there are none, 
            ////but do error if there are more than one.
            var p = ctx.Employees.SingleOrDefault();

            ////•	Get me the employees list plus this other list (or single item) as one list.
            var q = ctx.Employees.Union(f);

            ////•	Get me the employees that are also in this list.
            var r = ctx.Employees.Intersect(f);

            ////•	Get me the employees that are not in this list.
            var s = ctx.Employees.Except(f);

            //////////////////////////////       Projection()
            ////•	Get me the employees in this department, 
            ////but I only want the ID and the 
            ////  first and last name as one property.
            var t = ctx.Employees.Select(emp => new { emp.ID,LastFirst=emp.LastName + ", " + emp.FirstName });

            ////•	Get me the employees as a List<T>
            var u = ctx.Employees.ToList();

            ////•	Get me the employees as an array
            var v = ctx.Employees.ToArray();


            ////•	Get me the employees as a dictionary containing the 
            ////  Id as the key and the employee as the object.
            var w = ctx.Employees.ToDictionary(emp => emp.ID);

            ////•	All the distinct lastname, Position combinations from employees 
            var x = ctx.Employees
                .Select(emp => new { emp.LastName, emp.Position })
                .Distinct();

            //•	All the employees and the sum of their expenses
            var y = ctx.Employees.Select(emp => new { emp, TotalExpenses = emp.Expenses.Sum(exp => exp.Cost) });
            
        }

    }
}