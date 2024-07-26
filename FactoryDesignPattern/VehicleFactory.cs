using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle Build(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Scooter:
                    return new Scooter();
                case VehicleType.Bike:
                    return new Bike();
                case VehicleType.Car:
                    return new Car();
                default:
                    return null;
            }
        }
    }
}
