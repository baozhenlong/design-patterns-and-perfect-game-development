namespace GoF.Adapter
{
    public class Adaptee
    {
        public Adaptee()
        {
        }

        public void SpecificRequest()
        {
            Console.WriteLine("调用 Adaptee.SpecificRequest");
        }
    }
}