namespace DesignPatterns.Creational.FactoryMethod.Vehicle
{
    public class Bicycle : IVehicle
    {
        public string Name { get; set; }

        public Bicycle(string name)
        {
            Name = name;
        }

        public void PickUp(string customerName)
        {
            Console.WriteLine($"{Name} está buscando {customerName}."); ;
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} parou."); ;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
