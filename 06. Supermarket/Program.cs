using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Paid")
                {
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    names.Clear();
                    continue;
                }

                if (input == "End")
                {
                    Console.WriteLine($"{names.Count()} people remaining.");
                    break;
                }

                names.Enqueue(input);
            }

        }
    }
}
