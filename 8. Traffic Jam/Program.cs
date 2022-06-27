using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Queue<string> queueOfCars = new Queue<string>();

            string input = Console.ReadLine();
            int count = 0;

            while (input != "end")
            {
                if (input != "green")
                {
                    queueOfCars.Enqueue(input);
                }
                else
                {
                    if (n > queueOfCars.Count)
                    {
                        n = queueOfCars.Count;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        count++;
                        Console.WriteLine($"{queueOfCars.Dequeue()} passed!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
