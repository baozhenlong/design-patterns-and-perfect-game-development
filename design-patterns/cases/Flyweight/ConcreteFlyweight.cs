namespace GoF.Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        public ConcreteFlyweight(string content) : base(content)
        {
        }

        public override void Operator()
        {
            Console.WriteLine($"ConcreteFlyweight.content[{GetContent()}]");
        }
    }
}