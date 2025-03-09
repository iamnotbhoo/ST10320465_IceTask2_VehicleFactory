using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    //My Factory Class
    public class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                case "truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
