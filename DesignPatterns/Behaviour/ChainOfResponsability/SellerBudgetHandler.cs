

namespace DesignPatterns.Behaviour.ChainOfResponsability
{
    public class SellerBudgetHandler : BaseBudgetHandler
    {
        public override CustomerBudget Handle(CustomerBudget budget)
        {
            if (budget.Total <= 1000)
            {
                Console.WriteLine("O vendedor tratou o orçamento");
                budget.Approved = true;
                return budget;
            }

            return base.Handle(budget);
        }
    }
}
