
using DesignPatterns.Structural.Bridge.Device;

namespace DesignPatterns.Structural.Bridge.RemoteControl
{
    public class RemoteControl
    {
        protected IDeviceImplementation Device { get; set; }

        public RemoteControl()
        {
            
        }

        public RemoteControl(IDeviceImplementation device)
        {
            Device = device;
        }

        public void TogglePower()
        {
            Device.SetPower(!Device.GetPower());
            Console.WriteLine($"{Device.GetName()} power status {Device.GetPower()}");
        }
    }
}
