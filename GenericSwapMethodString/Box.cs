using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T>
    {

        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T input)
        {
            list.Add(input);
        }

        public void Swap(int indexOut, int indexIn)
        {
            T currentOut = list[indexOut];
            list[indexOut] = list[indexIn];
            list[indexIn] = currentOut;
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

    }
}
