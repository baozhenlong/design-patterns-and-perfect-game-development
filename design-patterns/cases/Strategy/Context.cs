namespace GoF.Strategy
{
    // 拥有 Strategy 的客户端
    public class Context
    {
        Strategy strategy;

        public void SetStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}