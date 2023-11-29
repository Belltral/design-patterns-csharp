

namespace DesignPatterns.Behaviour.ChainOfResponsability
{
    public class DirectorBudgetHandler : BaseBudgetHandler
    {
        public override CustomerBudget Handle(CustomerBudget budget)
        {
            if (budget.Total <= 50000)
            {
                Console.WriteLine("O diretor tratou o orçamento");
                budget.Approved = true;
                return budget;
            }

            return base.Handle(budget);
        }
    }
}
