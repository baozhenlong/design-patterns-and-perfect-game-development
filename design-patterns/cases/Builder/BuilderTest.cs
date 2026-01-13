namespace GoF.Builder
{
    public class BuilderTest
    {
        public static void Test()
        {
            UnitTest();
        }
        private static void UnitTest()
        {
            // 创建
            Director director = new();
            Product buildProduct;

            // 使用 BuildA 构建
            director.Construct(new ConcreteBuilderA());
            buildProduct = director.GetResult();
            buildProduct.ShowProduct();

            Console.WriteLine(new string('-', 50));
            
            // 使用 BuildB 构建
            director.Construct(new ConcreteBuilderB());
            buildProduct = director.GetResult();
            buildProduct.ShowProduct();
        }
    }
}