
using System;

namespace ObjectOrientedProgramming.Polymorphism
{
    class Van :Vehicle
    {
        private const double _co2FactorLitreWise = 12;
        public new void CarbonFootPrint(double fuelComsumedInLitres)
        {
            Console.WriteLine(fuelComsumedInLitres * _co2FactorLitreWise);
        }
    }
}
