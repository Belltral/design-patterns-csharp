namespace DesignPatterns.Creational.Builder.interfaces
{
    public interface IMealBuilder
    {
        public IMealBuilder MakeMeal();
        public IMealBuilder MakeBeverage();
        public IMealBuilder MakeDessert();
    }
}
