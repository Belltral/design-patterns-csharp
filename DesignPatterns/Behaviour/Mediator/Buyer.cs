
namespace DesignPatterns.Behaviour.Mediator
{
    public class Buyer
    {
        private Mediator mediator;

        public Buyer(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void ViewProduct()
        {
            mediator.ShowProducts();
        }

        public void Buy(string id)
        {
            mediator.Buy(id);
        }
    }
}
