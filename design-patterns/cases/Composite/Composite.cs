using System.Collections.Generic;

namespace GoF.Composite
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> _children = new();

        public Composite(string value)
        {
            this.value = value;
        }

        public override void Operation()
        {
            Console.WriteLine($"Composite[{value}]");
            foreach (IComponent component in _children)
            {
                component.Operation();
            }
        }

        public override void Add(IComponent component)
        {
            _children.Add(component);
        }

        public override void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public override IComponent GetChild(int index)
        {
            return _children[index];
        }
    }
}