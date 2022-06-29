using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var item in input)
            {             
                if (item == '{' || item == '[' || item == '(')
                {
                    stack.Push(item);
                }
                else if (true)
                {

                }
            }

        }
    }
}
