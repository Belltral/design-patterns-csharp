

using System.IO;

namespace DesignPatterns.Structural.Flyweight.Delivery
{
    public class DeliveryLocation : IDeliveryFlyweight
    {
        private readonly DeliveryLocationData _intrisicState;

        public DeliveryLocation() { }

        public DeliveryLocation(DeliveryLocationData intrinsicState)
        {
            _intrisicState = intrinsicState;
        }

        public void Deliver(string name, string number)
        {
            Console.WriteLine($"Entrega para: {name}");
            Console.WriteLine($"Em: {_intrisicState.Street}, {_intrisicState.City}");
            Console.WriteLine($"Número: {number}");
            Console.WriteLine("==================================================");
        }

        public override string ToString()
        {
            return $"{_intrisicState.Street}, {_intrisicState.City}";
        }
    }
}
