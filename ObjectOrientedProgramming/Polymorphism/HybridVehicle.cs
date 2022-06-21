
namespace ObjectOrientedProgramming.Polymorphism
{
    class HybridVehicle : Vehicle
    {
        private const double _co2FactorForHybrid = 15;
        public override double CarbonFootPrint(double mileage)
            => mileage * _co2FactorForHybrid;
    }
}
