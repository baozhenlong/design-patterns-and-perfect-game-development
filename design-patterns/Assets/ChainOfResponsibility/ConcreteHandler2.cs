using UnityEngine;

namespace GoF.ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        private int costCheck = 20;
        public ConcreteHandler2(Handler nextHandler) : base(nextHandler) { }
        public override void HandleRequest(int cost)
        {
            if (cost <= costCheck)
            {
                Debug.Log("ConcreteHandler2.HandleRequest 核准");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }
}