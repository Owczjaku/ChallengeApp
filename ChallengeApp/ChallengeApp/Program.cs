
using ChallengeApp;
{ 
var employee = new Employee("Jakub", "Rak");
employee.AddGrade(4);
employee.AddGrade(5);
employee.AddGrade(1);
employee.AddGrade(9);


var statistics = employee.GetStatistics();

Console.WriteLine($"Min:  + {statistics.Min}");



void SetSth(Statistics statistics)
{
    statistics = new Statistics();  
}

}

{ 
var employee = new Employee("Alicja", "Polak");
employee.AddGrade(2);
employee.AddGrade(7);
employee.AddGrade(8);
employee.AddGrade(4);


var statistics = employee.GetStatistics();

Console.WriteLine($"Max:  + {statistics.Max}");

void SetSth2(Statistics statistics)
    { 
    statistics = new Statistics();
    }
}

{ 

var employee = new Employee("Jan", "Nowak");
employee.AddGrade(6);
employee.AddGrade(6);
employee.AddGrade(3);
employee.AddGrade(3);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average:  + {statistics.Average}");

void SetSth3(Statistics statistics)
{
    statistics = new Statistics();
}

}