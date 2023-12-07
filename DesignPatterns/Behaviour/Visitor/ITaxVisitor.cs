
namespace DesignPatterns.Behaviour.Visitor
{
    public interface ITaxVisitor
    {
        public double CalculateTaxesForFood(Food food);
        public double CalculateTaxesForCigarette(Cigarette cigarette);
        public double CalculateTaxesForAlcoholicDrink(AlcoholicDrink alcoholicDrink);
    }
}
