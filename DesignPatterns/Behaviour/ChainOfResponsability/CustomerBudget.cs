
namespace DesignPatterns.Behaviour.ChainOfResponsability
{
    public class CustomerBudget
    {
        public bool Approved { get; set; }
        public double Total { get; set; }

        public CustomerBudget()
        {
            Approved = false;
        }
    }
}
