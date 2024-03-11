using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Concession;
namespace Test
{
    class Program
    {

        private const int TotalFare = 1500;

        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                TicketConcession ticketConcession = new TicketConcession(name, age);

                ticketConcession.CalculateConcession();
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer.");
                Console.ReadLine();
            }
        }
    }
}
