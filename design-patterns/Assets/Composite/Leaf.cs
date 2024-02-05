using UnityEngine;
namespace GoF.Composite
{
    public class Leaf : IComponent
    {
        public Leaf(string value)
        {
            this.value = value;
        }
        public override void Operation()
        {
            Debug.Log($"Leaf[{value}] 执行 Operation");
        }
    }
}