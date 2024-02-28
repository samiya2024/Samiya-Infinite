using System;

namespace exercises
{
 
    class Program
    {
        
        static void Main(string[] args)
        {
           
            Console.WriteLine(test(1, 2, 3));  
            Console.WriteLine(test(1, 3, 2));  
            Console.WriteLine(test(1, 1, 1)); 
            Console.WriteLine(test(1, 2, 2));  
            Console.ReadLine();               
        }

     
        public static int test(int x, int y, int z)
        {
            
            var max = Math.Max(x, Math.Max(y, z));

           
            return max;
        }
    }
}
