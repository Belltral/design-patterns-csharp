using DesignPatterns.Creational.AbstractFactory.Customer;

namespace DesignPatterns.Creational.AbstractFactory.Vehicle
{
    public class IndividualCar : IVehicle
    {
        public string Name { get; set; }
        private readonly ICustomer _customer;

        public IndividualCar(string name, ICustomer customer)
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
