using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            foreach (var item in text)
            {
                stack.Push(item.ToString());
            }
            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
