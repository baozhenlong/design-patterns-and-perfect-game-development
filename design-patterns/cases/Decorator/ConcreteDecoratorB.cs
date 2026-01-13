namespace GoF.Decorator
{
    // 增加额外功能 B
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }

        public override void Operator()
        {
            base.Operator();
            AddBehavior();
        }

        private void AddBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB.AddBehavior");
        }
    }
}