namespace DesignPatterns.Creational.FactoryMethod.Utils
{
    public class RandomNumber
    {
        public static int RandomNumbers(int number)
        {
            var rnd = new Random();
            return rnd.Next(0, number);
        }
    }
}
