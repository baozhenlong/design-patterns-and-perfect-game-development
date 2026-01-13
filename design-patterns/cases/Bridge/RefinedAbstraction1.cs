namespace GoF.Bridge
{
    public class RefinedAbstraction1 : Abstraction
    {
        public RefinedAbstraction1()
        {
        }

        public override void Operation()
        {
            Console.WriteLine("物件 RefinedAbstraction1");
            base.Operation();
        }
    }
}