
namespace DesignPatterns.Structural.Bridge.Device
{
    public class Radio : IDeviceImplementation
    {
        private int volume = 10;
        private bool power = false;
        private string name = "Radio";

        public string GetName()
        {
            return name;
        }

        public bool GetPower()
        {
            return power;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetPower(bool powerStatus)
        {
            power = powerStatus;
        }

        public void SeVolume(int volume)
        {
            if (volume < 0)
            {
                return;
            }

            else if (volume > 100)
            {
                return;
            }

            this.volume = volume;
        }
    }
}
