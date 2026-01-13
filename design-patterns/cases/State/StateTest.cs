
namespace GoF.State
{
    public class StateTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            Context context = new();
            context.SetState(new ConcreteStateA(context));

            context.Request(5);
            context.Request(15);
            context.Request(25);
            context.Request(35);
        }
    }
}