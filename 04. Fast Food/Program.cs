using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {

            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queueOfOrders = new Queue<int>(orders);

            Console.WriteLine(queueOfOrders.Max());

            while (food > 0 && queueOfOrders.Count > 0)
            {
                int current = queueOfOrders.Peek();

                if (food - current < 0)
                {
                    break;
                }
                else
                {
                    food -= current;
                    queueOfOrders.Dequeue();
                }
            }

            if (queueOfOrders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queueOfOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
