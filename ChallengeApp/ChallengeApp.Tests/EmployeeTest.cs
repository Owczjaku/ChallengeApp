using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void MinGradeTest()
        {
            // arrange
            var employee = new Employee("Jakub", "Rak");
            employee.AddGrade(4);
            employee.AddGrade(5);
            employee.AddGrade(1);
            employee.AddGrade(9);



            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(1, result.Min);




        }

        [Test]
        public void MaxGradeTest()
        {
            // arrange
            var employee = new Employee("Alicja", "Polak");
            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(4);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(8, result.Max);

        }

        [Test]
        public void AverageGradeTest()
        {
            // arrange
            var employee = new Employee("Jan", "Nowak");
            employee.AddGrade(6);
            employee.AddGrade(6);
            employee.AddGrade(3);
            employee.AddGrade(3);



            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(4.5, result.Average);
        }

    }

}
