
namespace ObjectOrientedProgramming.Polymorphism
{
    class Vehicle
    {
        private const double _co2Factor = 10;
        public virtual double CarbonFootPrint(double mileage)
            => mileage * _co2Factor;
    }
}
