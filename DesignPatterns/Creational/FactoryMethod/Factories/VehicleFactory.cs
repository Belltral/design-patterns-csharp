using DesignPatterns.Creational.FactoryMethod.Vehicle;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    public abstract class VehicleFactory
    {
        //Factory Method
        public abstract IVehicle GetVehicle(string vehicleName);

        public IVehicle PickUp(string customerName, string vehicleName)
        {
            var car = GetVehicle(vehicleName);
            car.PickUp(customerName);
            return car;
        }
    }
}
