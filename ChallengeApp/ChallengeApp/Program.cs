using ChallengeApp;

Employee employee1 = new Employee("Jacek", "Nowak", 33);
Employee employee2 = new Employee("Monika", "Kowalska", 24);
Employee employee3 = new Employee("Stanisław", "Lem", 45);

employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(8);
employee1.AddScore(4);
employee1.AddScore(2);

employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(7);
employee2.AddScore(4);
employee2.AddScore(2);

employee3.AddScore(6);
employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(3);
employee1.AddScore(5);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

var bestResult = -1;
Employee bestEmployee = null;

foreach (var employee in employees)
{
    if (employee.Result > bestResult)
    {
        bestResult = employee.Result;
        bestEmployee = employee;
    }
}

Console.WriteLine("Najlepszy pracownik:" + "\n" + bestEmployee.Name + " " + bestEmployee.Surname + ", wiek: " + bestEmployee.Age + ", wynik: " + bestEmployee.Result);