
namespace DesignPatterns.Behaviour.Command
{
    public class LightIntensityCommand : ISmartHouseCommand
    {
        private readonly SmartHouseLight _light;

        public LightIntensityCommand(SmartHouseLight light)
        {
            _light = light;
        }

        public void Execute()
        {
            var intensity = _light.IncreaseIntensity();
            Console.WriteLine($"Intensidade de {_light.Name} é {intensity}");
        }

        public void Undo()
        {
            var intensity = _light.DecreaseIntensity();
            Console.WriteLine($"Intensidade de {_light.Name} é {intensity}");
        }
    }
}
