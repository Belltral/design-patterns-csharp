
namespace DesignPatterns.Behaviour.Visitor
{
    public class AlcoholicDrink : VisitableProduct
    {
        public AlcoholicDrink(double price) : base("Alcoholic Drink", price)
        {
        }

        public override double GetPriceWithTaxes(ITaxVisitor visitor)
        {
            return visitor.CalculateTaxesForAlcoholicDrink(this);
        }
    }
}
