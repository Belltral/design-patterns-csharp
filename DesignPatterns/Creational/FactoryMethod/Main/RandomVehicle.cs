using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Vehicle;
using DesignPatterns.Creational.FactoryMethod.Utils;

namespace DesignPatterns.Creational.FactoryMethod.Main
{
    public class RandomVehicle
    {
        public static IVehicle RandomCarAlgorithm()
        {
            var carFactory = new CarFactory();
            var bicycleFactory = new BicycleFactory();
            var car1 = carFactory.GetVehicle("Fusca");
            var car2 = carFactory.GetVehicle("Celta Preto");
            var bicycle = bicycleFactory.GetVehicle("Bicicleta");
            List<IVehicle> cars = new List<IVehicle>() { car1, car2, bicycle};
            return cars[RandomNumber.RandomNumbers(cars.Count())];
        }
    }
}
