﻿using System;

namespace GenericBoxofString
{
    class Program
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
            Console.WriteLine(box.ToString());
        }
    }
}
