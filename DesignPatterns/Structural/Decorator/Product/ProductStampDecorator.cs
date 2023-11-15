
namespace DesignPatterns.Structural.Decorator.Product
{
    //Concrete Decorator
    public class ProductStampDecorator : ProductDecorator
    {
        public string GetName()
        {
            return Product.GetName() + " (Estampada)";
        }

        public double GetPrice()
        {
            return Product.GetPrice() + 10;
        }
    }
}
