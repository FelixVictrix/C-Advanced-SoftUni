using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {

            var lenght = int.Parse(Console.ReadLine());

            var box = new Box<int>();

            for (int i = 0; i < lenght; i++)
            {
                //var input = Console.ReadLine();
                var input = int.Parse(Console.ReadLine());
                box.Add(input);
            }

            var index = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(index[0], index[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
