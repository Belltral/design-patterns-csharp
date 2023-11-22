
namespace DesignPatterns.Behavior.Strategy.ShoppingCart
{
    public class DefaultDiscount : DiscountStrategy
        {
            public override double GetDiscount(ECommerceShoppingCart cart)
            {
                double total = cart.GetTotal();

                if (total >= 100 && total < 200)
                {
                    _discount = 10;
                }
                else if (total >= 200 && total < 300)
                {
                    _discount = 20;
                }
                else if (total >= 300)
                {
                    _discount = 30;
                }

                return total - total * (_discount / 100);
            }
        }
}
