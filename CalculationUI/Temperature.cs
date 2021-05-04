using System.Collections.Generic;
using System.Linq;

namespace CalculationUI
{
    public class Temperature : ITemperature
    {
        private List<int> _temperatures = new List<int>();

        private Dictionary<string, int> _temperatureWords = new Dictionary<string, int>();

        public int Min { get => _temperatures.Min(); }

        public int Max { get => _temperatures.Max(); }

        public double Average { get => _temperatures.Average(); }

        public Temperature()
        {
            PopulateTemperatureWords();
        }

        // optimized for when getting the Min, Max, or Average
        //public void Insert(int temperature)
        //{
        //    // add guards. For example, business logic needs it to be between 0 and 100.
        //    if (temperature < 0 | temperature > 100)
        //    {
        //        throw new Exception("Argument not in valid range (0 - 100)");
        //    }

        //    AdjustMinAndMaxIfNeeded(temperature);

        //    // add to list
        //    _temperatures.Add(temperature);

        //    // re-calculate average of list
        //    Average = _temperatures.Average();
        //}

        // optimized for inserting new temperature data
        public void Insert(int temperature)
        {
            _temperatures.Add(temperature);
        }


        public void Insert(string temperature)
        {
            temperature = temperature.ToLower();

            Insert(_temperatureWords[temperature]);
        }

        private void PopulateTemperatureWords()
        {
            _temperatureWords.Add("one", 1);
            _temperatureWords.Add("two", 2);
            _temperatureWords.Add("three", 3);
            _temperatureWords.Add("four", 4);
            _temperatureWords.Add("five", 5);
            _temperatureWords.Add("six", 6);
            _temperatureWords.Add("seven", 7);
            _temperatureWords.Add("eight", 8);
            _temperatureWords.Add("nine", 9);
            _temperatureWords.Add("ten", 10);
        }

        //private void AdjustMinAndMaxIfNeeded(int temperature)
        //{
        //    if (Min == 0)
        //    {
        //        Min = temperature;
        //    }

        //    // check if min
        //    if (temperature < Min)
        //    {
        //        Min = temperature;
        //    }

        //    // check if max
        //    if (temperature > Max)
        //    {
        //        Max = temperature;
        //    }
        //}
    }
}
