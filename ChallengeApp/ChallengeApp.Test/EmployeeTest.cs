namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectMaxValue()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade('A');
            employee.AddGrade(30);
            employee.AddGrade(22.3f);
            employee.AddGrade(42.3d);
            employee.AddGrade("50");

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectMinValue()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade('A');
            employee.AddGrade(30);
            employee.AddGrade(22.3f);
            employee.AddGrade(42.3d);
            employee.AddGrade("50");

            var statistics = employee.GetStatistics();

            Assert.AreEqual(22.3, Math.Round(statistics.Min, 1));
        }

        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectAverageValue()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade('A');
            employee.AddGrade('a');
            employee.AddGrade("60");
            employee.AddGrade(60);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(80, statistics.Average);
        }

        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectAverageLetterValue()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade('b');
            employee.AddGrade(50);
            employee.AddGrade('E');

            var statistics = employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}