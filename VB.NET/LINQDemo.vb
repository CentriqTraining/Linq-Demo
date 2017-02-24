Imports System.IO

Module Module1
    Enum days
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
        Sunday
    End Enum

    Public Sub ChangeValue(ByVal obj As Object)
        CInt(obj) = 10
    End Sub
    Sub Main()
        '•	Get me the employee with ID of 5

        '•	Get me the employees sorted by Lastname…then by firstname

        '•	Employees sorted by DateTerminated Descending, then by last name Ascending

        '•	Get me the employees each grouped by Title.

        '•	How many employees have been terminated this year?

        '•	All employees terminated

        '•	What is the total bill for this employee’s expenses

        '•	What is the smallest salary

        '•	What is the largest salary

        '•	What is the average employee salary

        '•	I am paging this list in the ASP.NET page…just give me the first 10 employees

        '•	I am paging this list in the ASP.NET page…give me the second 10 employees

        '•	Just give me the first employee

        '•	Give me the first employee, unless there are none…then don’t error please.

        '•	Give me the last employee

        '•	Give me the last employee, unless there are none…then don’t error please.

        '•	Convert my query to a single object.  I know it will return exactly 1, but error if there are more than one.

        '•	Convert my query to a single object.  I believe it will return exactly 1.  Don’t error if there are none, but do error if there are more than one.

        '•	While this condition is true…return each items.

        '•	While this condition is true, skip all these.

        '•	Get me the employees list plus this other list (or single item) as one list.

        '•	Get me the employees that are also in this list.

        '•	Get me the employees that are not in this list.

        ''''''''''''''       Projection()
        '•	Get me the employees in this department, but I only want the ID and the //  first and last name as one property.

        '•	Get me the employees as a List<T>

        '•	Get me the employees as an array

        '•	Get me the employees as a dictionary containing the Id as the key and the employee as the object.

        '•	All the distinct lastname, Id combination from employees 

    End Sub


End Module
