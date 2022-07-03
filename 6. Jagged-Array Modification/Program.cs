using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.GetLength(0); row++)
            {

                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split();
                string action = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine();
                    continue;
                }

                if (action == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    jagged[row][col] -= value;
                }

                input = Console.ReadLine();
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
