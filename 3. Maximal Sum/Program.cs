using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = AddMatrix(dimensions);

            int squareSide = 3;
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row <= matrix.GetLength(0) - squareSide; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - squareSide; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (maxSum<sum)
                    {
                        maxSum = sum;
                        maxRow=row;
                        maxCol=col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRow; row < squareSide + maxRow; row++)
            {
                for (int col = maxCol; col < squareSide + maxCol; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }

        }
        static int[,] AddMatrix(int[] dimensions)
        {
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }

    }
}
