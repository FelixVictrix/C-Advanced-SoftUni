using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            var tireInfo = Console.ReadLine();

            while (tireInfo != "No more tires")
            {
                var inputInfo = tireInfo.Split();
                var currTire = new Tire[4]
                {
                   new Tire(int.Parse(inputInfo[0]),double.Parse(inputInfo[1])),
                   new Tire(int.Parse(inputInfo[2]),double.Parse(inputInfo[3])),
                   new Tire(int.Parse(inputInfo[4]),double.Parse(inputInfo[5])),
                   new Tire(int.Parse(inputInfo[6]),double.Parse(inputInfo[7])),
                };
                tires.Add(currTire);
                tireInfo = Console.ReadLine();
            }
            var engineInfo = Console.ReadLine();

            while (engineInfo != "Engines done")
            {
                var inputInfo = engineInfo.Split();
                var horsePower = int.Parse(inputInfo[0]);
                var cubicCapacity = double.Parse(inputInfo[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);

                engineInfo = Console.ReadLine();
            }

            var carInfo = Console.ReadLine();

            while (carInfo != "Show special")
            {
                var inputInfo = carInfo.Split();
                var make = inputInfo[0];
                var model = inputInfo[1];
                var year = int.Parse(inputInfo[2]);
                var fuelQuantity = double.Parse(inputInfo[3]);
                var fuelConsumption = double.Parse(inputInfo[4]);
                var engineIndex = int.Parse(inputInfo[5]);
                var tireIndex = int.Parse(inputInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);
                cars.Add(car);

                carInfo = Console.ReadLine();
            }

            foreach (var item in cars.Where(c => c.Year >= 2017 && c.Engine.HorsePower > 330))
            {
                if (item.Tires.Sum(x => x.Pressure) >= 9 && item.Tires.Sum(x => x.Pressure) <= 10)
                {
                    item.Drive(20);
                    Console.WriteLine(item.WhoAmI());
                }

            }
        }
    }
}
