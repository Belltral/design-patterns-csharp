
namespace DesignPatterns.Behaviour.Mediator
{
    public class Seller
    {
        private List<SellerProduct> products = new List<SellerProduct>();

        private Mediator? mediator;

        public void ShowProduct()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product}");
            }
        }

        public void AddProduct(params SellerProduct[] product)
        {
            foreach (var item in product)
            {
                products.Add(item);
            }
        }

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public SellerProduct? Sell(string id)
        {
            var productIndex = products.FindIndex(prod => prod.Id == id);

            if (productIndex < 0)
            {
                return null;
            }

            var productSold = products[productIndex];
            products.Remove(productSold);
            return productSold;
        }
    }
}
