namespace GoF.Proxy
{
    public class RealSubject : Subject
    {
        public RealSubject()
        {
        }

        public override void Request()
        {
            Console.WriteLine("RealSubject.RealSubject");
        }
    }
}