

namespace DesignPatterns.Structural.Flyweight.Delivery
{
    public class DeliveryContext
    {
        public static void DeliveryContextFn(
            DeliveryFactory factory,
            string name,
            string number,
            string street,
            string city
        )
        {
            var location = factory.MakeLocation(new DeliveryLocationData(street, city));
            location.Deliver(name, number);
        }
    }
}
