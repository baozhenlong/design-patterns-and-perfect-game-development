using UnityEngine;
namespace GoF.TemplateMethod
{
    public class TemplateMethodTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            AbstractClass theClass = new ConcreteClassA();
            theClass.TemplateMethod();

            theClass = new ConcreteClassB();
            theClass.TemplateMethod();
        }
    }
}