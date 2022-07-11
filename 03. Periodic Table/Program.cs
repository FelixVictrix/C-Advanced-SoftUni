using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            var lenght = int.Parse(Console.ReadLine());
            SortedSet<string> table = new SortedSet<string>();

            SetTable(table, lenght);
            table.ToList().ForEach(x => Console.Write($"{x} "));

        }

        static SortedSet<string> SetTable(SortedSet<string> table, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                input.ForEach(x => table.Add(x));
            }
            return table;
        }
    }
}
