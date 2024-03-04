using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_3
{
    class Code_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Sharp program to check the largest number among three given integers:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Largest integer (1, 2, 3) : " + Largest(1, 2, 3));
            Console.WriteLine("Largest integer (1, 3, 2) : " + Largest(1, 3, 2));
            Console.WriteLine("Largest integer (1, 1, 1) : " + Largest(1, 1, 1));
            Console.WriteLine("Largest integer (1, 2, 2) : " + Largest(1, 2, 2));
            Console.ReadLine();
        }

        static int Largest(int num1, int num2, int num3)
        {
            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }

            return largest;
        }
    }
}