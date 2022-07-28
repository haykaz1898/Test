using System;

namespace Test
{
    abstract class Vehicle
    {
        public Type Type { get; set; }
        public float AvgFuelConsupInLPerKm { get; set; }
        public float FuelTankVolLiters { get; set; }
        public float FuelLevelLiters { get; set; }
        public float AvgSpeedInKmHours { get; set; }

        public float GetRangeOnCurrentLevelOfFuel()
        {
            return FuelLevelLiters / AvgFuelConsupInLPerKm;
        }
        public float GetRangeOnFullTank()
        {
            return FuelTankVolLiters / AvgFuelConsupInLPerKm;
        }
        public float GetTimeInHours(int FuelCountLiters, int DistanceInKM)
        {
            if (DistanceInKM / AvgFuelConsupInLPerKm <= FuelCountLiters)
            {
                return DistanceInKM / AvgSpeedInKmHours;
            }
            else
                throw new Exception("Not enough fuel");
        }

        abstract public float GetRange();
    }
}
