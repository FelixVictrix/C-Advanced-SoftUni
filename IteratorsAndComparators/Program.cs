using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {

           

        }
    }

    interface IGetName
    {
        string GetName();
        void PrintName();
    }

    class HighSchoolStudent : Student
    {
        public string HighSchool { get; set; }
    }

    class Student
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<double> Grades { get; set; }

        public void PrintGrades()
        {
            Console.WriteLine(string.Join(", ", Grades));
        }

    }

}
