using System;
using System.Text.RegularExpressions;

namespace Deliverable_1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Create a password with the following requirements:" + "\n");
            Console.WriteLine("- At least one lowercase letter");
            Console.WriteLine("- At least one uppercase letter");
            Console.WriteLine("- At least minimum 7 characters");
            Console.WriteLine("- At least maximum 12 characters");
            Console.WriteLine("- An exclamation point: !" + "\n");

            Console.Write("Enter password: ");

            //declare variables

            string password = Console.ReadLine();
            var hasUpperChar = new Regex(@"[A-Z]");
            var hasLowerChar = new Regex(@"[a-z]");
            int minLength = 7;
            int maxLength = 12;
            var meetsLengthRequirements = password.Length >= minLength && password.Length <= maxLength;

            //validate variables

            if (hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password) && password.Contains("!") && meetsLengthRequirements)
            {
                Console.WriteLine("\n" + "Password valid and accepted!");
            } else
            {
                Console.WriteLine("\n" + "Error!");
            }
        }
    }
}
