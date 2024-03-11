using System;
using System.Collections.Generic;
using System.Linq;

class assign3_2
{
    static void Main()
    {
        List<string> words = new List<string> { "amsterdam", "bloom", "apple", "apex", "elm" };

        var result = words
            .Where(word => word.ToLower().StartsWith("a") && word.ToLower().EndsWith("m"))
            .ToList();

        Console.WriteLine("Words starting with 'a' and ending with 'm':");
        Console.ReadLine();
        foreach (var word in result)
        {
            Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}