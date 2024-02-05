using UnityEngine;

namespace GoF.Proxy
{
    public class Proxy : Subject
    {
        RealSubject realSubject = new();

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
                realSubject.Request();
            }
            else
            {
                Debug.Log("Proxy.Request");
            }
        }
    }
}