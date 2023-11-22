
namespace DesignPatterns.Behavior.Strategy.ShoppingCart
{
    public class NewDiscount : DiscountStrategy
    {
        public override double GetDiscount(ECommerceShoppingCart cart)
        {
            double total = cart.GetTotal();

            if (total >= 150)
            {
                _discount = 5;
            }

            return total - total * (_discount / 100);
        }
    }
}
