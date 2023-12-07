
namespace DesignPatterns.Behaviour.Visitor
{
    public class BrazilTaxVisitor : ITaxVisitor
    {
        public double CalculateTaxesForAlcoholicDrink(AlcoholicDrink alcoholicDrink)
        {
            return alcoholicDrink.GetPrice() + (alcoholicDrink.GetPrice() * 0.5);
        }

        public double CalculateTaxesForCigarette(Cigarette cigarette)
        {
            return cigarette.GetPrice() + (cigarette.GetPrice() * 1.5);
        }

        public double CalculateTaxesForFood(Food food)
        {
            return food.GetPrice() + (food.GetPrice() * 0.05);
        }
    }
}
