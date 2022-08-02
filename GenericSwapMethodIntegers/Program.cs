using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {

            var lenght = int.Parse(Console.ReadLine());
            var box = new Box<int>();

            for (int i = 0; i < lenght; i++)
            {
                var currInput = int.Parse(Console.ReadLine());
                box.Add(currInput);
            }

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(input[0], input[1]);
            Console.WriteLine(box.ToString());
        }
    }
}
