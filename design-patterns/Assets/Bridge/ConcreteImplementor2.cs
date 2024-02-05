using UnityEngine;

namespace GoF.Bridge
{
    public class ConcreteImplementor2 : Implementor
    {
        public ConcreteImplementor2() { }
        public override void OperationImp()
        {
            Debug.Log("执行 ConcreteImplementor2.OperationImp");
        }
    }
}