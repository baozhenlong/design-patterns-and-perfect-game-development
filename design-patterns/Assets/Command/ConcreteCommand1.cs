namespace GoF.Command
{
    public class ConcreteCommand1 : Command
    {
        Receiver1 receiver = null;
        string command = "";
        public ConcreteCommand1(Receiver1 receiver, string command)
        {
            this.receiver = receiver;
            this.command = command;
        }

        public override void Execute()
        {
            receiver.Action(command);
        }
    }
}
