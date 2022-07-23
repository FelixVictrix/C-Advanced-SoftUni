using System;
using System.Collections.Generic;

namespace _01._Box
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Array(10, 1);
            var arrayStr = Array(10, "p");

        }
        static T[] Array<T>(int count, T element)
        {
            var array = new T[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = element;
            }
            return array;
        }
    }
}
