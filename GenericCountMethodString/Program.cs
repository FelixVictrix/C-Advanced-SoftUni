using System;

namespace GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                box.Add(input);
            }
            string elements = Console.ReadLine();
            var count = box.Count(elements);
            Console.WriteLine(count);
        }
    }
}
