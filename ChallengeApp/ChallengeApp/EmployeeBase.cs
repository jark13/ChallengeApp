namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }


        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Sex { get; private set; }

        //public virtual void SayHello()
        //{
        //    Console.WriteLine($"Hello! I am {Name} {Surname}");
        //}

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(byte grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();

        public abstract Statistics GetStatisticsWithDoWhile();

        public abstract Statistics GetStatisticsWithFor();

        public abstract Statistics GetStatisticsWithForEach();

        public abstract Statistics GetStatisticsWithWhile();
        
    }
}
