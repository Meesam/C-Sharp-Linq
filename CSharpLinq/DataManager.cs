namespace CSharpLinq;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
}

public class DataManager
{
    public static List<Employee> GetData()
    {
        return new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Meesam", LastName = "Zaidi", Age = 36, Department = "IT", Salary = 100 },
            new Employee { Id = 2, FirstName = "Tarana", LastName = "Zaidi", Age = 35, Department = "Home", Salary = 200 },
            new Employee { Id = 3, FirstName = "Adil", LastName = "Zaidi", Age = 28, Department = "Store", Salary = 300 },
            new Employee { Id = 4, FirstName = "Azra", LastName = "Zaidi", Age = 26, Department = "Bank", Salary = 400 },
            new Employee { Id = 5, FirstName = "Najmi", LastName = "Zaidi", Age = 38, Department = "Shop", Salary = 500 },
            new Employee { Id = 6, FirstName = "Afzal", LastName = "Zaidi", Age = 30, Department = "Shop", Salary = 600 },
            new Employee { Id = 7, FirstName = "Shaista", LastName = "Zaidi", Age = 34, Department = "Home", Salary = 700 },
            new Employee { Id = 8, FirstName = "Shabista", LastName = "Zaidi", Age = 29, Department = "School", Salary = 800 },
        };
    }
}