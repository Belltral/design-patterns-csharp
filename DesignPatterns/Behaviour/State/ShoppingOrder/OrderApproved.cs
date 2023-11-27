

namespace DesignPatterns.Behaviour.State.ShoppingOrder
{
    public class OrderApproved : IShoppingOrderState
    {
        private string Name { get; set; } = "Order Approved";

        private ShoppingOrder order;

        public OrderApproved(ShoppingOrder order)
        {
            this.order = order;
        }

        public void ApprovePayment()
        {
            Console.WriteLine("O pedido já está no estado pagamento aprovado.");
        }

        public string GetName()
        {
            return Name;
        }

        public void RejectPayment()
        {
            order.SetState(new OrderRejected(order));
        }

        public void ShipOrder()
        {
            Console.WriteLine("Enviando o pedido para o cliente.");
        }

        public void WaitPayment()
        {
            order.SetState(new OrderPending(order));
        }
    }
}
