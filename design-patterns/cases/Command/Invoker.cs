using System.Collections.Generic;

namespace GoF.Command
{
    public class Invoker
    {
        private readonly List<Command> _commands = new();

        // 加入命令
        public void AddCommand(Command command)
        {
            _commands.Add(command);
        }

        // 执行命令
        public void ExecuteCommand()
        {
            // 执行
            foreach (Command command in _commands)
            {
                command.Execute();
            }

            // 清空
            _commands.Clear();
        }
    }
}