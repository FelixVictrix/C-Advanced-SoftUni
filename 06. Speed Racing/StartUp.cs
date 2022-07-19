using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carsNumber = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            AddCars(cars, carsNumber);

            var input = Console.ReadLine();
            while (input != "End")
            {
                var info = input.Split();
                var model = info[1];
                var amountOfKm = double.Parse(info[2]);
                var curCar = cars.FirstOrDefault(c => c.Model == model);
                curCar.Drive(amountOfKm);

                input = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }

        static void AddCars(List<Car> cars, int carsNumber)
        {
            Car car;
            for (int i = 0; i < carsNumber; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var fuelConsumptionFor1km = double.Parse(carInfo[2]);
                car = new Car(model, fuelAmount, fuelConsumptionFor1km, 0);
                cars.Add(car);
            }
        }
    }
}
