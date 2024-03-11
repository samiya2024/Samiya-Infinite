using System;
using System.Collections.Generic;
using System.Linq;

class assign3_1
{
    static void Main()
    {
        List<int> numbers = new List<int> { 7, 2, 30 };

        var result = numbers
            .Select(n => new { Number = n, Square = n * n })
            .Where(pair => pair.Square > 20)
            .ToList();

        Console.WriteLine("Numbers and their squares greater than 20:");
        foreach (var pair in result)
        {
            Console.WriteLine($"{pair.Number}: {pair.Square}");
            Console.ReadLine();
        }
    }
}