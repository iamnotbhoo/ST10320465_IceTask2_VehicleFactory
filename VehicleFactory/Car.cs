using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    //My Concrete Class
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike!");
        }
    }

    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck!");
        }
    }
}
