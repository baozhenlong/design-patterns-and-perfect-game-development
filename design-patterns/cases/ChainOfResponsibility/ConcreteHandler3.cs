namespace GoF.ChainOfResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        public ConcreteHandler3(Handler? nextHandler) : base(nextHandler)
        {
        }

        public override void HandleRequest(int cost)
        {
            Console.WriteLine("ConcreteHandler3.HandleRequest 核准");
        }
    }
}