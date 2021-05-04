namespace CalculationUI
{
    public interface ITemperature
    {
        double Average { get; }
        int Max { get; }
        int Min { get; }

        void Insert(int temperature);
        void Insert(string temperature);
    }
}