using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var rows = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = FillMatrix(rows);

            AnalyzingRows(jaggedMatrix);

            var input = Console.ReadLine();

            while (input != "End")
            {
                var command = input.Split();
                var action = command[0];
                var row = int.Parse(command[1]);
                var col = int.Parse(command[2]);
                var value = int.Parse(command[3]);

                if (row >= 0 && col >= 0 && row < jaggedMatrix.GetLength(0) && col < jaggedMatrix[row].Length)
                {
                    if (action == "Add")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                }

                input = Console.ReadLine();
            }

            PrintMatrix(jaggedMatrix);
        }

        static void PrintMatrix(int[][] jaggedMatrix)
        {
            for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    Console.Write($"{jaggedMatrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }

        static void AnalyzingRows(int[][] jaggedMatrix)
        {
            for (int row = 0; row < jaggedMatrix.GetLength(0) - 1; row++)
            {
                if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                {
                    jaggedMatrix[row] = jaggedMatrix[row].Select(x => x * 2).ToArray();
                    jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = jaggedMatrix[row].Select(x => x / 2).ToArray();
                    jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(x => x / 2).ToArray();
                }
            }


        }

        static int[][] FillMatrix(int rows)
        {
            int[][] jaggedMatrix = new int[rows][];

            for (int row = 0; row < jaggedMatrix.Length; row++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedMatrix[row] = input;
            }

            return jaggedMatrix;
        }
    }
}
