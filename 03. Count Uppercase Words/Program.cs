using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
           var text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string,bool> isCapital = w => char.IsUpper(w[0]);
            Console.WriteLine(string.Join("\n",text.Where(isCapital)));

            //foreach (var item in text)
            //{
            //    if (char.IsUpper(item[0]))
            //    {
            //        Console.WriteLine(item);;
            //    }
            //}
        }
    }
}
