namespace GoF.State
{
    // 状态 C
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context context) : base(context)
        {
        }

        public override void Handle(int value)
        {
            Console.WriteLine($"ConcreteStateC.Handle value: {value}");
            if (value > 30)
            {
                context.SetState(new ConcreteStateA(context));
            }
        }
    }
}