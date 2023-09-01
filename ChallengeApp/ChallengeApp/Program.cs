
using ChallengeApp;
{
    var employee = new Employee("Jakub", "Rak");
    employee.AddGrade("Jakub");
    employee.AddGrade("4000");
    employee.AddGrade(2);
    employee.AddGrade(5.5);
    employee.AddGrade(444);


    var statistics = employee.GetStatistics();

    Console.WriteLine($"Min:  + {statistics.Min}");
    Console.WriteLine($"Max:  + {statistics.Max}");
    Console.WriteLine($"Average:  + {statistics.Average}", "N2");
}





