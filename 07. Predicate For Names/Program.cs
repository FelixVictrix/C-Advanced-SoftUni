using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int lenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<int,int,bool> isLenght = (x,y) 
                => x <= y;

           names = names.Where(x=> isLenght(x.Length,lenght)).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,names));

        }
    }
}
