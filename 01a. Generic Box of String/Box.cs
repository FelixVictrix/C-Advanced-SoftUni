using System.Collections.Generic;
using System.Text;

namespace _01a._Generic_Box_of_String
{
    public class Box<T>
    {

        private List<T> list = new List<T>();

        public void Add(T text)
        {
            list.Add(text);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in list)
            {
                sb.AppendLine($"System.String: {item}");
            }
            return sb.ToString().TrimEnd();;
        }

    }
}
