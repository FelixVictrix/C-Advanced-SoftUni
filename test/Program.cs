using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<int, string> studentsNumber = new SortedDictionary<int, string>(new NumbersComparer());

            studentsNumber.Add(13, "Plamen");
            studentsNumber.Add(5, "Tino");
            studentsNumber.Add(20, "Santi");
            studentsNumber.Add(16, "Santin");
            studentsNumber.Add(2, "Santino");

            foreach (var studentNum in studentsNumber)
            {
                Console.WriteLine($"{studentNum.Key} -> {studentNum.Value}");
            }

        }
        class NumbersComparer : IComparer<int>
        {
            public int Compare([AllowNull] int x, [AllowNull] int y)
            {
                // return y - x;
                return y % 2 == 0 ? 1 : -1;
            }

        }
    }
}
