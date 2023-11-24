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
        // Projection in Linq or Select any item from list
        var names = employees.Select(e => e.FirstName);
      
       
       // Projection in Linq or Select Uniq item (No Duplicate) from list
       var uinqNames= employees.Select(e => e.FirstName).Distinct();
       
       // Sorting in Linq
       // Sort by firtName
       var orderedByFirstName = employees.OrderBy(e => e.FirstName);
       
       // Sort by firtName and LastName
       var orderedByFirstNameLastName = employees.OrderBy(e => e.FirstName).ThenBy(e=>e.LastName);
       
       // filter in Linq, it will return a collection
       var filterData = employees.Where(e => e.Age > 30).ToList();
       filterData.ForEach(emp=> Console.WriteLine($"Id {emp.Id}, First Name {emp.FirstName}, " +
                                                $"Last Name {emp.LastName}, Department {emp.Department}, Age {emp.Age}, Salary {emp.Salary}"));
       
       // filter only One item based on condtion but it will throw an error if employee not found
       Employee emp = employees.First(e => e.FirstName == "Meesam");
       
       // filter only One item based on condtion but it will return default if employee not found
       Employee emp1 = employees.First(e => e.FirstName == "Meesam1");
       if (emp1 == null)
       {
           Console.WriteLine("Employee not found");
       }


       /*foreach (var emp in employees)
       {
           Console.WriteLine($"Id {emp.Id}, First Name {emp.FirstName}, Last Name {emp.LastName}, Department {emp.Department}, Age {emp.Age}, Salary {emp.Salary}");
       }*/
    }
}