using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = Console.ReadLine().Split();
            Queue<string> queueNames = new Queue<string>(names);

            int count = int.Parse(Console.ReadLine());

            while (queueNames.Count > 1)
            {
                int currCount = 0;
                int end = queueNames.Count;
                Stack<string> stack = new Stack<string>();

                for (int i = 0; i < end; i++)
                {
                    currCount++;
                    if (currCount != count)
                    {
                        stack.Push(queueNames.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine($"Removed {queueNames.Dequeue()}");
                    }
                }
                queueNames = new Queue<string>(stack);
            }
            Console.WriteLine($"Last is {queueNames.Peek()}");
        }
    }
}
