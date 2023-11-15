
namespace DesignPatterns.Structural.Decorator.Product
{
    public class ProductCustomization : ProductDecorator
    {
        public string GetName()
        {
            return Product.GetName() + " (Customizada)";
        }

        public double GetPrice()
        {
            return Product.GetPrice() + 50;
        }

    }
}
