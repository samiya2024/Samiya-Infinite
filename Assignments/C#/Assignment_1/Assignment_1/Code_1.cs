using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_1
{
    class Code_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive:");
            Console.WriteLine("-------------------------------------------");
            string input1 = "Python";
            int position1 = 1;
            Console.WriteLine("Removed " + position1 + " in Python : " + Remove(input1, position1));


            string input2 = "Python";
            int position2 = 0;
            Console.WriteLine("Removed " + position2 + " in Python : " + Remove(input2, position2));


            string input3 = "Python";
            int position3 = 4;
            Console.WriteLine("Removed " + position3 + " in Python : " + Remove(input3, position3));
            Console.ReadLine();
        }

        static string Remove(string input, int position)
        {
            if (position >= 0 && position < input.Length)
            {
                return input.Remove(position, 1);
            }
            else
            {

                Console.WriteLine("Invalid position");
                Console.ReadLine();
                return input;
            }
        }
    }
}