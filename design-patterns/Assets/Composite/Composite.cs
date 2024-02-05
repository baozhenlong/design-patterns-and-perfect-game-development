using System.Collections.Generic;
using UnityEngine;
namespace GoF.Composite
{
    public class Composite : IComponent
    {
        List<IComponent> children = new();
        public Composite(string value)
        {
            this.value = value;
        }
        public override void Operation()
        {
            Debug.Log($"Composite[{value}]");
            foreach (IComponent component in children)
            {
                component.Operation();
            }
        }
        public override void Add(IComponent component)
        {
            children.Add(component);
        }
        public override void Remove(IComponent component)
        {
            children.Remove(component);
        }
        public override IComponent GetChild(int index)
        {
            return children[index];
        }
    }
}