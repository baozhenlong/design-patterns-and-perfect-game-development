using UnityEngine;

namespace GoF.State
{
    // 状态 B
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context context) : base(context) { }
        public override void Handle(int value)
        {
            Debug.Log($"ConcreteStateB.Handle");
            if (value > 20)
            {
                context.SetState(new ConcreteStateC(context));
            }
        }
    }
}