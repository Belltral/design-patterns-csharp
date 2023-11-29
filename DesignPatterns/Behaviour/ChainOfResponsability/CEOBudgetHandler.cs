

namespace DesignPatterns.Behaviour.ChainOfResponsability
{
    public class CEOBudgetHandler : BaseBudgetHandler
    {
        public override CustomerBudget Handle(CustomerBudget budget)
        {
            Console.WriteLine("O CEO trata qualquer orçamento");
            budget.Approved = true;
            return budget;
        }
    }
}
