using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefandOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your First Name.");
            string firstName = Console.ReadLine();
            string message = MakeGreeting(firstName);
            Console.WriteLine(message);

            Console.WriteLine("Please type your Last Name.");
            string lastName = Console.ReadLine();

            int nameLength = FullName(firstName, lastName, out string fullName);
            Console.WriteLine("Your full name is " + fullName + ", it has " + nameLength.ToString() + " Characters.");

            Captialize(ref fullName);
            Console.WriteLine("Your full name capitalized is: " + fullName);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static string MakeGreeting(string name)
        {
            return "Hello there, " + name + "!!";
        }

        static int FullName(string firstName, string lastName, out string fullName)
        {
            fullName = firstName + " " + lastName;
            return fullName.Length;
        }

        static void Captialize(ref string fullName)
        {
            fullName = fullName.ToUpper();
        }
    }
}
