using System;
using System.Collections.Generic;
using System.Linq;

namespace _002._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int toEnqueue = values[0];
            int toDequeue = values[1];
            int toPeek = values[2];

            Queue<int> queue = new Queue<int>(numbers);

            DequeueElements(queue, toDequeue);
            Console.WriteLine(PeekElement(queue, toPeek));

        }

        static string PeekElement(Queue<int> queue, int toPeek)
        {
            string isTrue = string.Empty;

            if (!queue.Any())
            {
                isTrue = "0";
            }
            else
            {
                isTrue = queue.Contains(toPeek)
                    ? "true"
                    : queue.Min().ToString();
            }
            
            return isTrue;
        }

        static void DequeueElements(Queue<int> queue, int toDequeue)
        {
            for (int i = 0; i < toDequeue; i++)
            {
                queue.Dequeue();
            }
        }
    }
}
