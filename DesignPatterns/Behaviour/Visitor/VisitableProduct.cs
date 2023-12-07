
namespace DesignPatterns.Behaviour.Visitor
{
    public abstract class VisitableProduct
    {
        protected string Name { get; set; }
        protected double Price { get; set; }

        public VisitableProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public abstract double GetPriceWithTaxes(ITaxVisitor visitor);
    }
}
