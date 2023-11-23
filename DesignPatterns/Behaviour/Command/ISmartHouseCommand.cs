

namespace DesignPatterns.Behaviour.Command
{
    public interface ISmartHouseCommand
    {
        public void Execute();
        public void Undo();
    }
}
