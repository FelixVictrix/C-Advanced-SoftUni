using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            var boardSize = int.Parse(Console.ReadLine());

            string[,] board = new string[boardSize, boardSize];

            for (int row = 0; row < boardSize; row++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < boardSize; col++)
                {
                    board[row, col] = input[col].ToString();
                }
            }

            int count = 0;

            for (int row = 0; row < boardSize - 2; row++)
            {
                for (int col = 0; col < boardSize - 2; col++)
                {
                    if ((board[row, col] == "K" && board[row + 1, col + 2] == "K" && col + 2 < board.GetLength(1)) ||
                        (board[row, col] == "K" && board[row + 2, col + 1] == "K" && row + 2 < board.GetLength(0)))
                    {
                        //board[row + 1, col + 2] = "0";
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
