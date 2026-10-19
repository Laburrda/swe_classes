using System.Collections.Generic;

namespace SpreadSheetCommandPattern
{
    public class Engine
    {
        private List<ICommand> _commandList = new List<ICommand>();

        public void PlaceCommand(ICommand command)
        {
            this._commandList.Add(command);
        }

        public void ExecuteAllCommands()
        {
            foreach (ICommand command in this._commandList)
            {
                command.Execute();
            }
            this._commandList.Clear();
        }
    }
}
