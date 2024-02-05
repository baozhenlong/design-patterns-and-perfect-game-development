using UnityEngine;
namespace GoF.Command
{
    public class CommandTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            Invoker invoker = new();

            Command command = null;
            // 将命令与执行结合
            command = new ConcreteCommand1(new Receiver1(), "你好");
            invoker.AddCommand(command);
            command = new ConcreteCommand2(new Receiver2(), 999);
            invoker.AddCommand(command);

            // 执行
            invoker.ExecuteCommand();
        }
    }
}