namespace GoF.Command
{
    public class ConcreteCommand2 : Command
    {
        private  readonly Receiver2 _receiver;
        private readonly int _param;
        public ConcreteCommand2(Receiver2 receiver, int param)
        {
            _receiver = receiver;
            _param = param;
        }

        public override void Execute()
        {
            _receiver.Action(_param);
        }
    }
}
