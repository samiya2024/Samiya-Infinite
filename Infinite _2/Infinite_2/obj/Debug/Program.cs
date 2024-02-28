using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cdn();
        }
        static void Cdn()
        {
            Console.WriteLine("Enter the Name of the student:- ");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Marks of the Student :-");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Enter Your Grade:- ");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Name- " + name + "\nMarks- " + marks);
            Console.Write("Result:- ");

            if (marks <= 33 && marks >= 0 && grade == 'F')
            {
                Console.WriteLine("Failed");
                Console.WriteLine("Grade:- " + grade);
            }
            else if (marks <= 50 && marks > 33 && grade == 'E')
            {
                Console.WriteLine("Need To Improvement");
                Console.WriteLine("Grade:- " + grade);
            }
            else if (marks <= 60 && marks > 50 && grade == 'D')
            {
                Console.WriteLine("Good");
                Console.WriteLine("Grade:- " + grade);
            }

            else if (marks <= 70 && marks > 60 && grade == 'C')
            {
                Console.WriteLine("Very Good");
                Console.WriteLine("Grade:- " + grade);
            }
            else if (marks <= 90 && marks > 70 && grade == 'B')
            {
                Console.WriteLine("Excellent");
                Console.WriteLine("Grade:- " + grade);
            }
            else if (marks <= 100 && marks > 90 && grade == 'A')
            {
                Console.WriteLine("Outstanding");
                Console.WriteLine("Grade:- " + grade);
            }
            else
            {
                Console.WriteLine("Invalid Input...");
            }
            Console.ReadLine();

        }
    }
}