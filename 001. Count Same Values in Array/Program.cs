using System;
using System.Collections.Generic;
using System.Linq;

namespace _001._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] array = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double,int> dict = new Dictionary<double,int>();

            foreach (double value in array)
            {
                if (!dict.ContainsKey(value))
                {
                    dict.Add(value,0);
                }
                dict[value]++;
            }

            foreach (var value in dict)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }

        }
    }
}
