using System;

namespace Test
{
    class Car : Vehicle
    {
        private int _countOfPassangers;

        public int MaxNumOfPassangers { get; private set; }
        public int CountOfPassangers {
            get { return _countOfPassangers; }
            set
            {
                if (value <= MaxNumOfPassangers)
                    _countOfPassangers = value;
                else
                    throw new Exception("Too much passengers");
                    
            }
        }

        public override float GetRange()
        {
            var range = GetRangeOnCurrentLevelOfFuel();
            return range - range * 0.06f * CountOfPassangers;
        }
        public Car() => MaxNumOfPassangers = 5;
    }
}
