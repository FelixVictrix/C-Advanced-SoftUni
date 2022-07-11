using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                names.Add(input);
            }

            names.ToList().ForEach(n => Console.WriteLine(n));
            //Console.WriteLine(string.Join("\n",names));
        }
    }
}
