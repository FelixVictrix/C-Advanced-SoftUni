using System;
using System.Collections.Generic;

namespace _005._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();

            AddToContinents(count, continents);
            Print(continents);

        }

        static void Print(Dictionary<string, Dictionary<string, List<string>>> continents)
        {

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var info in continent.Value)
                {
                    Console.WriteLine($"  {info.Key} -> {string.Join(", ", info.Value)}");
                }
            }

        }

        static void AddToContinents(int count, Dictionary<string, Dictionary<string, List<string>>> continents)
        {

            for (int i = 0; i < count; i++)
            {

                string[] input = Console.ReadLine().Split(' ');

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                //if (!continents.ContainsKey(continent))
                //{
                //    continents.Add(continent, new Dictionary<string, List<string>> { });
                //}

                //if (!continents[continent].ContainsKey(country))
                //{
                //    continents[continent].Add(country, new List<string>());
                //}

                //continents[continent][country].Add(city);

                if (!continents.TryGetValue(continent, out var countries))
                {
                    countries = new Dictionary<string, List<string>>();
                    continents.Add(continent, countries);
                }

                if (!countries.TryGetValue(country, out var cities))
                {
                    cities = new List<string>();
                    countries.Add(country, cities);
                }
                cities.Add(city);
            }


        }
    }
}
