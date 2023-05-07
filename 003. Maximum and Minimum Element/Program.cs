using System;
using System.Collections.Generic;
using System.Linq;

namespace _003._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            int queries = int.Parse(Console.ReadLine());

            for (int i = 0; i < queries; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int query = input[0];

                switch (query)
                {
                    case 1:
                        stack.Push(input[1]); break;
                    case 2:
                        if (stack.Any())
                            stack.Pop(); break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any()) Console.WriteLine(stack.Min());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
