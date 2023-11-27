
namespace DesignPatterns.Behaviour.State.ShoppingOrder
{
    public class OrderPending : IShoppingOrderState
    {
        private string Name { get; set; } = "Order Pending";

        private ShoppingOrder order;

        public OrderPending(ShoppingOrder order)
        {
            this.order = order;
        }

        public void ApprovePayment()
        {
            order.SetState(new OrderApproved(order));
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
            Console.WriteLine("Não posso enviar o pedido com pagamento pendente.");
        }

        public void WaitPayment()
        {
            Console.WriteLine("O pedido já está no estado de pagamento pendente");
        }
    }
}
