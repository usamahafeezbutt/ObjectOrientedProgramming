
namespace ObjectOrientedProgramming.Polymorphism
{
    class Vehicle
    {
        private const double _co2Factor = 10;
        //Carbon Foot Print Calculation for General Vehicle
        public virtual double CarbonFootPrint(double mileage)
            => mileage * _co2Factor;
    }
}
