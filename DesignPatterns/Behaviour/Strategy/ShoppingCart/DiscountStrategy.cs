
namespace DesignPatterns.Behavior.Strategy.ShoppingCart
{
    public class DiscountStrategy
    {
        protected double _discount = 0;

        public virtual double GetDiscount(ECommerceShoppingCart cart)
        {
            return cart.GetTotal();
        }
    }
}
