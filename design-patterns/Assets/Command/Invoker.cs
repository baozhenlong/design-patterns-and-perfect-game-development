using System.Collections.Generic;
namespace GoF.Command
{
    public class Invoker
    {
        List<Command> commands = new();

        // 加入命令
        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        // 执行命令
        public void ExecuteCommand()
        {
            // 执行
            foreach (Command command in commands)
            {
                command.Execute();
            }
            // 清空
            commands.Clear();
        }
    }
}