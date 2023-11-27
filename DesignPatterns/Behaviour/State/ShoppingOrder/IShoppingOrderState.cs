
namespace DesignPatterns.Behaviour.State.ShoppingOrder
{
    public interface IShoppingOrderState
    {
        public string GetName();
        public void ApprovePayment();
        public void RejectPayment();
        public void WaitPayment();
        public void ShipOrder();

    }
}
