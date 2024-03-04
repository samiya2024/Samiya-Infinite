using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            swap();
            //String();

            // max();
            Console.ReadLine();
        }
        static void String()
        {
            Console.WriteLine("Enter any String:- ");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the index of Char, you want to remove:- ");
            int idx = Convert.ToInt32(Console.ReadLine());
            string newStr = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {

                if (i == idx)
                {
                    continue;
                }
                else
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine(newStr);

        }
        static void swap()
        {
            Console.WriteLine("Enter any Word:- ");
            string str = Convert.ToString(Console.ReadLine());
            int last = str.Length;
            string newStr = string.Empty;
            newStr += str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
            Console.WriteLine(newStr);
        }
        static void max()
        {
            Console.WriteLine("Enter any three Integers:- ");
            int[] a = new int[3];
            int max = int.MinValue;
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("The max number is:- " + max);
        }
    }
}