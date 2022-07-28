using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {       
        static void Main(string[] args)
        {
            Truck car = new Truck();
            car.CurrentLoadCapacity = 6000;
            car.AvgSpeedInKmHours = 40;
            car.AvgFuelConsupInLPerKm = (float)10 / 100;
            car.FuelTankVolLiters = 60;
            car.FuelLevelLiters = 40;
            Console.WriteLine(car.GetRange());
        }
    }
}
