using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            var lenght = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            AddDiction(wardrobe, lenght);
            var search = Console.ReadLine().Split();
            var color = search[0];
            var cloth = search[1];
            PrintResult(wardrobe,color,cloth);

        }

        static void PrintResult(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string cloth)
        {
            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var item in kvp.Value)
                {
                    var isFound = color == kvp.Key && cloth == item.Key
                        ? $"* {item.Key} - {item.Value} (found!)"
                        : $"* {item.Key} - {item.Value}";
                    Console.WriteLine(isFound);

                    //if (color == kvp.Key && cloth == item.Key)
                    //{
                    //    Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"* {item.Key} - {item.Value}");
                    //}
                    
                }
            }
        }

        static Dictionary<string, Dictionary<string, int>> AddDiction(Dictionary<string, Dictionary<string, int>> wardrobe, int lenght)
        {

            for (int i = 0; i < lenght; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var color = input[0];
                input.RemoveAt(0);


                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in input)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }
                    wardrobe[color][item]++;
                }
            }
            return wardrobe;
        }
    }
}
