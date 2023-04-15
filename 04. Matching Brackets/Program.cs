using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = stack.Peek();
                    int lenght = i - stack.Pop() + 1;
                    string print = input.Substring(startIndex, lenght);
                    Console.WriteLine(print);
                }
            }

        }
    }
}
