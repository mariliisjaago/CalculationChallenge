using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculationUI
{
    public class Temperature
    {
        private List<int> _temperatures = new List<int>();

        public int Min { get; private set; }

        public int Max { get; private set; }

        public double Average { get; private set; }

        public void Insert(int temperature)
        {
            // add guards?
            if (temperature < 0 | temperature > int.MaxValue)
            {
                throw new Exception("Argument not in valid range (0 - maximum of int)");
            }

            AdjustMinAndMaxIfNeeded(temperature);

            // add to list
            _temperatures.Add(temperature);

            // re-calculate average of list
            Average = _temperatures.Average();
        }

        private void AdjustMinAndMaxIfNeeded(int temperature)
        {
            if (Min == 0)
            {
                Min = temperature;
            }

            // check if min
            if (temperature < Min)
            {
                Min = temperature;
            }

            // check if max
            if (temperature > Max)
            {
                Max = temperature;
            }
        }
    }
}
