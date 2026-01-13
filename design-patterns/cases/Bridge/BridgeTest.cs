
namespace GoF.Bridge
{
    public class BridgeTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            Abstraction abstraction = new RefinedAbstraction1();

            abstraction.SetImplementor(new ConcreteImplementor1());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementor2());
            abstraction.Operation();
            
            Console.WriteLine(new string('-', 50));

            abstraction = new RefinedAbstraction2();
            abstraction.SetImplementor(new ConcreteImplementor1());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementor2());
            abstraction.Operation();
        }
    }
}