using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowCol[0];
            int cols = rowCol[1];
            char[,] martrix = AddMatrix(rows, cols);

            Print(martrix);
        }

        static void Print(char[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

        static char[,] AddMatrix(int rows, int cols)
        {
            string snake = Console.ReadLine();
            char[,] matrix = new char[rows, cols];
            bool rightToLeft = true;
            int indexOfSymbol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (rightToLeft)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[indexOfSymbol++];
                        if (indexOfSymbol == snake.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }
                    rightToLeft = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[indexOfSymbol++];
                        if (indexOfSymbol == snake.Length)
                        {
                            indexOfSymbol = 0;
                        }
                    }
                    rightToLeft = true;
                }

            }
            return matrix;
        }
    }
}
