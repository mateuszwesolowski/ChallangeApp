using ChallangeApp;

var employee = new Employee("Krzysztof", "Malinowski");

//employee.AddGrade("Jan");
//employee.AddGrade("4000");
employee.AddGrade(1.4);
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: { statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

var statistics2 = employee.GetStatisticsWithForEach();

Console.WriteLine("Statystyki za pomocą GetStatisticsWithForEach");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithFor();

Console.WriteLine("Statystyki za pomocą GetStatisticsWithFor");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Statystyki za pomocą GetStatisticsWithDoWhile");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");

var statistics5 = employee.GetStatisticsWithWhile();

Console.WriteLine("Statystyki za pomocą GetStatisticsWithWhile");
Console.WriteLine($"Average: {statistics5.Average:N2}");
Console.WriteLine($"Min: {statistics5.Min}");
Console.WriteLine($"Max: {statistics5.Max}");


void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}