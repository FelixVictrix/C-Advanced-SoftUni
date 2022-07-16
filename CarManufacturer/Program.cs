using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car car = new Car();
            Car car1 = new Car(make, model, year);
            Car car2 = new Car(make,model,year,fuelQuantity,fuelConsumption);

            Console.WriteLine(car.WhoAmI());
            Console.WriteLine(car1.WhoAmI());
            Console.WriteLine(car2.WhoAmI());

            //Car car = new Car();
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;
            //car.Drive(2000);

            //Console.WriteLine(car.WhoAmI());

            // Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

        }
    }
}
