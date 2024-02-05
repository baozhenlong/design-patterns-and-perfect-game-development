using UnityEngine;
namespace GoF.ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        private int costCheck = 10;
        public ConcreteHandler1(Handler nextHandler) : base(nextHandler) { }
        public override void HandleRequest(int cost)
        {
            if (cost <= costCheck)
            {
                Debug.Log("ConcreteHandler1.HandleRequest 核准");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }
}