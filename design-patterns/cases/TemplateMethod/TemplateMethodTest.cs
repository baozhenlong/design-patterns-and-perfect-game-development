namespace GoF.TemplateMethod
{
    public class TemplateMethodTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            AbstractClass theClass = new ConcreteClassA();
            theClass.TemplateMethod();

            Console.WriteLine(new string('-', 50));

            theClass = new ConcreteClassB();
            theClass.TemplateMethod();
        }
    }
}