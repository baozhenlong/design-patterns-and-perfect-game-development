namespace GoF.Decorator
{
    public class Decorator : Component
    {
        Component component;
        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operator()
        {
            component.Operator();
        }
    }
}