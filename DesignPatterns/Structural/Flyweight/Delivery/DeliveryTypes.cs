

using System.Text;

namespace DesignPatterns.Structural.Flyweight.Delivery
{
    public class DeliveryLocationData
    {
        public readonly string Street;
        public readonly string City;

        public DeliveryLocationData(string street, string city)
        {
            Street = street;
            City = city;
        }
    }

    public class DeliveryLocationDictionary
    {
        public Dictionary<string, DeliveryLocation> Locals = new Dictionary<string, DeliveryLocation>();

        public override string ToString()
        {
            var locals = Locals.Values;

            StringBuilder sb = new StringBuilder();

            foreach (var local in locals)
            {
                sb.AppendLine(local.ToString());
            }

            return sb.ToString();
        }
    }
}
