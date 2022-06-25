using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(array);

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                var current = input.Split();
                var command = current[0];

                switch (command)
                {
                    case "add":
                        AddStack(stack, current);
                        break;
                    case "remove":
                        RemoveStack(stack, current);
                        break;
                }
                input = Console.ReadLine().ToLower();
            }
            if (stack.Any())
            {
                int sum = stack.Sum();
                Console.WriteLine($"Sum: {sum}");
            }

        }

        static void RemoveStack(Stack<int> stack, string[] current)
        {
            int remove = int.Parse(current[1]);
            if (stack.Count >= remove)
            {
                int count = 0;
                while (count < remove)
                {
                    stack.Pop();
                    count++;
                }
            }

        }

        static void AddStack(Stack<int> stack, string[] current)
        {
            stack.Push(int.Parse(current[1]));
            stack.Push(int.Parse(current[2]));
        }
    }
}
