namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeOnlyAddScores_ShouldReturnCorrectResult()
        {
            //arragne - przygotowujemy kod
            var employee = new Employee("Walter", "White", 51);
            employee.AddScore(1);
            employee.AddScore(10);
            employee.AddScore(5);

            //act - uruchamimy
            var result = employee.Result;

            //assert - sprawdazmy czy spe³nia
            Assert.AreEqual(16, result);

        }
        
        [Test]
        public void WhenEmployeeOnlySubstractScores_ShouldReturnCorrectResult()
        {
            //arragne - przygotowujemy kod
            var employee = new Employee("Walter", "White", 51);
            employee.SubstractScore(5);
            employee.SubstractScore(7);
            employee.SubstractScore(3);

            //act - uruchamimy
            var result = employee.Result;

            //assert - sprawdazmy czy spe³nia
            Assert.AreEqual(-15, result);

        } 
        [Test]
        public void WhenEmployeeAddAndSubstractScores_ShouldReturnCorrectResult()
        {
            //arragne - przygotowujemy kod
            var employee = new Employee("Walter", "White", 51);
            employee.SubstractScore(5);
            employee.SubstractScore(7);
            employee.AddScore(25);

            //act - uruchamimy
            var result = employee.Result;

            //assert - sprawdazmy czy spe³nia
            Assert.AreEqual(13, result);

        }
    }
}