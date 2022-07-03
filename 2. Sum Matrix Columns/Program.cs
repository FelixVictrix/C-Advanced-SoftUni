using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = input[0];
            var cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var current = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var colSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    colSum += matrix[row, col];
                }
                 
                Console.WriteLine(colSum);
            }

        }
    }
}
