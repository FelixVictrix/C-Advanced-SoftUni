using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = AddMatrix(dimensions);
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        static string[,] AddMatrix(int[] dimensions)
        {
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
