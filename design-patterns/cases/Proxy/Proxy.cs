namespace GoF.Proxy
{
    public class Proxy : Subject
    {
        private readonly RealSubject _realSubject = new();

        // 权限控制
        public bool ConnectRemote { get; set; }

        public Proxy()
        {
            ConnectRemote = false;
        }

        public override void Request()
        {
            // 按照当前状态决定是否存取 RealSubject
            if (ConnectRemote)
            {
                _realSubject.Request();
            }
            else
            {
                Console.WriteLine("Proxy.Request");
            }
        }
    }
}