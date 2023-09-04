using ChallengeApp;

var employee = new Employee("Jakub", "Rak");
employee.AddGrade("Jakub");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(5.5);
employee.AddGrade(444);

var statistics1 = employee.GetStatisticsWitchForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine($"GetStatisticsWithForEach: Average: {statistics1.Average:N2}, Min: {statistics1.Min}, Max: {statistics1.Max}");
Console.WriteLine($"GetStatisticsWithFor: Average: {statistics2.Average:N2}, Min: {statistics2.Min}, Max: {statistics2.Max}");
Console.WriteLine($"GetStatisticsWithDoWhile: Average: {statistics3.Average:N2}, Min: {statistics3.Min}, Max: {statistics3.Max}");
Console.WriteLine($"GetStatisticsWithWhile: Average: {statistics4.Average:N2}, Min: {statistics4.Min}, Max: {statistics4.Max}");


//Console.WriteLine($"Min:  + {statistics.Min}");
//Console.WriteLine($"Max:  + {statistics.Max}");
//Console.WSriteLine($"Average:  + {statistics.Average}", "N2");