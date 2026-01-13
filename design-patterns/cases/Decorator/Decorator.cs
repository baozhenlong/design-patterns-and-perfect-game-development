namespace GoF.Decorator
{
    public class Decorator : Component
    {
        private readonly Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override void Operator()
        {
            _component.Operator();
        }
    }
}