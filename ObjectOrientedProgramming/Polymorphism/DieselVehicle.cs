
namespace ObjectOrientedProgramming.Polymorphism
{
    class DieselVehicle : Vehicle
    {
        private const double _co2FactorForDiesel = 20;
        //Carbon Foot Print Calculation for Diesel Vehicle
        public override double CarbonFootPrint(double mileage)
            => mileage * _co2FactorForDiesel;
    }
}
