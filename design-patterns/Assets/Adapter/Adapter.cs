namespace GoF.Adapter
{
    public class Adapter : Target
    {
        private Adaptee adaptee = new();
        public Adapter() { }

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}