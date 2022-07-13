using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            prices = prices.Select(p => p * 1.20).ToList();
            prices.ForEach(p=> Console.WriteLine($"{p:f2}"));
        }
    }
}
