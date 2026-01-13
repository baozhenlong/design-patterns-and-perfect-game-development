namespace GoF.ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        private const int CostCheck = 20;

        public ConcreteHandler2(Handler nextHandler) : base(nextHandler)
        {
        }

        public override void HandleRequest(int cost)
        {
            if (cost <= CostCheck)
            {
                Console.WriteLine("ConcreteHandler2.HandleRequest 核准");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }
}