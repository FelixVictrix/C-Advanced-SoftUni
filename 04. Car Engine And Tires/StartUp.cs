using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Tire[] tire = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };

            Engine engine = new Engine(560, 6300);

            Car car = new Car("Lamborghini", "Ursus", 2010, 250, 9, engine, tire);
            Console.WriteLine(car.WhoAmI());

        }
    }
}
