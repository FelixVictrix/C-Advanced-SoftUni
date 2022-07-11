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
            HashSet<string> table = new HashSet<string>();

            SetTable(table, lenght);
            table.OrderBy(x => x).ToList().ForEach(x => Console.Write($"{x} "));

        }

        static HashSet<string> SetTable(HashSet<string> table, int lenght)
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
