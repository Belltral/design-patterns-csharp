

namespace DesignPatterns.Behaviour.Visitor
{
    public class USTaxVisitor : ITaxVisitor
    {
        public double CalculateTaxesForAlcoholicDrink(AlcoholicDrink alcoholicDrink)
        {
            return alcoholicDrink.GetPrice() + (alcoholicDrink.GetPrice() * 0.15);
        }

        public double CalculateTaxesForCigarette(Cigarette cigarette)
        {
            return cigarette.GetPrice() + (cigarette.GetPrice() * 2);
        }

        public double CalculateTaxesForFood(Food food)
        {
            return food.GetPrice() + (food.GetPrice() * 1);
        }
    }
}
