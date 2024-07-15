using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesrsonsMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Person, string> personEmails = new Dictionary<Person, string>();
            for (int i = 1; i < 3; i++)
            {
                AddTo(i, personEmails);
            }
            printData(personEmails);

            UpdateEmail(personEmails);
            Console.WriteLine("Updated Dictionary is : ");
            printData(personEmails);

            deleteItem(personEmails);
            Console.WriteLine("\nUpdated Dictionary is : ");
            printData(personEmails);


        }
        public static void deleteItem(Dictionary<Person, string> personEmails)
        {
            Console.WriteLine("Enter the first Name of the person you want to delete : ");
            string fname = Console.ReadLine();
            foreach (var person in personEmails.Keys)
            {
                if (person.FirstName == fname)
                {
                    personEmails.Remove(person);
                    Console.WriteLine("Person Deleted \n");
                    return;
                }
            }
            Console.WriteLine("Person not Found !!");
        }

        public static void UpdateEmail(Dictionary<Person, string> personEmails)
        {
            Console.WriteLine("Enter the first name of the person you want to update email : ");
            string fname = Console.ReadLine();

            foreach (var person in personEmails.Keys)
            {
                if (person.FirstName.Contains(fname))
                {
                    Console.WriteLine("Enter the updated Email : ");
                    personEmails[person] = Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Person not found");

        }
        public static void printData(Dictionary<Person, string> personEmails)
        {
            Console.WriteLine("The information is : ");
            foreach (var person in personEmails)
            {
                Console.WriteLine(person.Key.FirstName + " " + person.Key.LastName + " : " + person.Value );
            }
            Console.WriteLine();
        }

        public static void AddTo(int i, Dictionary<Person, string> personEmails)
        {
            Person person = new Person();
            Console.WriteLine("Enter the First Name of person " + i + " :");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name of person " + i + " :");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter the email of person " + i + " :");
            string email = Console.ReadLine();

            Console.WriteLine();

            personEmails.Add(person, email);
            return;
        }

    }
    }
