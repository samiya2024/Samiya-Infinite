using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public class Doctor
    {
      
        private int regnNo;
        private string name;
        private decimal feesCharged;

        
        public int RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }

      
        public void SetValues(int regnNo, string name, decimal feesCharged)
        {
            RegnNo = regnNo;
            Name = name;
            FeesCharged = feesCharged;
        }

       
        public void Display()
        {
            Console.WriteLine("Doctor Information:");
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();

           
            Console.WriteLine("Enter doctor's registration number:");
            int regnNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter doctor's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter fees charged by the doctor:");
            decimal feesCharged = Convert.ToDecimal(Console.ReadLine());

           
            doctor.SetValues(regnNo, name, feesCharged);

            
            doctor.Display();

            Console.ReadLine();
        }
    }
}
/*EXPECTED OUTPUT
  Enter doctor's registration number:
8097
Enter doctor's name:
Samiya Sulthana
Enter fees charged by the doctor:
2000
Doctor Information:
Registration Number: 8097
Name: Samiya Sulthana
Fees Charged: ? 2,000.00*/
