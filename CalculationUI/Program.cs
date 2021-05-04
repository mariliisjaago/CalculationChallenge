using System;

namespace CalculationUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var estonianTemperatures = new Temperature();
            var randomGenerator = new Random();

            for (int i = 0; i < 100; ++i)
            {
                estonianTemperatures.Insert(randomGenerator.Next(1, 100));
            }


            Console.WriteLine($"Min is { estonianTemperatures.Min }");
            Console.WriteLine($"Max is { estonianTemperatures.Max }");
            Console.WriteLine($"Average is { estonianTemperatures.Average }");
        }
    }
}
