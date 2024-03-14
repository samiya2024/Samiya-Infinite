using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
               
                new Employee { EmployeeID = 1000, FirstName = "Samiya", LastName = "Sulthana", Title = "Software Engineer", DOB = DateTime.Parse("3/6/2001"), DOJ = DateTime.Parse("1/1/2020"), City = "Bangalore" },
                new Employee { EmployeeID = 1001, FirstName = "Rahul", LastName = "Kumar", Title = "Manager", DOB = DateTime.Parse("16/11/1984"), DOJ = DateTime.Parse("8/6/2011"), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Amit", LastName = "Sharma", Title = "AsstManager", DOB = DateTime.Parse("20/08/1984"), DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Anita", LastName = "Patel", Title = "Consultant", DOB = DateTime.Parse("14/11/1987"), DOJ = DateTime.Parse("12/4/2015"), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Ravi", LastName = "Singh", Title = "SE", DOB = DateTime.Parse("3/6/1990"), DOJ = DateTime.Parse("2/2/2016"), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Priya", LastName = "Yadav", Title = "SE", DOB = DateTime.Parse("8/3/1991"), DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Suresh", LastName = "Mishra", Title = "Consultant", DOB = DateTime.Parse("7/11/1989"), DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Neeta", LastName = "Gupta", Title = "Consultant", DOB = DateTime.Parse("2/12/1989"), DOJ = DateTime.Parse("1/6/2015"), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Vikram", LastName = "Pandey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Sunil", LastName = "Verma", Title = "Associate", DOB = DateTime.Parse("12/8/1992"), DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Anjali", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("12/4/1991"), DOJ = DateTime.Parse("2/1/2016"), City = "Pune" }
            };

            char option;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("a. Display details of all employees");
                Console.WriteLine("b. Display details of employees not in Mumbai");
                Console.WriteLine("c. Display details of AsstManager employees");
                Console.WriteLine("d. Display details of employees whose Last Name starts with 'S'");
                Console.WriteLine("e. Exit");

                option = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (option)
                {
                    case 'a':
                        Console.WriteLine("Details of all employees:");
                        DisplayEmployees(empList);
                        break;
                    case 'b':
                        Console.WriteLine("Details of employees not in Mumbai:");
                        DisplayEmployees(empList.Where(emp => emp.City != "Mumbai").ToList());
                        break;
                    case 'c':
                        Console.WriteLine("Details of AsstManager employees:");
                        DisplayEmployees(empList.Where(emp => emp.Title == "AsstManager").ToList());
                        break;
                    case 'd':
                        Console.WriteLine("Details of employees whose Last Name starts with 'S':");
                        DisplayEmployees(empList.Where(emp => emp.LastName.StartsWith("S")).ToList());
                        break;
                    case 'e':
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            } while (option != 'e');
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
                Console.ReadLine();
            }
        }
    }
}
