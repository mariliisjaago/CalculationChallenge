using System;

namespace CalculationUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ITemperature estonianTemperatures = new Temperature();
            var randomGenerator = new Random();

            string[] temperatureWords = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            //for (int i = 0; i < 100; ++i)
            //{
            //    estonianTemperatures.Insert(randomGenerator.Next(1, 101));
            //}

            for (int i = 0; i < 100; ++i)
            {
                estonianTemperatures.Insert(temperatureWords[randomGenerator.Next(1, 10)]);
            }


            Console.WriteLine($"Min is { estonianTemperatures.Min }");
            Console.WriteLine($"Max is { estonianTemperatures.Max }");
            Console.WriteLine($"Average is { estonianTemperatures.Average }");
        }
    }
}
