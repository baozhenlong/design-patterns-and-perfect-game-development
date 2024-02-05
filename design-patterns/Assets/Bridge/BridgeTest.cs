using UnityEngine;

namespace GoF.Bridge
{
    public class BridgeTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            Abstraction abstraction = new RefinedAbstraction1();

            abstraction.SetImplementor(new ConcreteImplementor1());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementor2());
            abstraction.Operation();


            abstraction = new RefinedAbstraction2();
            abstraction.SetImplementor(new ConcreteImplementor1());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementor2());
            abstraction.Operation();
        }
    }
}