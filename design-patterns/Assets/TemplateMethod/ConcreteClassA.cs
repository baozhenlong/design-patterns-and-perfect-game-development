using UnityEngine;

namespace GoF.TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Debug.Log("ConcreteClassA.PrimitiveOperation1");
        }
        protected override void PrimitiveOperation2()
        {
            Debug.Log("ConcreteClassA.PrimitiveOperation2");
        }
    }
}