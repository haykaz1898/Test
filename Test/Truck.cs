using System;

namespace Test
{
    class Truck : Vehicle
    {
        int _currentLoadCapacity;

        public int MaxLoadCapacity { get; private set; }
        public int CurrentLoadCapacity
        {
            get { return _currentLoadCapacity; }
            set
            {
                if (value <= MaxLoadCapacity)
                    _currentLoadCapacity = value;
                else
                    throw new Exception("Too much weight");
            }
        }

        public override float GetRange()
        {
            var range = GetRangeOnCurrentLevelOfFuel();
            return range - range * (CurrentLoadCapacity / 200) * 0.04f;
        }
        
        public Truck() => MaxLoadCapacity = 5000;
    }
}
