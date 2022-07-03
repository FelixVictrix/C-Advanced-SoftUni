using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var rows = n;
            var cols = n;

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var current = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                int col = row;
                sum += matrix[row, col];
            }
            Console.WriteLine(sum);
        }
    }
}
