using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class UpperCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your entered names in Upper case is:");
            Console.WriteLine($"First Name: {firstName.ToUpper()}");
            Console.WriteLine($"Last Name: {lastName.ToUpper()}");

            Console.ReadLine();
        }
    }


}
/* Expected Output
  Enter your First Name:
samiya
Enter your Last Name:
sulthana
Your entered names in Upper case is:
First Name: SAMIYA
Last Name: SULTHANA */