//using ChallengeApp;
//using System.Net.Cache;
//using System.Reflection.Metadata;

//Employee employee1 = new Employee("Adam", "Kowalski", "23");
//Employee employee2 = new Employee("Monika", "Nowak", "33");
//Employee employee3 = new Employee("Zuzia", "Pikowski", "55");


//employee1.AddScore(5);
//employee1.AddScore(3);
//employee1.AddScore(7);
//employee1.AddScore(9);
//employee1.AddScore(6);


//employee2.AddScore(2);
//employee2.AddScore(6);
//employee2.AddScore(7);
//employee2.AddScore(9);
//employee2.AddScore(8);

//employee3.AddScore(1);
//employee3.AddScore(7);
//employee3.AddScore(10);
//employee3.AddScore(5);
//employee3.AddScore(3);

////var result = employee1.Result;
////Console.WriteLine(result);
//var name = Employee.GameName;
////var pi = Math.PI;

//List<Employee> employees = new List<Employee>()
//{
//    employee1, employee2, employee3
//};

//int maxResult = -1;
//Employee employeeWithMaxResult = null;

//foreach (var employee in employees)
//{
// if (employee.Result > maxResult)
//{
//    employeeWithMaxResult = employee;
//    maxResult = employee.Result;
//}
//}

//Console.WriteLine("Pracownik z najwyższą liczbą ocen, to:");

//Console.WriteLine(employeeWithMaxResult.FirstName + "  " + employeeWithMaxResult.SecondName + ", lat "
//    + employeeWithMaxResult.Age + ", z uzyskanymi punktami " + maxResult);

using ChallengeApp;

var employee = new EmployeeNew("Marek", "Kowalski");
employee.AddGrade("Marek");
employee.AddGrade("2000");
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


//void SetSth(Statistics statistics)
//{
//    statistics = new Statistics();
//}

//SetSth(ref statistics);
//void SetSth(ref Statistics statistics)
//{
//    statistics = new Statistics();
//}

SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}