namespace GoF.Decorator
{
    public class DecoratorTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            ConcreteComponent component = new();

            ConcreteDecoratorA decoratorA = new(component);
            decoratorA.Operator();

            ConcreteDecoratorB decoratorB = new(component);
            decoratorB.Operator();

            ConcreteDecoratorB decoratorB2 = new(decoratorA);
            decoratorB2.Operator();
        }
    }
}