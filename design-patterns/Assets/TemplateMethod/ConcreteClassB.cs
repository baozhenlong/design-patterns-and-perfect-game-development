using UnityEngine;
namespace GoF.TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Debug.Log("ConcreteClassB.PrimitiveOperation1");
        }
        protected override void PrimitiveOperation2()
        {
            Debug.Log("ConcreteClassB.PrimitiveOperation2");
        }
    }
}