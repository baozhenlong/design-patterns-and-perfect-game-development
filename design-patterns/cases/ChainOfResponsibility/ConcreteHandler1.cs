namespace GoF.ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        private const int CostCheck = 10;

        public ConcreteHandler1(Handler? nextHandler) : base(nextHandler)
        {
        }

        public override void HandleRequest(int cost)
        {
            if (cost <= CostCheck)
            {
                Console.WriteLine("ConcreteHandler1.HandleRequest 核准");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }
}