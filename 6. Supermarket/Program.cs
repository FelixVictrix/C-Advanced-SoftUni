using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    Console.WriteLine(string.Join("\n",names));
                    names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }
                

                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
