using System;
using System.Collections.Generic;
using System.Linq;

namespace _004._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string,Dictionary<string,double>> shopsList = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] shopInfo = input.Split(", ");

                string shop = shopInfo[0];
                string product = shopInfo[1];
                double price = double.Parse(shopInfo[2]);

                if (!shopsList.ContainsKey(shop))
                {
                    shopsList.Add(shop, new Dictionary<string,double>());
                }
                shopsList[shop].Add(product, price);

            }

            foreach (var kvp in shopsList.OrderBy(x=> x.Key))
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var shop in kvp.Value)
                {
                    Console.WriteLine($"Product: {shop.Key}, Price: {shop.Value}");
                }
            }

        }
    }
}
