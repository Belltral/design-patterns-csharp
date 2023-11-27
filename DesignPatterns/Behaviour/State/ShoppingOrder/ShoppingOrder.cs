
namespace DesignPatterns.Behaviour.State.ShoppingOrder
{
    public class ShoppingOrder
    {
        private IShoppingOrderState State { get; set; }

        public IShoppingOrderState GetState()
        {
            return State;
        }

        public ShoppingOrder()
        {
            State = new OrderPending(this);
        }

        public void SetState(IShoppingOrderState state)
        {
            State = state;
            Console.WriteLine($"O estado do pedido agora é {state.GetName()}");
        }

        public string GetStateName()
        {
            return State.GetName();
        }

        public void ApprovePayment()
        {
            State.ApprovePayment();
        }

        public void RejectPayment()
        {
            State.RejectPayment();
        }

        public void WaitPayment()
        {
            State.WaitPayment();
        }

        public void ShipOrder()
        {
            State.ShipOrder();
        }
    }
}
