namespace GoF.State
{
    // 状态 A
    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context context) : base(context)
        {
        }

        public override void Handle(int value)
        {
            Console.WriteLine($"ConcreteStateA.Handle value: {value}");
            if (value > 10)
            {
                context.SetState(new ConcreteStateB(context));
            }
        }
    }
}