

namespace DesignPatterns.Behaviour.ChainOfResponsability
{
    public abstract class BaseBudgetHandler
    {
        protected BaseBudgetHandler? nextHandler = null;

        public BaseBudgetHandler SetNextHandler(BaseBudgetHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public virtual CustomerBudget Handle(CustomerBudget budget)
        {
            if (nextHandler != null) 
            {
                return nextHandler.Handle(budget);
            }
            return budget;
        }
    }
}
