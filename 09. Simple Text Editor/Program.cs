using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<string>();
            var sb = new StringBuilder();
            stack.Push(sb.ToString());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                if (command == "1")
                {
                    var text = input[1];
                    sb.Append(text);
                    stack.Push(sb.ToString());

                }
                else if (command == "2")
                {
                    var count = int.Parse(input[1]);
                    sb.Remove(sb.Length - count, count);
                    stack.Push(sb.ToString());


                }
                else if (command == "3")
                {
                    var index = int.Parse(input[1]) - 1;
                    Console.WriteLine(sb[index]);
                }
                else if (command == "4")
                {
                    stack.Pop();
                    sb= new StringBuilder();
                    sb.Append(stack.Peek());
                }

            }

        }
    }
}
