using UnityEngine;

namespace GoF.Decorator
{
    // 增加额外功能 A
    public class ConcreteDecoratorA : Decorator
    {
        Component component;
        public ConcreteDecoratorA(Component component) : base(component) { }

        public override void Operator()
        {
            base.Operator();
            AddBehavior();
        }

        private void AddBehavior()
        {
            Debug.Log("ConcreteDecoratorA.AddBehavior");
        }
    }
}