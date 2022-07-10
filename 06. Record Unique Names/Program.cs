using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                names.Add(input);
            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
