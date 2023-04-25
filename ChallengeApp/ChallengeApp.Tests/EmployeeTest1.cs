

namespace ChallengeApp.Tests
{
    public class Tests
    {   
        [Test]
        public void WhenUserColletTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            //arrange
            var user = new Employee("Jarek", "Krzywanski", "18");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-3);
            user.AddScore(-5);
            user.AddScore(-3);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(0, result);
            
        }
    }
}