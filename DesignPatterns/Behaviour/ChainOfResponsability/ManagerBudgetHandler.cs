
namespace DesignPatterns.Behaviour.ChainOfResponsability
{
    public class ManagerBudgetHandler : BaseBudgetHandler
    {
        public override CustomerBudget Handle(CustomerBudget budget)
        {
            if (budget.Total <= 5000)
            {
                Console.WriteLine("O gerente tratou o orçamento");
                budget.Approved = true;
                return budget;
            }

            return base.Handle(budget);
        }
    }
}
