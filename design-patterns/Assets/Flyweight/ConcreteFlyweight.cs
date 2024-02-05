using UnityEngine;

namespace GoF.Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        public ConcreteFlyweight(string content) : base(content) { }

        public override void Operator()
        {
            Debug.Log($"ConcreteFlyweight.content[{content}]");
        }
    }
}