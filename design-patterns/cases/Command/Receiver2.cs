namespace GoF.Command
{
    // 负责执行命令 2
    public class Receiver2
    {
        public Receiver2()
        {
        }

        public void Action(int param)
        {
            Console.WriteLine($"Receiver2.Action: Param[{param}]");
        }
    }
}