
namespace DesignPatterns.Structural.Decorator.Product
{
    //Concrete Component
    public class TShirt : IProduct
    {
        private string name = "Camiseta";
        private double price = 49.9;

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}
