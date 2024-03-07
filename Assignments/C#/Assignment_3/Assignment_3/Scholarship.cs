using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    public class Scholarship
    {
        public decimal Merit(int marks, decimal fees)
        {
            decimal scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2m * fees; 
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3m * fees; 
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5m * fees; 
            }

            return scholarshipAmount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the scholarship calculator!");

            
            Console.WriteLine("Enter student's marks:");
            int studentMarks = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter tuition fees:");
            decimal tuitionFees = Convert.ToDecimal(Console.ReadLine());

            Scholarship scholarship = new Scholarship();
            decimal scholarshipAmount = scholarship.Merit(studentMarks, tuitionFees);

            Console.WriteLine($"The scholarship amount for marks {studentMarks} is: {scholarshipAmount:C}");

            Console.ReadLine();
        }
    }
}
//EXPECTED OUTPUT
/* Welcome to the scholarship calculator!
Enter student's marks:
80
Enter tuition fees:
100000
The scholarship amount for marks 80 is: ? 20,000.00
*/
