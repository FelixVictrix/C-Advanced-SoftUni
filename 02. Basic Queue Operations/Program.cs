using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toDequ = array[1];
            int toPeek = array[2];

            Queue<int> queue = new Queue<int>(numbers);



            for (int i = 0; i < toDequ; i++)
            {
                queue.Dequeue();
            }
            if (!queue.Any())
            {
                Console.WriteLine("0");
                return;
            }
            string isTrue = queue.Contains(toPeek)
                ? "true"
                : $"{queue.Min()}";
            Console.WriteLine(isTrue);
        }
    }
}
