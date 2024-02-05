using UnityEngine;

namespace GoF.State
{
    // 状态 C
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context context) : base(context) { }
        public override void Handle(int value)
        {
            Debug.Log($"ConcreteStateC.Handle");
            if (value > 30)
            {
                context.SetState(new ConcreteStateA(context));
            }
        }
    }
}