using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        private int rollNo;
        private string name;
        private string className;
        private int semester;
        private string branch;
        private int[] marks = new int[5];

        // Constructor
        public Student(int rollNo, string name, string className, int semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        // Method to input marks for 5 subjects
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        // Method to calculate average marks and display result
        public void DisplayResult()
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }

            double average = sum / (double)marks.Length;

            Console.WriteLine($"Average Marks: {average}");
            Console.ReadLine();

            // Check for passing or failing criteria
            if (marks.Any(mark => mark < 35) || average < 50)
            {
                Console.WriteLine("Result: Failed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Result: Passed");
                Console.ReadLine();
            }
        }

        // Method to display all data
        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");

            Console.WriteLine("Marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Example Usage
            Student student = new Student(101, "John Doe", "12th", 2, "Computer Science");

            // Input marks
            student.GetMarks();

            // Display result
            student.DisplayResult();

            // Display all data
            student.DisplayData();
        }
    }
}