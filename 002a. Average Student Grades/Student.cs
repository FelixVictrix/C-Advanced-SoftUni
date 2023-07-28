using System.Collections.Generic;

namespace _002a._Average_Student_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<decimal> Grades { get; set; }

        public decimal GetAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            decimal sum = 0;

            foreach (var grade in Grades)
            {
                sum += grade;
            }
            return sum / Grades.Count;
        }
    }
}
