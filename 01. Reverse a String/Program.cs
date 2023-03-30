using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            foreach (char s in input)
            {
                stack.Push(s.ToString());
            }
             
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + "");
            }

        }
    }
}
