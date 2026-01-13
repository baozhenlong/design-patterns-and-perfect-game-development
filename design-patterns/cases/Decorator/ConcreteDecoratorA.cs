namespace GoF.Decorator
{
    // 增加额外功能 A
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override void Operator()
        {
            base.Operator();
            AddBehavior();
        }

        private void AddBehavior()
        {
            Console.WriteLine("ConcreteDecoratorA.AddBehavior");
        }
    }
}