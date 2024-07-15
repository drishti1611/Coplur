using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSubjectScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> stdScores = new Dictionary<string, List<int>>();
            stdScores.Add("Naina", new List<int> { 90, 98, 95 });
            stdScores.Add("Kabir", new List<int> { 89, 95, 85 });
            stdScores.Add("Bunny", new List<int> { 70, 68, 85 });

            foreach (var student in stdScores)
            {
                Console.WriteLine($"Student: {student.Key}");
                Console.WriteLine("Scores: " + string.Join(", ", student.Value));
            }
            Console.WriteLine();

            string topStudent = "";
            double highestAverage = 0;

            foreach (var student in stdScores)
            {
                double average = student.Value.Average();
                Console.WriteLine($"Average score for {student.Key}: {average:F2}");
                if (average > highestAverage)
                {
                    highestAverage = average;
                    topStudent = student.Key;
                }


            }
            Console.WriteLine($"The student with the highest average score is {topStudent} with an average of {highestAverage:F2}.");
            Console.ReadLine();
        }
    }
}
