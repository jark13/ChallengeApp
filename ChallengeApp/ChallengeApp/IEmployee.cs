namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        
        string Surname { get; }

        string Sex { get; }

        void AddGrade(float grade);

        void AddGrade(char grade);

        void AddGrade(byte grade);

        void AddGrade(long grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(string grade);

        Statistics GetStatistics();

        Statistics GetStatisticsWithForEach();

        Statistics GetStatisticsWithFor();

        Statistics GetStatisticsWithDoWhile();

        Statistics GetStatisticsWithWhile();
    }
}
