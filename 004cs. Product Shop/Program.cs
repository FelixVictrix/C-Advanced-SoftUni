using System;
using System.Collections.Generic;
using System.Linq;

namespace _004cs._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<Products>> shopsList = new Dictionary<string, List<Products>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] shopInfo = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                AddToShopsList(shopInfo, shopsList);

            }

            Console.WriteLine();
            PrintShopsInfo(shopsList);
        }

        static void PrintShopsInfo(Dictionary<string, List<Products>> shopsList)
        {
            foreach (var shop in shopsList.OrderBy(x=> x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var items in shop.Value)
                {
                    Console.WriteLine($"Product: {items.Product}, Price: {items.Price}, Exp. Date: {items.ExpDate}");
                }
            }
        }

        static void AddToShopsList(string[] shopInfo, Dictionary<string, List<Products>> shopsList)
        {
            string shopName = shopInfo[0];
            Products currentItem = new Products();
            currentItem.Product = shopInfo[1];
            currentItem.Price = double.Parse(shopInfo[2]);
            currentItem.ExpDate = shopInfo[3];

            if (!shopsList.ContainsKey(shopName))
            {
                shopsList.Add(shopName, new List<Products>());
            }
            
            shopsList[shopName].Add(currentItem);
            
        }
    }
}
