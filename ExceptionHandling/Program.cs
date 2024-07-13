using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] number = { 1, 2, 3, 4, 5, 6, 7, };
                Console.WriteLine(number[9]); //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured: Index is out of range ");
            }

            finally
            {
                Console.WriteLine("Execution Successful!");
            }
        }
    }
}
