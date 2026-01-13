namespace GoF.Command
{
    public class ConcreteCommand1 : Command
    {
        private readonly Receiver1 _receiver;
        private readonly string _command;

        public ConcreteCommand1(Receiver1 receiver, string command)
        {
            _receiver = receiver;
            _command = command;
        }

        public override void Execute()
        {
            _receiver.Action(_command);
        }
    }
}