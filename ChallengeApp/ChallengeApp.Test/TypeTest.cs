namespace ChallengeApp.Test
{
    public class TypeTest
    {
        [Test]
        public void WhenFloatsAreDifferent_ShouldReturnNotEqual()
        {
            //arrange
            float num1 = 14.32f;
            float num2 = 23.13f;

            //assert
            Assert.AreNotEqual(num1, num2);
        }

        [Test]
        public void WhenStringsHaveSameInput_ShouldReturnEqual()
        {
            //arrange
            string name1 = "Andrew";
            string name2 = "Andrew";

            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void WhenIntsHaveDifferentValues_ShouldReturnNotEqual()
        {
            //arrange
            int number1 = 3;
            int number2 = 7;

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenEmployeesHaveDifferentNames_ShouldReturnNotEqualObjectsNames()
        {
            //arrange
            var employee1 = GetEmployee("Andrew");
            var employee2 = GetEmployee("Fabian");

            //assert
            Assert.AreNotEqual(employee1.Name, employee2.Name);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }

        [Test]
        public void WhenEmployeesHaveSameName_ShouldReturnNotEqualObjectsValue()
        {
            //arrange
            var employee1 = GetEmployee("John");
            var employee2 = GetEmployee("John");

            //assert
            Assert.IsFalse(employee1.Equals(employee2));
        }
    }
}
