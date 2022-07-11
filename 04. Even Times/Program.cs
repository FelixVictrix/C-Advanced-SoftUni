using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            AddDictionary(numbers, lines);
            PrintNumber(numbers);

        }

        static void PrintNumber(Dictionary<int, int> numbers)
        {
            var num = numbers.FirstOrDefault(x => x.Value % 2 == 0);
            Console.WriteLine(num.Key);
        }

        static Dictionary<int, int> AddDictionary(Dictionary<int, int> numbers, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 0);
                }
                numbers[input]++;
            }
            return numbers;
        }
    }
}
