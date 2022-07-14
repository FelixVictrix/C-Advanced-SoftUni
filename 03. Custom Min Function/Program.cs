using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int> number = x
               =>
           {
               var minNum = int.MaxValue;

               foreach (var item in x)
               {
                   if (item < minNum)
                   {
                       minNum = item;
                   }
               }
               return minNum;
           };

            var input = Console.ReadLine().Split().Select(selector: int.Parse).ToArray();

            Console.WriteLine(number(input));

        }
    }
}
