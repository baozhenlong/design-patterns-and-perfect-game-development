namespace GoF.AbstractFactory
{
    public class AbstractFactoryTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            AbstractFactory factory;

            // 工厂 1
            factory = new ConcreteFactory1();
            // 产生两个产品
            factory.CreateProductA();
            factory.CreateProductB();

            // 工厂 2
            factory = new ConcreteFactory2();
            // 产生两个产品
            factory.CreateProductA();
            factory.CreateProductB();
        }
    }
}