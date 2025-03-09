namespace VehicleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a car using the factory
            IVehicle car = VehicleFactory.CreateVehicle("car");
            car.Drive();  // Output: Driving a car!

            // Creating a bike using the factory
            IVehicle bike = VehicleFactory.CreateVehicle("bike");
            bike.Drive();  // Output: Riding a bike!

            // Creating a truck using the factory
            IVehicle truck = VehicleFactory.CreateVehicle("truck");
            truck.Drive();  // Output: Driving a truck!
        }
    }
}