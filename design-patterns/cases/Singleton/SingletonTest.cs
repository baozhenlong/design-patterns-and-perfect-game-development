namespace GoF.Singleton
{
    public class SingletonTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            Singleton.Instance.Name = "Hello";
            Singleton.Instance.Name = "World";
            Console.WriteLine(Singleton.Instance.Name);
        }
    }
}