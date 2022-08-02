using System;

namespace _01._Generic_Box_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                var input = Console.ReadLine();
                var box = new Box<string>(input);
                
                Console.WriteLine(box.ToString());
            }
        }
    }
}
