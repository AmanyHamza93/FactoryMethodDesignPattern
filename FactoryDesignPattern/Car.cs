using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Car : Vehicle
    {
        public override void PrintVehicleInfo()
        {
            Console.WriteLine("Client choose car");
        }
    }
}
