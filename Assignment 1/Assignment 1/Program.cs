using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* equal();
             pn();
             Ops();
             table();
             triplet();
             Days();
             Arr();*/
            marks();
            copy();
            Str();
            same();
            Console.Read();
        }
        static void equal()
        {
            Console.WriteLine("Enter your first number:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:- ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Value of a and b are equal...");
            }
            else
            {
                Console.WriteLine("a and b are not equal...");
            }

        }

        static void pn()
        {
            Console.WriteLine("Enter Any number:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("a is a positive number...");
            }
            else
            {
                Console.WriteLine("a is negative number...");
            }


        }
        static void Ops()
        {
            Console.WriteLine("Enter your first number:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:- ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            Console.WriteLine("a+b = " + c);
            Console.WriteLine("a-b = " + d);
            Console.WriteLine("a*b = " + e);
            Console.WriteLine("a/b = " + f);

        }
        static void table()
        {
            Console.WriteLine("Enter Any number:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int num = a * i;
                Console.WriteLine(a + "*" + i + " =" + num);
            }
        }
        static void triplet()
        {
            Console.WriteLine("Enter your first number:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:- ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                Console.WriteLine("Answer:- " + (a + b));
            }
            else
            {
                Console.WriteLine("Answer:- " + (a * 3));
            }
        }
        static void Days()
        {
            Console.WriteLine("Enter Any number:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Day - Monday");
                    break;
                case 2:
                    Console.WriteLine("Day - Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day - Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day - Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day - Friday");
                    break;
                case 6:
                    Console.WriteLine("Day - Saturday");
                    break;
                case 7:
                    Console.WriteLine("Day - Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        static void Arr()
        {

            int high = 0;
            double avg = 0;
            Console.WriteLine("Enter The size of the Array:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            int low = int.MaxValue;
            Console.WriteLine("Enter the elements:- ");
            for (int i = 0; i < a; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements are- ");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            for (int i = 0; i < a; i++)
            {

                if (low > arr[i])
                {
                    low = arr[i];
                }
                if (high < arr[i])
                {
                    high = arr[i];
                }
            }

            Console.WriteLine("Min num - " + low);
            Console.WriteLine("Max num - " + high);
            for (int i = 0; i < a; i++)
            {
                avg += arr[i];
            }
            Console.WriteLine("Average of all elememnts - " + (avg / a));

        }
        static void marks()
        {
            Console.WriteLine("Enter the name of the Student:- ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the number of subjects:- ");
            int sub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of all Subjects:- ");
            int[] arr = new int[sub];
            for (int i = 0; i < sub; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Marks:- ");
            for (int i = 0; i < sub; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int total = 0;
            for (int i = 0; i < sub; i++)
            {
                total += arr[i];

            }
            Console.WriteLine("\nTotal Marks - " + total);
            double avg = 0;
            for (int i = 0; i < sub; i++)
            {
                avg += arr[i];
            }
            Console.WriteLine("Average - " + (avg / sub));
            int low = int.MaxValue;
            int high = 0;
            for (int i = 0; i < sub; i++)
            {

                if (low > arr[i])
                {
                    low = arr[i];
                }
                if (high < arr[i])
                {
                    high = arr[i];
                }
            }
            Console.WriteLine("Min marks - " + low);
            Console.WriteLine("Max marks - " + high);
            int temp = 0;
            for (int i = 0; i < sub; i++)
            {
                for (int j = i + 1; j < sub; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("Ascending order:- \n");
            for (int i = 0; i < sub; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int tmp = 0;
            for (int i = 0; i < sub; i++)
            {
                for (int j = i + 1; j < sub; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.Write("descending order:- \n");
            for (int i = 0; i < sub; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void copy()
        {
            Console.WriteLine("Enter The size of the Array:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:- ");
            int[] arr1 = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of arr1 are- ");
            for (int i = 0; i < a; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            int[] arr2 = new int[arr1.Length];
            int temp = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                temp = arr1[i];
                arr1[i] = arr2[i];
                arr2[i] = temp;
            }
            Console.Write("Copied Array - ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
        }

        static void Str()
        {
            Console.WriteLine("Enter any word- ");
            String str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("The length of the word is:- " + str.Length);
            string Reverse_str = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Reverse_str += str[i];
            }
            Console.WriteLine("Reverse String - " + Reverse_str);
        }

        static void same()
        {
            Console.WriteLine("Enter first word- ");
            String a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Second word- ");
            String b = Convert.ToString(Console.ReadLine());
            if (a.Equals(b))
            {
                Console.WriteLine("Words are same...");
            }
            else
            {
                Console.WriteLine("Words are not same...");
            }


        }

    }

}