using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class Vehicle
    {
        public abstract void PrintVehicleInfo();       
    }
    public enum VehicleType
    {
        Scooter = 1,
        Bike,
        Car
    }
}
