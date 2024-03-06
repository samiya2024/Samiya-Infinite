using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2
{
    class Code_2
    {
        static void Main()
        {
            Console.WriteLine("C# Sharp program to exchange the first and last characters in a given string and return the new string:");
            Console.WriteLine("------------------------------------------");


            string input1 = "abcd";
            Console.WriteLine("Exchange the first and last characters : " + ExF_L(input1));


            string input2 = "a";
            Console.WriteLine("Exchange the first and last characters : " + ExF_L(input2));


            string input3 = "xy";
            Console.WriteLine("Exchange the first and last characters : " + ExF_L(input3));
            Console.ReadLine();
        }

        static string ExF_L(string input)
        {
            if (input.Length > 1)
            {
                char firstChar = input[0];
                char lastChar = input[input.Length - 1];




                return lastChar + input.Substring(1, input.Length - 2) + firstChar;
            }
            else
            {

                return input;
            }
        }
    }
}