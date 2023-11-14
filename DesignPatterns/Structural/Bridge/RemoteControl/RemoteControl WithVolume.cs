
using DesignPatterns.Structural.Bridge.Device;

namespace DesignPatterns.Structural.Bridge.RemoteControl
{
    public class RemoteControlWithVolume : RemoteControl
    {
        public RemoteControlWithVolume()
        {

        }

        public RemoteControlWithVolume(IDeviceImplementation device)
        {
            Device = device;
        }

        public void VolumeUp()
        {
            var oldVolume = Device.GetVolume();
            Device.SeVolume(Device.GetVolume() + 10);

            Console.WriteLine($"{Device.GetName()} tinha o volume {oldVolume} agora tem {Device.GetVolume()}");
        }

        public void VolumeDown()
        {
            var oldVolume = Device.GetVolume();
            Device.SeVolume(Device.GetVolume() - 10);

            Console.WriteLine($"{Device.GetName()} tinha o volume {oldVolume} agora tem {Device.GetVolume()}");
        }
    }
}
