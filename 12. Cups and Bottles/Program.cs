using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {

            var cupsCapInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bottlesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(cupsCapInput);
            Stack<int> bottles = new Stack<int>(bottlesInput);

            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                var cup = cups.Dequeue();
                var bottle = bottles.Pop();

                if (bottle >= cup)
                {
                    wastedWater += bottle - cup;
                    continue;
                }

                cup -= bottle;

                while (bottles.Count > 0)
                {
                    var currBottle = bottles.Pop();

                    if (currBottle - cup >= 0)
                    {
                        wastedWater += currBottle - cup;
                        break;
                    }

                    cup -= currBottle;
                }

            }
            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
