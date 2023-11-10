using DesignPatterns.Creational.FactoryMethod.Vehicle;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleName)
        {
            return new Car(vehicleName);
        }
    }
}
