namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKm;
            TravelledDistance = travelledDistance;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            if (FuelAmount - distance * FuelConsumptionPerKilometer >= 0)
            {
                FuelAmount -= distance * FuelConsumptionPerKilometer;
                TravelledDistance += distance;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
