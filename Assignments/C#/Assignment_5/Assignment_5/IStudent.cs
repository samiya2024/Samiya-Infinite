using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public interface IStudent
    {
        int Student_Id { get; set; }
        string Stu_Name { get; set; }
        void Display_Details();
    }

    public class Day_scholar : IStudent
    {
        public int Student_Id { get; set; }
        public string Stu_Name { get; set; }
        public void Display_Details()
        {
            Console.WriteLine("Dayscholor Student Details:- ");
            Console.WriteLine("Student Id:- " + Student_Id + " And Student Id:- " + Student_Id);
        }
    }

    public class Resident : IStudent
    {
        public int Student_Id { get; set; }
        public string Stu_Name { get; set; }

        public void Display_Details()
        {
            Console.WriteLine("Resident Student Details:- ");
            Console.WriteLine("Student Id:- " + Student_Id + " Student Name:- " + Stu_Name);
        }
    }
    class Student
    {
        public static void Show_Student()
        {

            Console.WriteLine("Enter the id and Name of Dayscholor Student:- ");
            Day_scholar d1 = new Day_scholar();
            d1.Student_Id = Convert.ToInt32(Console.ReadLine());
            d1.Stu_Name = Convert.ToString(Console.ReadLine());

            d1.Display_Details();

            Console.WriteLine();

            Console.WriteLine("Enter the Id and Name of Resident Student:- ");
            Resident r1 = new Resident();
            r1.Student_Id = Convert.ToInt32(Console.ReadLine());
            r1.Stu_Name = Convert.ToString(Console.ReadLine());

            r1.Display_Details();


        }
        static void Main(string[] args)
        {
            Show_Student();
            Console.ReadLine();
        }
    }
}