using System;
using CSharpLinq;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = DataManager.GetData();
        // Iterate each item in list using Linq
        employees.ForEach(emp => Console.WriteLine($"Id {emp.Id}, First Name {emp.FirstName}, " +
                                                   $"Last Name {emp.LastName}, Department {emp.Department}, Age {emp.Age}, Salary {emp.Salary}"));

        /*foreach (var emp in employees)
        {
            Console.WriteLine($"Id {emp.Id}, First Name {emp.FirstName}, Last Name {emp.LastName}, Department {emp.Department}, Age {emp.Age}, Salary {emp.Salary}");
        }*/
    }
}