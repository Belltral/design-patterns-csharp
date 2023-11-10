namespace DesignPatterns.Creational.AbstractFactory.Customer
{
    public class EnterpriseCustomer : ICustomer
    {
        private readonly string _name;

        public string Name 
        { 
            get => _name;
        }

        public EnterpriseCustomer(string name)
        {
            _name = name;
        }
    }
}
