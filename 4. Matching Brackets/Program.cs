using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<int> index = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                string item = input[i].ToString();
                if (item == "(")
                {
                    int currIndex = i;
                    index.Push(currIndex);
                }
                else if (item == ")")
                {
                    int startIndex = index.Pop();
                    int endIndex = i;
                    string text = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
