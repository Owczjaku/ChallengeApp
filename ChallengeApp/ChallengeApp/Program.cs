using ChallengeApp;

Employee employee1 = new Employee("Jakub", "Rak", 41 );
Employee employee2 = new Employee("Joanna", "Nowak", 27);
Employee employee3 = new Employee("Paweł", "Przybył", 33);


employee1.AddScore(4);
employee1.AddScore(7);
employee1.AddScore(5);
employee1.AddScore(1);
employee1.AddScore(9);


employee2.AddScore(2);
employee2.AddScore(7);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(3);


employee3.AddScore(3);
employee3.AddScore(9);
employee3.AddScore(6);
employee3.AddScore(5);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{

    employee1, employee2, employee3

};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{

    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;

    }    
}

Console.WriteLine("Pracownikem z najwyższym wynikiem jest: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + ", wiek: " + employeeWithMaxResult.Age + ", punkty: " + employeeWithMaxResult.Result);