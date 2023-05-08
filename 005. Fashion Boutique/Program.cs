using System;
using System.Collections.Generic;
using System.Linq;

namespace _005._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesVolme = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stackOfClothes = new Stack<int>(clothesVolme);

            int racksCount = 0;
            int clothesSum = 0;

            while (stackOfClothes.Any())
            {
                int currentClothe = stackOfClothes.Peek();

                if (clothesSum + currentClothe > rackCapacity)
                {
                    racksCount++;
                    clothesSum = 0;
                    continue;
                }

                if (stackOfClothes.Count == 1)
                {
                    racksCount++;
                    break;
                }

                stackOfClothes.Pop();
                clothesSum += currentClothe;
            }

            Console.WriteLine(racksCount);
        }
    }
}
