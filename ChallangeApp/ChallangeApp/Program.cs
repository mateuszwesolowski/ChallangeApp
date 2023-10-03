using ChallangeApp;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

Employee employee1 = new Employee("Jan", "Kowalski", 33);
Employee employee2 = new Employee("Grzegorz", "Malinowski", 40);
Employee employee3 = new Employee("Ala", "Makota", 24);


employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(1);
var result1 = employee1.Result;
Console.WriteLine("Suma wyników pracownika " + employee1.Name + " " + employee1.Surname + " wynosi:" + result1);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(4);
var result2 = employee2.Result;
Console.WriteLine("Suma wyników pracownika " + employee2.Name + " " + employee2.Surname + " wynosi:" + result2);

employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(6);
var result3 = employee3.Result;
Console.WriteLine("Suma wyników pracownika " + employee3.Name + " " + employee3.Surname + " wynosi:" + result3);

List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3 
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult= employee.Result;
    }
}

Console.WriteLine("Pracownikiem z najlepszym wynikiem: " + employeeWithMaxResult.Result + " został/a: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname);