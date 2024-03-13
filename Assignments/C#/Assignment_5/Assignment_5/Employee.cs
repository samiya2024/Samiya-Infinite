using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Employee
    {
        public int Emp_id;
        public string Emp_name;
        public float Salary;

        public Employee(int Empid, string Empname, float Salary)
        {
            this.Emp_id = Empid;
            this.Emp_name = Empname;
            this.Salary = Salary;

        }

        class Part_Time_Employee : Employee
        {
            int wages;
            public Part_Time_Employee(int EmpId, string EmpName, float salary, int wages) : base(EmpId, EmpName, salary)
            {
                this.wages = wages;
            }
            public static void Show_Details()
            {
                Console.WriteLine("Enter EmployeeID:- ");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:- ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:- ");
                float Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Wages:- ");
                int wages = int.Parse(Console.ReadLine());


                Part_Time_Employee pt = new Part_Time_Employee(Id, Name, Salary, wages);
                Console.WriteLine();
                Console.WriteLine($"Emp_ID:- {pt.Emp_id}\n");
                Console.WriteLine($"Emp_Name:- {pt.Emp_name}\n");
                Console.WriteLine($"Emp_Salary:- {pt.Salary}\n");
                Console.WriteLine($"Emp_Wages:- {pt.wages}");

            }
            static void Main()
            {
                Show_Details();
                Console.ReadLine();
            }

        }
    }
}
