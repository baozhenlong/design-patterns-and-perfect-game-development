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
            Console.WriteLine($"Leaf[{value}] 执行 Operation");
        }
    }
}