
namespace DesignPatterns.Behaviour.Visitor
{
    public class Food : VisitableProduct
    {
        public Food(double price) : base("Food", price)
        {
            
        }

        public override double GetPriceWithTaxes(ITaxVisitor visitor)
        {
            return visitor.CalculateTaxesForFood(this);
        }
    }
}
