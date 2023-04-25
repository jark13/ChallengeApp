
using System.Runtime.Intrinsics.X86;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestForInts()
        {
            //arrange
            int number1 = 3;
            int number2 = 7;
            
            //assert         
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TestForStrings()
        {
            //arrange
            string number1 = "Adam";
            string number2 = "Adam";

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            //arrange
            var user1 = GetUser("Marek", "Nowak", "33");
            var user2 = GetUser("Marek", "Nowak", "33");

   
            //Assert.AreEqual(user1.Age, user2.Age);
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void TestForFloats()
        {
            //arrange
            var user1 = GetUser("Anna", "Kowalska", "13");
            var user2 = GetUser("Krzysztof", "Nowak", "13");

            //assert
            Assert.AreEqual(user1.Age, user2.Age);

        }

        [Test]
        public void WhenUserColletsPoints_ShouldReturnCorrectSumAsResult()
        {
            //arrange
            var user = new Employee("Agnieszka", "Nowak", "25");
            user.AddScore(25);
            user.AddScore(5);
            user.AddScore(-10);
            user.AddScore(-10);
            user.AddScore(-10);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(0, result);

        }



        private Employee GetUser(string firstName, string secondName, string age)
        {
            return new Employee(firstName, secondName, age);
        }

    }
}
