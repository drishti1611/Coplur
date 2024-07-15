using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> data = new Dictionary<string,double>();
            data.Add("Suit", 1100);
            data.Add("Saree", 4499);
            data.Add("Bedsheet", 799);
            data.Add("Curtain", 1400);
            data.Add("Handicraft", 3999);

            Printdata(data);

            double average= AvgPrice(data);
            Console.WriteLine("The average is : " + average);
            Console.WriteLine();

            String exp= ExpPrice(data);
            Console.WriteLine("The most expensive Product is " + exp + " With Rs." + data[exp]);

            Console.ReadLine();
        }
        public static string ExpPrice(Dictionary<string, double> data)
        {
            var sortedDic = from product in data orderby product.Value descending select product;

            var first = sortedDic.First();
            return first.Key;

        }

        public static double AvgPrice(Dictionary<string, double> data)
        {
            double sum = 0;
            int count = 0;
            foreach (var key in data)
            {
                sum += key.Value;
                count++;
            }
            return (double)sum / count;
        }

            public static void Printdata(Dictionary<string, double> data) 
        {
            Console.WriteLine("The products and their prices are ");
            foreach (var product in data)
            {
                Console.WriteLine(product.Key + " : Rs." + product.Value);
            }

            Console.WriteLine();
        }
    }
}
