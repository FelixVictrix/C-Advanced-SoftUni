using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> diction = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!diction.ContainsKey(number))
                {
                    diction.Add(number, 0);
                }
                diction[number]++;
            }

            foreach (var item in diction)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
