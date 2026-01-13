namespace GoF.Adapter
{
    public class AdapterTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}