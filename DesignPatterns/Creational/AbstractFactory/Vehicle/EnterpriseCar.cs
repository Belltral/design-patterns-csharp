using DesignPatterns.Creational.AbstractFactory.Customer;

namespace DesignPatterns.Creational.AbstractFactory.Vehicle
{
    public class EnterpriseCar : IVehicle
    {
        public string Name { get; set; }
        private readonly ICustomer _customer;

        public EnterpriseCar(string name, ICustomer customer)
        {
            Name = name;
            _customer = customer;
        }

        public void PickUp()
        {
            Console.WriteLine($"{Name} está buscando {_customer.Name}"); ;
        }
    }
}
