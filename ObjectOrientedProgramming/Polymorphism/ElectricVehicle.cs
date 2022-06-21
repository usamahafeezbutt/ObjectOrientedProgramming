
namespace ObjectOrientedProgramming.Polymorphism
{
    class ElectricVehicle : Vehicle
    {
        private const double _co2FactorForElectric = 5;
        public override double CarbonFootPrint(double mileage)
            => mileage * _co2FactorForElectric;

    }
}
