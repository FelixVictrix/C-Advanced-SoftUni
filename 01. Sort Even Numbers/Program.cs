using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            array = array.Where(x => x % 2 == 0).Select(x => x).OrderBy(x=> x).ToList();
            Console.WriteLine(string.Join(", ",array));
            
        }
    }
}
