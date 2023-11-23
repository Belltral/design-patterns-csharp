using DesignPatterns.Behavior.Strategy.ShoppingCart;

public class ECommerceShoppingCart
{
    private List<ECommerceProduct> _products = new List<ECommerceProduct>();
    private DiscountStrategy _discountStrategy;


    public ECommerceShoppingCart(DiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }


    public void AddProduct(params ECommerceProduct[] products)
    {
        foreach (var product in products)
        {
            _products.Add(product);
        }
    }

    public List<ECommerceProduct> GetProducts()
    {
        return _products;
    }

    public double GetTotal()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.Price;
        }

        return total;
    }

    public double GetTotalWithDiscount()
    {
        return _discountStrategy.GetDiscount(this);
    }

}