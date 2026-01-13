namespace GoF.Bridge
{
    public class RefinedAbstraction2 : Abstraction
    {
        public RefinedAbstraction2()
        {
        }

        public override void Operation()
        {
            Console.WriteLine("物件 RefinedAbstraction2");
            base.Operation();
        }
    }
}