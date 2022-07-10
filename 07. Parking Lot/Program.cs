using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> cars = new HashSet<string>();

            var input = Console.ReadLine();

            while (input != "END")
            {

                var command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var action = command[0];
                var car = command[1];

                switch (action)
                {
                    case "IN":
                        cars.Add(car);
                        break;
                    case "OUT":
                        cars.Remove(car);
                        break;
                }
                input = Console.ReadLine();
            }
            if (cars.Any())
            {
                Console.WriteLine(string.Join("\n", cars));
            }
            else
            {
                Console.WriteLine(" Parking Lot is Empty");
            }
            
        }
    }
}
