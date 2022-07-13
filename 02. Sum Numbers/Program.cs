using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine($"{array.Length}\n{array.Sum()}");

        }
    }
}
