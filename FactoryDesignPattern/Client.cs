using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Client
    {
        private Vehicle? vehicle;
        public Client() 
        {
            vehicle = null;
        }
        public void BuildVehicleInfo(VehicleType vehicleType)
        {
            IVehicleFactory vf = new VehicleFactory();
            vehicle = vf.Build(vehicleType);
            vehicle.PrintVehicleInfo();
        }
        public Vehicle? GetVehicle(VehicleType vehicleType)
        {
            return vehicle;
        }
    }
}
