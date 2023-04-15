using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);

            int sum = 0;

            while (stack.Count > 0)
            {
                string action = stack.Pop();

                if (action == "+")
                {
                    sum += int.Parse(stack.Pop());
                }
                else if (action == "-")
                {
                    sum -= int.Parse(stack.Pop());
                }
                else
                {
                    sum = int.Parse(action);
                }

            }
            Console.WriteLine(sum);
        }
    }
}
