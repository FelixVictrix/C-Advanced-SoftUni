using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            string text = Console.ReadLine();

            Queue<char> snakeQueue = new Queue<char>(text);

            bool isRight = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (isRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char symbol = snakeQueue.Dequeue();
                        matrix[row, col] = symbol;
                        snakeQueue.Enqueue(symbol);
                    }
                    isRight = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        char symbol = snakeQueue.Dequeue();
                        matrix[row, col] = symbol;
                        snakeQueue.Enqueue(symbol);
                    }
                    isRight = true;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
