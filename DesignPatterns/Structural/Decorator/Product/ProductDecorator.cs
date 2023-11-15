

namespace DesignPatterns.Structural.Decorator.Product
{
    //Decorator
    public class ProductDecorator : IProduct
    {
        internal protected IProduct Product { get; set; }


        public string GetName()
        {
            return Product.GetName();
        }

        public double GetPrice()
        {
            return Product.GetPrice();
        }
    }
}
