using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stdMrks = new Dictionary<string, int>();
            stdMrks.Add("Harry", 76);
            stdMrks.Add("Hermoine", 97);
            stdMrks.Add("Ron", 72);
            stdMrks.Add("Draco", 81);
            stdMrks.Add("Luna", 89);

            PrintDict(stdMrks);

            UpdateDict(stdMrks, "Harry", 80);
            PrintDict(stdMrks);

            stdMrks.Remove("Luna");
            PrintDict(stdMrks);

            MarksOf(stdMrks,"Hermoine");
           
            Console.ReadLine();
        }

        public static void MarksOf(Dictionary<string, int> stdMrks,string name)
        {
            Console.WriteLine(name+ " has scored " + stdMrks[name]+" marks");
        }
        public static void UpdateDict(Dictionary<string, int> stdMrks, string name, int marks)
        {
            stdMrks[name] = marks;
            Console.WriteLine("marks updated");
        }
        public static void PrintDict(Dictionary<string, int> stdMrks)
        {
            Console.WriteLine("Student's name and marks are-");
            foreach (var data in stdMrks)
            {
                Console.WriteLine(data.Key + " : " + data.Value);
            }
            Console.WriteLine();
        }
    }
}
