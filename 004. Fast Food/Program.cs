using System;
using System.Collections.Generic;
using System.Linq;

namespace _004._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foodQuantity = int.Parse(Console.ReadLine());

            var ordersQuantity = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ordersQueue = new Queue<int>(ordersQuantity);

            var biggestOrder = ordersQueue.Max();
            Console.WriteLine(biggestOrder);

            while (ordersQueue.Any())
            {
                var currentOrderQuantity = ordersQueue.Peek();

                if (currentOrderQuantity > foodQuantity)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
                    return;
                }

                foodQuantity -= ordersQueue.Dequeue();
            }

            Console.WriteLine("Orders complete");

        }
    }
}
