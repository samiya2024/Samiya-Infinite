using System;


namespace exercises
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine(test("Python", 1));  
            Console.WriteLine(test("Python", 0));  
            Console.WriteLine(test("Python", 4));  
            Console.ReadLine();                 
        }

        
        public static string test(string str, int n)
        {
            return str.Remove(n, 1);  
        }
    }
}