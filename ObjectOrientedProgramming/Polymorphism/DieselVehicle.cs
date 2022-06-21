
namespace ObjectOrientedProgramming.Polymorphism
{
    class DieselVehicle : Vehicle
    {
        private const double _co2FactorForDiesel = 20;
        public override double CarbonFootPrint(double mileage)
            => mileage * _co2FactorForDiesel;
    }
}
