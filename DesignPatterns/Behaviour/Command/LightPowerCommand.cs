

namespace DesignPatterns.Behaviour.Command
{
    public class LightPowerCommand : ISmartHouseCommand
    {
        private readonly SmartHouseLight _light;

        public LightPowerCommand(SmartHouseLight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
