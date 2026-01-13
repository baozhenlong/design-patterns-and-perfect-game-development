namespace GoF.Strategy
{
    public class StrategyTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            Context context = new();

            context.SetStrategy(new ConcreteStrategyA());
            context.ContextInterface();
            Console.WriteLine(new string('-', 50));
            context.SetStrategy(new ConcreteStrategyB());
            context.ContextInterface();
            Console.WriteLine(new string('-', 50));
            context.SetStrategy(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }
}