using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letterCount
{
    class letterCount
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char letterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine();

            
            int count = 0;
            foreach (char c in inputString)
            {
                if (char.ToUpper(c) == char.ToUpper(letterToCount))
                {
                    count++;
                }
            }

            
            Console.WriteLine($"The letter '{letterToCount}' appears {count} times in the given string.");

            Console.ReadLine();
        }
    }
}
//Expected Output
/*Enter a string:
SAMIYAAAA
Enter the letter to count:
A
The letter 'A' appears 5 times in the given string.*/
