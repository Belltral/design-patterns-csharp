
using DesignPatterns.Creational.FactoryMethod.Vehicle;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    internal class BicycleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleName)
        {
            return new Bicycle(vehicleName);
        }
    }
}
