
namespace DesignPatterns.Behaviour.Visitor
{
    public class Cigarette : VisitableProduct
    {
        public Cigarette(double price) : base("Cigarette", price)
        {
        }

        public override double GetPriceWithTaxes(ITaxVisitor visitor)
        {
            return visitor.CalculateTaxesForCigarette(this);
        }
    }
}
