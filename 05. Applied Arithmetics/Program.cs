using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Action<List<int>> addNum = x
                =>
            {
                for (int i = 0; i < x.Count; i++)
                {
                    x[i] += 1;
                }

            };
            Action<List<int>> subNum = x
                =>
            {
                for (int i = 0; i < x.Count; i++)
                {
                    x[i] -= 1;
                }

            };
            Action<List<int>> print = x
                => Console.WriteLine(string.Join(" ", x));
            Action<List<int>> multiplyNum = x
                =>
            {
                for (int i = 0; i < x.Count; i++)
                {
                    x[i] *= 1;
                }

            };

            var input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "add")
                {
                    addNum(numbers);
                }
                else if (input == "multiply")
                {
                    multiplyNum(numbers);
                }
                else if (input == "subtract")
                {
                    subNum(numbers);
                }
                else if (input == "print")
                {
                    print(numbers);
                }

                input = Console.ReadLine();
            }

        }
    }
}
