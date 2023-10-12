using ChallangeApp;

var employee = new Employee("Krzysztof", "Malinowski");

employee.AddGrade("Jan");
employee.AddGrade("4000");
employee.AddGrade(1.4);
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: { statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}