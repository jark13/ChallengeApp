using ChallengeApp;

var employee = new EmployeeNew("Marek", "Kowalski");
employee.AddGrade("Marek");
employee.AddGrade("2000");
employee.AddGrade(4);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}