﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var command = input[0];

                switch (command)
                {
                    case 1:
                        var element = input[1];
                        stack.Push(element);
                        break;
                    case 2:
                        if (stack.Any())
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }
            if (stack.Any())
            {
                Console.WriteLine(string.Join(", ",stack));
            }
        }
    }
}
