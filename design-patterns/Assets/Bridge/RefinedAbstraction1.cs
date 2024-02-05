
using UnityEngine;

namespace GoF.Bridge
{
    public class RefinedAbstraction1 : Abstraction
    {
        public RefinedAbstraction1() { }

        public override void Operation()
        {
            Debug.Log("物件 RefinedAbstraction1");
            base.Operation();
        }
    }
}