using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenUserCollectTwoPoints_ShouldReuturnCoorrectResult()
        {
            var employee = new Employee("Jakub", "Rak", 41);
            employee.AddScore(3);
            employee.AddScore(7);

            var result = employee.Result;

            Assert.AreEqual(10, result);
        }

        [Test]
        public void WhenUserCollectTwoNegativePoints_ShouldReuturnCoorrectResult()
        {
            var employee = new Employee("Pawe³", "Przyby³", 33);
            employee.AddScore(-1);
            employee.AddScore(-5);

            var result = employee.Result;

            Assert.AreEqual(-6, result);

        }

        [Test]

        public void WhenUserCollectNegativeAndPostiviePoints_ShouldReuturnCoorrectResult()
        { 
              var employee = new Employee("Joanna", "Nowak", 27);
              employee.AddScore(-3);
              employee.AddScore(2);

            var result = employee.Result;

        Assert.AreEqual(-1, result);
            }

            

    }
}