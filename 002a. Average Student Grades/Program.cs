using System;
using System.Collections.Generic;

namespace _002a._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int count = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                Student student = students.Find(x=> x.Name == name);

                if (student == null)
                {
                    student = new Student();
                    student.Name = name;
                    student.Grades = new List<decimal> { };
                    students.Add(student);
                }
                student.Grades.Add(grade);

            }

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Name} -> {string.Join(" ", kvp.Grades)} (avg: {kvp.GetAverageGrade()})");
            }
        }
    }
}
