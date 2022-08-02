using System;

namespace _01a._Generic_Box_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < lenght; i++)
            {
                var input = Console.ReadLine();
                box.Add(input);
            }
            Console.WriteLine(box.ToString());
        }
    }
}
