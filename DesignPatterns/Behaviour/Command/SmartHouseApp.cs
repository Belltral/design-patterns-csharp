﻿

namespace DesignPatterns.Behaviour.Command
{
    public class SmartHouseApp
    {
        private Dictionary<string, ISmartHouseCommand> commands = new Dictionary<string, ISmartHouseCommand>();

        public void AddCommand(string key, ISmartHouseCommand command)
        {
            commands.Add(key, command);
        }

        public void ExecuteCommand(string key)
        {
            commands[key].Execute();
        }

        public void UndoCommand(string key)
        {
            commands[key].Undo();
        }
    }
}
