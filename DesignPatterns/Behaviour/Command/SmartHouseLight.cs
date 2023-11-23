
namespace DesignPatterns.Behaviour.Command
{
    public class SmartHouseLight
    {
        private bool isOn = false;
        private int intensity = 50;

        public string Name { get; set; }

        public SmartHouseLight(string name)
        {
            Name = name;
        }

        public string GetPowerStatus()
        {
            return isOn ? "ON" : "OFF";
        }

        public bool On()
        {
            isOn = true;
            Console.WriteLine($"{Name} agora está {GetPowerStatus()}");
            return isOn;
        }

        public bool Off()
        {
            isOn = false;
            Console.WriteLine($"{Name} agora está {GetPowerStatus()}");
            return isOn;
        }

        public int IncreaseIntensity()
        {
            if (intensity >= 100)
            {
                return intensity;
            }

            intensity += 1;
            return intensity;
        }

        public int DecreaseIntensity()
        {
            if (intensity <= 0)
            {
                return intensity;
            }

            intensity -= 1;
            return intensity;
        }
    }
}
