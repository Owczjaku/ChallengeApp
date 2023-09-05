
namespace ChallengeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void MaxGradeTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(4);
            employee.AddGrade(5);
            employee.AddGrade('D');
            employee.AddGrade(9);



            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(20f, result.Max);




        }

        [Test]
        public void MinGradeTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('B');
            employee.AddGrade('7');
            employee.AddGrade(8);
            employee.AddGrade(4);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(4, result.Min);

        }


        [Test]
        public void AverageLetterGradeTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(8);
            employee.AddGrade(4);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual('B', result.AverageLetter);

        }

        [Test]
        public void AverageGradeTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(6);
            employee.AddGrade(6);
            employee.AddGrade(8);
            employee.AddGrade(4);

            // act
            var result = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, result.Average);

        }



    }

}
