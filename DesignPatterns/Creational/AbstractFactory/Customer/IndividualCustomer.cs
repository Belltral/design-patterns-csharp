namespace DesignPatterns.Creational.AbstractFactory.Customer
{
    public class IndividualCustomer : ICustomer
    {
        private readonly string _name;

        public string Name
        {
            get => _name;
        }

        public IndividualCustomer(string name)
        {
            _name = name;
        }
    }
}