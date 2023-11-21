

namespace DesignPatterns.Structural.Flyweight.Delivery
{
    public class DeliveryFactory
    {
        private DeliveryLocationDictionary Locations = new DeliveryLocationDictionary();

        private string CreateId(DeliveryLocationData data)
        {
            var id = data.Street.Replace(" ", "") + data.City.Replace(" ", "");
            return id;
        }

        public IDeliveryFlyweight MakeLocation(DeliveryLocationData intrinsicState)
        {
            var key = CreateId(intrinsicState);

            try
            {
                return Locations.Locals[key];
            }
                
            catch (KeyNotFoundException)
            {
                var newKey = Locations.Locals[key] = new DeliveryLocation(intrinsicState);
                return newKey;
            }
        }

        public Dictionary<string, DeliveryLocation> GetLocations()
        {
            return Locations.Locals;
        }
    }
}
