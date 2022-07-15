using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            var lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var start = lenght[0];
            var end = lenght[1];

            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            var type = Console.ReadLine();

            Func<int, bool> isEven = x
                 => x % 2 == 0;
            IEnumerable<int> result = type == "even"
                ? numbers.Where(x => isEven(x) == true)
                : numbers.Where(x => isEven(x) == false);

            //Predicate<int> isEven = x
            //    => x % 2 == 0;
            //Predicate<int> isOdd = x
            //    => x % 2 != 0;

            //numbers = type == "even"
            //                ? numbers.FindAll(isEven)
            //                : numbers.FindAll(isOdd);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
