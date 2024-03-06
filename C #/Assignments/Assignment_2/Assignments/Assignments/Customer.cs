using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Customer
    {
        private int customerId;
        private string name;
        private int age;
        private string phone;
        private string city;


        public Customer()
        {
            // Default constructor
        }


        public Customer(int customerId, string name, int age, string phone, string city)
        {
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }


        public static void DisplayCustomer()
        {
            Console.WriteLine("Displaying customer information:");
            Console.WriteLine("No customer information available.");
        }

        // Destructor
        ~Customer()
        {
            Console.WriteLine($"Customer with ID {customerId} is being destroyed.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Example Usage
            Customer.DisplayCustomer();
            Customer customer1 = new Customer(1, "John Doe", 25, "123-456-7890", "New York");

            Console.WriteLine("\nDisplaying customer information using the object:");
            Customer.DisplayCustomer();
            Console.ReadLine();


        }
    }
}