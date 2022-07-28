namespace Test
{
    class SportCar : Vehicle
    {
        public override float GetRange() => FuelLevelLiters / AvgFuelConsupInLPerKm;
    }
}
