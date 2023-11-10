using DesignPatterns.Creational.Builder.interfaces;

namespace DesignPatterns.Creational.Builder.Classes.Classes
{
    public abstract class AbstractMeal : IMealComposite
    {
        private string Name { get; set; }
        private double Price { get; set; }

        public AbstractMeal() { }

        public AbstractMeal(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
