using ChallengeApp;



Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
var employee = new Employee("Jakub", "Rak");




while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        
        employee.AddGrade(input);   
    }


    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"AVGLETTER: {statistics.AverageLetter}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");


