using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> pairs = new SortedDictionary<char, int>();

            foreach (var item in text)
            {
                if (!pairs.ContainsKey(item))
                {
                    pairs.Add(item, 0);
                }
                pairs[item]++;
            }
            foreach (var kvp in pairs)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
