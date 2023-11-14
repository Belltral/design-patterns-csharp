
namespace DesignPatterns.Structural.Bridge.Device
{
    public interface IDeviceImplementation
    {
        public string GetName();
        public void SetPower(bool powerStatus);
        public bool GetPower();
        public void SeVolume(int volume);
        public int GetVolume();
    }
}
