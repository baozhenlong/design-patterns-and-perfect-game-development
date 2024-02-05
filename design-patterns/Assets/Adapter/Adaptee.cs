using UnityEngine;

namespace GoF.Adapter
{
    public class Adaptee
    {
        public Adaptee() { }
        public void SpecificRequest()
        {
            Debug.Log("调用 Adaptee.SpecificRequest");
        }
    }
}