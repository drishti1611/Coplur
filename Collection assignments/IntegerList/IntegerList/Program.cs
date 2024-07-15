using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intlist = new List<int>();
            intlist.Add(31);
            intlist.Add(26);
            intlist.Add(32);
            intlist.Add(14);
            intlist.Add(51);
            intlist.Add(46);
            intlist.Add(67);
            intlist.Add(28);
            intlist.Add(69);
            intlist.Add(10);

            intlist.Sort();
            Console.WriteLine("The numbers in ascending order:");
            Showintlist(intlist);

            intlist.Reverse();
            Console.WriteLine("the numbers in descending order:");
            Showintlist(intlist);

            Console.WriteLine("Do you want to find any number in the list? Yes or No");
            string ans=Console.ReadLine();
            ans=ans.ToUpper();
            if(ans=="YES")
            {
                Console.WriteLine("Enter the number you want to search:");
                int nos = Convert.ToInt32(Console.ReadLine());

                if (intlist.Contains(nos))
                {
                    Console.WriteLine(nos+" is present in the string");
                }

                else
                {
                    Console.WriteLine(nos + " isn't present in the string");
                }
            }
            else
            {
                return;
            }
            
            Console.ReadLine();
        }
        public static void Showintlist(List<int> intlist)
        {
            foreach (int i in intlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

        }

    }
}
