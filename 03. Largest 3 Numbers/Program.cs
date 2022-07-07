using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           var list = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
