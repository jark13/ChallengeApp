namespace ChallengeApp
{
    public class EmployeeNew
    {
        private List<float> grades = new List<float>();
        public EmployeeNew(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {

            //int valueInInt = (int)grade;
            //int valueInInt = Math.Ceiling(grade);
            //int valueInInt = Math.Floor(grade);
            //float f = (float)valueInInt;
            //float f = valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }


        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }


        public void AddGrade(byte grade)
        {
            //int valueInInt = (float)grade;
            this.AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {
            //int valueInInt = (float)grade;
            this.AddGrade((float)grade);
        }

        public void AddGrade(double grade)
        {
            //int valueInInt = (float)grade;
            this.AddGrade((float)grade);
        }


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            //statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
