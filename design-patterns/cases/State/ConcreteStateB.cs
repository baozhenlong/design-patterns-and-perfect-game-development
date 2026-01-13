namespace GoF.State
{
    // 状态 B
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context context) : base(context)
        {
        }

        public override void Handle(int value)
        {
            Console.WriteLine($"ConcreteStateB.Handle  value: {value}");
            if (value > 20)
            {
                context.SetState(new ConcreteStateC(context));
            }
        }
    }
}