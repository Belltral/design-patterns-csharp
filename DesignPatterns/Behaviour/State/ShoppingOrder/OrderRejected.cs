
namespace DesignPatterns.Behaviour.State.ShoppingOrder
{
    public class OrderRejected : IShoppingOrderState
    {
        private string Name { get; set; } = "Order Rejected";

        private ShoppingOrder order;

        public OrderRejected(ShoppingOrder order)
        {
            this.order = order;
        }

        public void ApprovePayment()
        {
            Console.WriteLine("Não posso aprovar o pagamento porque o pedido foi recusado.");
        }

        public string GetName()
        {
            return Name;
        }

        public void RejectPayment()
        {
            Console.WriteLine("Não posso recusar o pagamento porque o pedido já está recusado.");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Não posso enviar um pedido com pagamento recusado.");
        }

        public void WaitPayment()
        {
            Console.WriteLine("Não posso mover para pendente porque o pedido foi recusado.");
        }
    }
}
