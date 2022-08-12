using System;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                box.Add(input);
            }
            var elements = double.Parse(Console.ReadLine());
            var count = box.Count(elements);
            Console.WriteLine(count);
        }
    }
}
