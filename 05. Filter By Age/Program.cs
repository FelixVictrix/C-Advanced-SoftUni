using System;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var lenght = int.Parse(Console.ReadLine());
            Dictionary<string,int> person = new Dictionary<string, int>();
            AddDiction(person,lenght);

            var condition = Console.ReadLine();
            var age = Console.ReadLine();
            var format = Console.ReadLine();

            Print(condition,age,format);

        }

        static void Print(string condition, string age, string format)
        {
            throw new NotImplementedException();
        }

        static Dictionary<string, int> AddDiction(Dictionary<string, int> person, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                var input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var age = int.Parse(input[1]);

                if (!person.ContainsKey(name))
                {
                    person.Add(name,0);
                }
                person[name] = age;
            }
            return person;
        }
    }
}
