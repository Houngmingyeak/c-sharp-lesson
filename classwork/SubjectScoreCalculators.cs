using System;

namespace First_Day.classwork
{
    public class SubjectScoreCalculators
    {
        public static void CalculateScores()
        {
            double total = 0;
            int totalSubjects = 5;

            for (int i = 1; i <= totalSubjects; i++)
            {
                Console.Write($"Enter score for Subject {i}: ");
                double score = double.Parse(Console.ReadLine());
                total += score;
            }

            double average = total / totalSubjects;

            Console.WriteLine("========================");
            Console.WriteLine($"Total Sum : {total:F2}");
            Console.WriteLine($"Average   : {average:F2}");
        }
    }
}