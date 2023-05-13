using ChallengeApp;

//Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
//Console.WriteLine("===========================================");
////Console.WriteLine();

var employee = new EmployeeInFile("Mark", "Kowalski", "Male");
employee.AddGrade(53.0f);
employee.AddGrade('B');
employee.AddGrade(9);
employee.AddGrade('a');




//var employee = new EmployeeInMemory("Marek", "Nowak", "Male");
//employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika (jeśli koniec, nacisnij 'q/Q') :");
//    var input = Console.ReadLine();
//    if (input == "q" || input == "Q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N3}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");