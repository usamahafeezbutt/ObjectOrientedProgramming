
namespace ObjectOrientedProgramming.Polymorphism
{
    class ElectricVehicle : Vehicle
    {
        private const double _co2FactorForElectric = 5;
        //Carbon Foot Print Calculation for Electric Vehicle
        public override double CarbonFootPrint(double mileage)
            => mileage * _co2FactorForElectric;

    }
}
