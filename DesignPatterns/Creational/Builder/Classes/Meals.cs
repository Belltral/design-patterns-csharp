namespace DesignPatterns.Creational.Builder.Classes.Classes
{
    public class Rice : AbstractMeal
    {
        public Rice(string name, double price) : base(name, price) { }
    }
    public class Beans : AbstractMeal
    {
        public Beans(string name, double price) : base(name, price) { }
    }
    public class Meat : AbstractMeal
    {
        public Meat(string name, double price) : base(name, price) { }
    }
    public class Beverage : AbstractMeal
    {
        public Beverage(string name, double price) : base(name, price) { }
    }
    public class Dessert : AbstractMeal
    {
        public Dessert(string name, double price) : base(name, price) { }
    }
}
