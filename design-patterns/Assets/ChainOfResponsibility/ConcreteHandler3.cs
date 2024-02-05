using UnityEngine;
namespace GoF.ChainOfResponsibility
{

    public class ConcreteHandler3 : Handler
    {
        public ConcreteHandler3(Handler nextHandler) : base(nextHandler) { }
        public override void HandleRequest(int cost)
        {
            Debug.Log("ConcreteHandler3.HandleRequest 核准");
        }
    }
}