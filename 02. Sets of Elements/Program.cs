using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            var lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            FillSet(firstSet, lenght[0]);
            FillSet(secondSet, lenght[1]);
            Checker(firstSet, secondSet);

        }

        static void Checker(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            firstSet.IntersectWith(firstSet);
            Console.WriteLine(string.Join(" ", firstSet));
        }

        static HashSet<int> FillSet(HashSet<int> table, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                table.Add(int.Parse(Console.ReadLine()));
            }
            return table;
        }
    }
}
