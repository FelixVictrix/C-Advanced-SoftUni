using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int num = int.Parse(Console.ReadLine());

            Func<int, int, bool> isDiv = (x, y) => x % y == 0;

            numbers = numbers.Where(x => !isDiv(x, num)).ToArray();
            Console.WriteLine(string.Join(" ", numbers));



        }
    }
}
