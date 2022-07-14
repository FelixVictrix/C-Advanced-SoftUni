using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {

            var lenght = int.Parse(Console.ReadLine());
            List<Students> list = new List<Students>();
            AddList(list, lenght);

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            if (condition == "older")
            {
                list = list.Where(s => s.Age >= age).Select(x => x).ToList();
            }
            else
            {
                list = list.Where(s => s.Age < age).Select(x => x).ToList();
            }
            if (format == "name age")
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }
            }
            else if (format == "name")
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }
            else if (format == "age")
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Age}");
                }
            }

        }

        static List<Students> AddList(List<Students> list, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var age = int.Parse(input[1]);
                Students students = new Students();
                students.Name = name;
                students.Age = age;
                list.Add(students);
            }
            return list;
        }

        class Students
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
