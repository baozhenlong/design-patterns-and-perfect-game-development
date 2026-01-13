namespace GoF.FactoryMethod
{
    public class FactoryMethodTest
    {
        public static void Test()
        {
            Console.WriteLine("====== SubclassUnitTest");
            SubclassUnitTest();
            Console.WriteLine("====== SubclassUnitTest");
            Console.WriteLine("====== MethodTypeUnitTest");
            MethodTypeUnitTest();
            Console.WriteLine("====== MethodTypeUnitTest");
            Console.WriteLine("====== GenericClassUnitTest");
            GenericClassUnitTest();
            Console.WriteLine("====== GenericClassUnitTest");
            Console.WriteLine("====== GenericMethodUnitTest");
            GenericMethodUnitTest();
            Console.WriteLine("====== GenericMethodUnitTest");
        }

        private static void SubclassUnitTest()
        {
            // 工厂接口
            Creator creator;

            // 设置为负责 ProductA 的工厂
            creator = new ConcreteCreatorProductA();
            creator.FactoryMethod();

            // 设置为负责 ProductB 的工厂
            creator = new ConcreteCreatorProductB();
            creator.FactoryMethod();
        }

        private static void MethodTypeUnitTest()
        {
            // 工厂接口
            CreatorMethodType creatorMethodType = new ConcreteCreatorMethodType();

            // 获取两个产品
            creatorMethodType.FactoryMethod(1);
            creatorMethodType.FactoryMethod(2);
        }

        private static void GenericClassUnitTest()
        {
            // 负责 ProduceA 的工厂
            CreatorGenericClass<ConcreteProductA> creatorProductA = new();
            creatorProductA.FactoryMethod();

            // 负责 ProduceB 的工厂
            CreatorGenericClass<ConcreteProductB> creatorProductB = new();
            creatorProductB.FactoryMethod();
        }

        private static void GenericMethodUnitTest()
        {
            ConcreteCreatorGenericMethod concreteCreatorGenericMethod = new();
            concreteCreatorGenericMethod.FactoryMethod<ConcreteProductA>();
            concreteCreatorGenericMethod.FactoryMethod<ConcreteProductB>();
        }
    }
}