
using DesignPatterns.Creational.AbstractFactory.Customer;
using DesignPatterns.Creational.AbstractFactory.Vehicle;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class IndividualCustomerVehicleFactory : ICustomerVehicleFactory
    {
        public ICustomer CreateCustomer(string customerName)
        {
            return new IndividualCustomer(customerName);
        }

        public IVehicle CreateVehicle(string vehicleName, string customerName)
        {
            var customer = CreateCustomer(customerName);
            return new IndividualCar(vehicleName, customer);
        }
    }
}
