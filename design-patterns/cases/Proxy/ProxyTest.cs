namespace GoF.Proxy
{
    public class ProxyTest
    {
        public static void Test()
        {
            UnitTest();
        }
        private static void UnitTest()
        {
            // 产生 Proxy
            Proxy proxy = new();

            // 通过 Proxy 存取
            proxy.Request();
            proxy.ConnectRemote = true;
            proxy.Request();
        }
    }
}
