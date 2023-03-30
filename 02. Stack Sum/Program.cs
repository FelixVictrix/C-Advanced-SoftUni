using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(array);

            while (stack.Any())
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];

                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    int addFirst = int.Parse(input[1]);
                    int addSecond = int.Parse(input[2]);
                    stack.Push(addFirst);
                    stack.Push(addSecond);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(input[1]);

                    if (count > stack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
            }

            if (stack.Any())
            {
                Console.WriteLine($"Sum: {stack.Sum()}");
            }
        }
    }
}
