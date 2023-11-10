using DesignPatterns.Creational.Builder.Classes.Classes;
using DesignPatterns.Creational.Builder.interfaces;

namespace DesignPatterns.Creational.Builder.Classes
{
    internal class MainDishBuilder : IMealBuilder
    {
        private MealBox _meal = new MealBox();

        public IMealBuilder Reset()
        {
            _meal = new MealBox();
            return this;
        }

        public IMealBuilder MakeBeverage()
        {
            var rice = new Rice("Arroz", 5);
            var beans = new Beans("Feijão", 10);
            var meat = new Meat("Carne", 20);
            _meal.Add(rice);
            _meal.Add(beans);
            _meal.Add(meat);

            return this;
        }

        public IMealBuilder MakeDessert()
        {
            var beverage = new Beverage("Bebida", 7);
            _meal.Add(beverage);

            return this;
        }

        public IMealBuilder MakeMeal()
        {
            var desset = new Dessert("Sobremesa", 10);
            _meal.Add(desset);
            return this;
        }
    }
}
