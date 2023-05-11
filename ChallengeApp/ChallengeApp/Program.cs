using ChallengeApp;

var employee1 = new Employee("Jack", "Hill");
var employee2 = new Employee("Monika", "Aldrich");
var employee3 = new Employee("Stanisław", "Lem");

employee1.AddGrade("Michael");
employee1.AddGrade("300");
employee1.AddGrade(2);
employee1.AddGrade(6);
employee1.AddGrade(6.3f);

var statistics  = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Maximum: {statistics.Max}");
Console.WriteLine($"Minimum: {statistics.Min}");