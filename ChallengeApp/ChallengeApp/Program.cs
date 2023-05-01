using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeNew();
//var employee = new EmployeeNew("Marek", "Nowak");


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika (jeśli koniec, nacisnij 'q/Q') :");
    var input = Console.ReadLine();
    if(input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N3}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


//SetSth(out statistics);
//void SetSth(out Statistics statistics)
//{
//    statistics = new Statistics();
//}