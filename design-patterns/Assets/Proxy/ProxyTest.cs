using UnityEngine;
namespace GoF.Proxy
{
    public class ProxyTest : MonoBehaviour
    {
        private void Awake()
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
