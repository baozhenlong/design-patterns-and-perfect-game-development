namespace GoF.Command
{
    public class ConcreteCommand2 : Command
    {
        Receiver2 receiver = null;
        int param = 0;
        public ConcreteCommand2(Receiver2 receiver, int param)
        {
            this.receiver = receiver;
            this.param = param;
        }

        public override void Execute()
        {
            receiver.Action(param);
        }
    }
}
