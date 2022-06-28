using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {

            var clothes = Console.ReadLine().Split().Reverse().Select(int.Parse).ToArray();
            var rackCap = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            var racks = 1;
            var sum = 0;

            while (stack.Count > 0)
            {
                var first = stack.Peek();

                if (sum + first > rackCap)
                {
                    racks++;
                    sum = 0;
                }
                else
                {
                    sum += first;
                    stack.Pop();
                }
            }
            Console.WriteLine(racks);
        }
    }
}
