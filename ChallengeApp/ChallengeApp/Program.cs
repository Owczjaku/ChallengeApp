using ChallengeApp;



Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Wyybierz ocenę od 1 do 6");
Console.WriteLine("Wszystkie oceny mają przypisaną wartość");
Console.WriteLine("Ocena 6 to 160, 5 to 130, 4 to 100, 3 to 70, 2 to 30, 1 to 0 ");
Console.WriteLine("Żeby podać wyniku wciśnij q");
Console.WriteLine("===========================================");

var supervisor = new Supervisor("Jakub", "Rak");




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

        supervisor.AddGrade(input);
    }


    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = supervisor.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"AVGLETTER: {statistics.AverageLetter}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");


