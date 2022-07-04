using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = AddMatrix(n);

            int firstSum = 0;

            for (int row = 0; row < n; row++)
            {
                firstSum += matrix[row, row];
            }

            int secondSum = 0;

            for (int row = 0; row < n; row++)
            {
                secondSum += matrix[row, (matrix.GetLength(1) - 1) - row];
            }

            int difference = Math.Abs(firstSum-secondSum);
            Console.WriteLine(difference);

        }

        static int[,] AddMatrix(int n)
        {
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
