using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toPush = array[0];
            int toPop = array[1];
            int toPeek = array[2];

            Stack<int> stack = new Stack<int>(numbers);

           

            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }
            if (!stack.Any())
            {
                Console.WriteLine("0");
                return;
            }
            string isTrue = stack.Contains(toPeek)
                ? "true"
                : $"{stack.Min()}";
            Console.WriteLine(isTrue);
        }
    }
}
