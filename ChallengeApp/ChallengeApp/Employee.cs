namespace ChallengeApp
{
    //public class User
    public class Employee
    {
        public static string GameName = "Diablo";

        private List<int> scores = new List<int>();
               
        //public Employee(string login, string password)
        public Employee(string firstName, string secondName, string age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }

        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public string Age { get; private set; }

        public int Result
        {
            get
            {
                return this.scores.Sum();
            }
        }

        public void AddScore(int number)
        {
            //       this.score = this.score + number;
            this.scores.Add(number);
        }
         
        //public void WriteNameAndScondName()
        //{
            //       this.score = this.score + number;
            //Console.WriteLine(FirstName + " " + SecondName);
            //Console.WriteLine($"{FirstName} {SecondName} {Age}");
        //}
    }

}
