using System;
using System.Collections;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> names = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            int tossCount = int.Parse(Console.ReadLine());

            int count = 1;

            while (names.Count > 1)
            {
                string name = names.Dequeue();

                if (count == tossCount)
                {
                    Console.WriteLine($"Removed {name}");
                    count = 0;
                }
                else
                {
                    names.Enqueue(name);
                }
                count++;
            }
            Console.WriteLine($"Last is {names.Peek()}");
        }
    }
}
