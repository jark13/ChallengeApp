
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
        public void WhenUserColletsPoints_ShouldReturnCorrectMin()
        {
            //arrange
            var employee = new EmployeeNew("Anna", "Nowak");
            employee.AddGrade(25);
            employee.AddGrade(3);
            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(7);

            //act
            //var statistics = user.AddGrade;

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WhenUserColletsPoints_ShouldReturnCorrectAverages()
        {
            //arrange
            var emplyee = new EmployeeNew("Anna", "Nowak");
            // emplyee.AddGrade(25);
            //emplyee.AddGrade(3);
            //emplyee.AddGrade(10);
            //emplyee.AddGrade(15);
            //emplyee.AddGrade(7);
            emplyee.AddGrade(2);
            emplyee.AddGrade(2);
            emplyee.AddGrade(6);

            //act
            var statistics = emplyee.GetStatistics();

            //assert
            //Assert.AreEqual(12, statistics.Average);
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenUserColletsPoints_ShouldReturnCorrectMax()
        {
            //arrange
            var emplyee = new EmployeeNew("Anna", "Nowak");
            emplyee.AddGrade(25);
            emplyee.AddGrade(3);
            emplyee.AddGrade(10);
            emplyee.AddGrade(15);
            emplyee.AddGrade(7);

            //act
            var statistics = emplyee.GetStatistics();

            //assert
             Assert.AreEqual(25, statistics.Max);
        }

        [Test]
        public void WhenUserExpressedByLetterColletsPoints_ShouldReturnCorrectMax()
        {
            //arrange
            var emplyee = new EmployeeNew("Anna", "Nowak");
            emplyee.AddGrade('a');
            emplyee.AddGrade('b');
            emplyee.AddGrade('c');
            emplyee.AddGrade('d');
            emplyee.AddGrade('e');

            //act
            var statistics = emplyee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenUserExpressedByLetterColletsPoints_ShouldReturnCorrectMin()
        {
            //arrange
            var emplyee = new EmployeeNew("Anna", "Nowak");
            emplyee.AddGrade('A');
            emplyee.AddGrade('B');
            emplyee.AddGrade('C');
            emplyee.AddGrade('D');
            emplyee.AddGrade('E');

            //act
            var statistics = emplyee.GetStatistics();

            //assert
            Assert.AreEqual(20, statistics.Min);
        }

        public void WhenUserExpressedByLetterColletsPoints_ShouldReturnCorrectAverages()
        {
            //arrange
            var emplyee = new EmployeeNew("Anna", "Nowak");
            emplyee.AddGrade('A');
            emplyee.AddGrade('B');
            emplyee.AddGrade('C');
            emplyee.AddGrade('D');
            emplyee.AddGrade('E');

            //act
            var statistics = emplyee.GetStatistics();

            //assert
            Assert.AreEqual(60, statistics.Average);
        }


        private Employee GetUser(string firstName, string secondName, string age)
        {
            return new Employee(firstName, secondName, age);
        }

    }
}
