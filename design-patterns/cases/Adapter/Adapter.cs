namespace GoF.Adapter
{
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee = new();

        public Adapter()
        {
        }

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}