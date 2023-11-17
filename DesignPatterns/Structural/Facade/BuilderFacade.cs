
using DesignPatterns.Creational.Builder.Classes;

namespace DesignPatterns.Structural.Facade
{
    public class BuilderFacade
    {
        // Fachada para a pasta Creational/Builder
        private MainDishBuilder mainDishBuilder = new MainDishBuilder();

        public void MakeMeal1()
        {
            mainDishBuilder.MakeMeal();
            Console.Write(mainDishBuilder.GetMeal());
            Console.WriteLine(mainDishBuilder.GetPrice());
            Console.WriteLine();
        }

        public void MakeMeal2()
        {
            mainDishBuilder.Reset();
            Console.WriteLine(mainDishBuilder.MakeBeverage());
        }
    }
}
