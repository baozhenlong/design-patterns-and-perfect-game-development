using UnityEngine;
namespace GoF.ChainOfResponsibility
{
    public class ChainOfResponsibilityTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            // 产生 Cost 的验证链接方式
            ConcreteHandler3 handler3 = new(null);
            ConcreteHandler2 handler2 = new(handler3);
            ConcreteHandler1 handler1 = new(handler2);

            // 确认
            handler1.HandleRequest(10);
            handler1.HandleRequest(15);
            handler1.HandleRequest(20);
            handler1.HandleRequest(30);
            handler1.HandleRequest(100);
        }
    }
}