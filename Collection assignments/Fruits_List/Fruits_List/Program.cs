
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruits_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");
            fruits.Add("Kiwi");
            fruits.Add("Plum");

            Showfruits(fruits);

            Addfruit("strawberry",fruits);
            Showfruits(fruits);
            
            fruits.Remove("Banana");
            Showfruits(fruits);

            RemoveFruit("Apple", fruits);
            Showfruits(fruits);

            string name = fruits[2];
                Console.WriteLine(name+" is the second fruit in the list");
            Console.WriteLine();

            foreach(string fruit in fruits)
            {
                fruit.ToUpper();
            }

            Console.WriteLine("Do you want to check any fruit in the list? Yes or no?");
            string ans= Console.ReadLine();
            if(ans=="yes")
            {
                Console.WriteLine("Write the name of the fruit.");
                string frt= Console.ReadLine();
                frt=frt.ToUpper();

                if (fruits.Contains(frt))
                {
                    Console.WriteLine(frt + " exists in the last updated list");
                }
                else
                {
                    Console.WriteLine(frt + " isn't in the updated list.");
                }
            }
            else 
            {
                return;
            }
                Console.ReadLine();
        }

        public static void RemoveFruit(string name, List<string> fruits)
        {
            fruits.Remove(name);
            Console.WriteLine(name +" is now removed.");
        }
        public static void Addfruit(string Fruit, List<string> Fruits)
        {
            Fruits.Add((string)Fruit);
            Console.WriteLine("New fruit added is: "+ Fruit);
            //Console.WriteLine();
        }
        public static void Showfruits(List<string> Fruits)
        {
            foreach (string Fruit in Fruits)
            {
                Console.WriteLine(Fruit);
            }
            Console.WriteLine();
        }
       
    }
}
