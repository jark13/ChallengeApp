﻿using ChallengeApp;

var employee = new EmployeeNew("Marek", "Kowalski");
employee.AddGrade("Marek");
employee.AddGrade("2000");
employee.AddGrade(2);
employee.AddGrade(4);

var statistics = employee.GetStatisticsWithForEach();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}