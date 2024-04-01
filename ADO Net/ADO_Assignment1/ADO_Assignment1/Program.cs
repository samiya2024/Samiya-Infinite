using System;
using System.Collections.Generic;
using System.Linq;

namespace ADO_Assignment_1
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

    class Program
    {
        static void Main(string[] args)
        {
            // Populate the list with employee records
            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            // 1. Display a list of all the employees who have joined before 1/1/2015
            var joinedBefore2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("1. Employees who have joined before 1/1/2015:");
            foreach (var emp in joinedBefore2015)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, City: {emp.City}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 2. Display a list of all the employees whose date of birth is after 1/1/1990
            var dobAfter1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("2. Employees whose date of birth is after 1/1/1990:");
            foreach (var emp in dobAfter1990)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, City: {emp.City}, DOB: {emp.DOB}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 3. Display a list of all the employees whose designation is Consultant and Associate
            var consultantAndAssociate = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("3. Employees whose designation is Consultant and Associate:");
            foreach (var emp in consultantAndAssociate)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 4. Display total number of employees
            Console.WriteLine($"4. Total number of employees: {empList.Count}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 5. Display total number of employees belonging to “Chennai”
            var countChennai = empList.Count(e => e.City == "Chennai");
            Console.WriteLine($"5. Total number of employees belonging to Chennai: {countChennai}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 6. Display highest employee id from the list
            var maxEmployeeID = empList.Max(e => e.EmployeeID);
            Console.WriteLine($"6. Highest employee ID from the list: {maxEmployeeID}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 7. Display total number of employee who have joined after 1/1/2015
            var countJoinedAfter2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"7. Total number of employees who have joined after 1/1/2015: {countJoinedAfter2015}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 8. Display total number of employee whose designation is not “Associate”
            var countNotAssociate = empList.Count(e => e.Title != "Associate");
            Console.WriteLine($"8. Total number of employees whose designation is not Associate: {countNotAssociate}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 9. Display total number of employee based on City
            var totalCountByCity = empList.GroupBy(e => e.City).Select(g => new { City = g.Key, Total = g.Count() });
            Console.WriteLine("9. Total number of employees based on City:");
            foreach (var item in totalCountByCity)
                 {
                Console.WriteLine($"City: {item.City}, Total: {item.Total}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 10. Display total number of employee based on city and title
            var totalCountByCityTitle = empList.GroupBy(e => new { e.City, e.Title }).Select(g => new { City = g.Key.City, Title = g.Key.Title, Total = g.Count() });
            Console.WriteLine("10. Total number of employees based on City and Title:");
            foreach (var item in totalCountByCityTitle)
            {
                Console.WriteLine($"City: {item.City}, Title: {item.Title}, Total: {item.Total}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");

            // 11. Display total number of employee who is youngest in the list
            var youngestEmployeeDOB = empList.Min(e => e.DOB);
            var youngestEmployees = empList.Where(e => e.DOB == youngestEmployeeDOB);
            Console.WriteLine("11. Employee who is youngest in the list:");
            foreach (var emp in youngestEmployees)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, DOB: {emp.DOB}");
            }
            Console.WriteLine($"Total number of employees who are youngest in the list: {youngestEmployees.Count()}");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
