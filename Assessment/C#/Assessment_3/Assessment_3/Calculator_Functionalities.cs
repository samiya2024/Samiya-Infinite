using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    delegate int CalculatorDelegate(int a, int b);
    class Calculator_Functionalities
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

   
            CalculatorDelegate add = Add;
            CalculatorDelegate subtract = Subtract;
            CalculatorDelegate multiply = Multiply;

           
            int sum = PerformOperation(add, num1, num2);
            int difference = PerformOperation(subtract, num1, num2);
            int product = PerformOperation(multiply, num1, num2);

       
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.ReadLine();
        }

      
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }


        static int PerformOperation(CalculatorDelegate operation, int a, int b)
        {
            return operation(a, b);
        }
    }
}
