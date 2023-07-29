using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace _003._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            Console.WriteLine(string.Join(" ", array));

            //var lenght = 3;

            //if (array.Length < 3)
            //{
            //    lenght = array.Length;
            //}

            //for (int i = 0; i < lenght; i++)
            //{
            //    var current = array[i];
            //    Console.Write(current + " ");
            //}
            //var count = array.Length;

            //for (int i = Math.Max(0, 3); i < count; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

        }
    }
}
