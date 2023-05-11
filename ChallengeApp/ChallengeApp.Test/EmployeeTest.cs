namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectMaxValue()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(2);
            
            var statistics = employee.GetStatistics();

            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectMinValue()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(2);
           
            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectAverageValue()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(4);
            
            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Average);
        }
      
        [Test]
        public void GradeAsFloat()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade(6f);
            employee.AddGrade(2);
            employee.AddGrade(4);
            
            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, Math.Round(statistics.Average));
        }
        
        [Test]
        public void GradeAsDouble()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade(6d);
            employee.AddGrade(2);
            employee.AddGrade(4);
            
            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, Math.Round(statistics.Average));
        } 
        
        [Test]
        public void GradeAsString()
        {
            var employee = new Employee("Bob", "Johnson");
            employee.AddGrade("6");
            employee.AddGrade(2);
            employee.AddGrade(4);
            
            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Average);
        }
    }
}