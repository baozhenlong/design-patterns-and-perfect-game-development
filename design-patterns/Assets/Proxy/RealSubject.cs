
using UnityEngine;

namespace GoF.Proxy
{
    public class RealSubject : Subject
    {
        public RealSubject() { }
        public override void Request()
        {
            Debug.Log("RealSubject.RealSubject");
        }
    }
}