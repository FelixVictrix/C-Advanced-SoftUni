using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
   public class Box<T>
    {
        private List<T> list = new List<T>();

        public void Add(T input)
        {
            list.Add(input);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public void Swap(int indexOut , int indexIn)
        {
            T current = list[indexOut];
            list[indexOut] = list[indexIn];
            list[indexIn] = current;
        }
    }
}
