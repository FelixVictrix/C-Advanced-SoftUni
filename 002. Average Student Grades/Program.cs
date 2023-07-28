using System;
using System.Collections.Generic;
using System.Linq;

namespace _002._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsList = new Dictionary<string, List<decimal>>();


            while (count != 0)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentsList.ContainsKey(name))
                {
                    studentsList.Add(name,new List<decimal>());
                }
                studentsList[name].Add(grade);

                count--;
            }

            foreach (var name in studentsList)
            {

                Console.Write($"{name.Key} -> {string.Join(" ", name.Value)} ( avg: {name.Value.Average()})");
                Console.WriteLine();
            };

        }
    }
}
