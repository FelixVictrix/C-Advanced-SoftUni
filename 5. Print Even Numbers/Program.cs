using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            array = array.Where(x => x % 2 == 0).ToArray();
            Queue<int> queue = new Queue<int>(array);

            Console.WriteLine(string.Join(", ", queue));

        }
    }
}
