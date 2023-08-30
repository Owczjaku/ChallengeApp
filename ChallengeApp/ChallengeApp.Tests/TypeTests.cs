namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestIntValueTwoNumbersAreEqual()
        {
            // arrange
            int number1 = 2;
            int number2 = 2;


            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestRefferenceTypeTwoNamesAreEqual()
        {
            // arrange

            var employee1 = new Employee("Jakub", "Rak", 41);
            var employee2 = new Employee("Joanna", "Nowak", 27);


            // act


            // assert
            Assert.AreNotEqual(employee1.Name, employee2.Name);
        }

        [Test]
        public void TestFloatValueTwoNumbersAreNotEqual()
        {
            // arrange

            float f1 = 145557;
            float f2 = 344256;

            // act


            // assert
            Assert.AreNotEqual(f1, f2);
        }

        [Test]
        public void TestStringValueTwoNotEqualNames()
        {
            // arrange

            string name1 = "Joanna";
            string name2 = "Paweł";

            // act


            // assert
            Assert.AreNotEqual(name1, name2);
        }




        private Employee GetEmployee(string name) 
        {
            return new Employee(name);

        }
    }
}