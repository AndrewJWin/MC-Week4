using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefandOut
{
    class Program
    {
        // Static main for the general Console Session.
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

        // Greeting Method, concatenates a preset string with the provided Name and returns the finalized string.
        static string MakeGreeting(string name)
        {
            return "Hello there, " + name + "!!";
        }

        // FullName Method, accepts a firstName and lastName string input and outputs a fullName string - While also returning the length of the name.
        static int FullName(string firstName, string lastName, out string fullName)
        {
            fullName = firstName + " " + lastName;
            return fullName.Length;
        }

        // Quick Captitalization Method, takes a referenced string and quickly changes the first character into an Uppercase character.
        static void Captialize(ref string fullName)
        {
            fullName = fullName.ToUpper();
        }
    }
}
