using System.Collections.Generic;
using System.Text;
using System;

namespace GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> list = new List<T>();

        public int Count(T element)
        {
            var count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void Add(T input)
        {
            list.Add(input);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine($"{typeof(T)}");
            }
            return base.ToString();
        }
    }
}
