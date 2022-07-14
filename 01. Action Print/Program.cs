using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var text = Console.ReadLine().Split();

            Action<string[]> print = printNames
               => Console.WriteLine(string.Join("\n", printNames));

            print(text);
        }
    }
}
