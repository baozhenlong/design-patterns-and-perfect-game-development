using UnityEngine;

namespace GoF.Command
{
    // 负责执行命令 1
    public class Receiver1
    {
        public Receiver1() { }
        public void Action(string command)
        {
            Debug.Log($"Receiver1.Action: Command[{command}]");
        }
    }
}