using DesignPatterns.Creational.AbstractFactory.Customer;
using DesignPatterns.Creational.AbstractFactory.Vehicle;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public interface ICustomerVehicleFactory
    {
        public ICustomer CreateCustomer(string customerName);
        public IVehicle CreateVehicle(string vehicleName, string customerName);
    }
}
