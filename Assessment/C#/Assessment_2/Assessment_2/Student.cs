using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Testing the classes
            Undergraduate undergraduateStudent = new Undergraduate("Samiya", 12345, 85.0);
            Console.WriteLine($"Graduate Student: {undergraduateStudent.Name}, ID: {undergraduateStudent.StudentId}, Grade: {undergraduateStudent.Grade}");
            Console.WriteLine($"Is Passed: {undergraduateStudent.IsPassed(undergraduateStudent.Grade)}");

            Graduate graduateStudent = new Graduate("Harry", 54321, 75.0);

            Console.WriteLine($"Graduate Student: {graduateStudent.Name}, ID: {graduateStudent.StudentId}, Grade: {graduateStudent.Grade}");
            Console.WriteLine($"Is Passed: {graduateStudent.IsPassed(graduateStudent.Grade)}");
            Console.ReadLine();

        }
    }

}