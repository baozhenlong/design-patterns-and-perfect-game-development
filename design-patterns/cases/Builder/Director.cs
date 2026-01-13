namespace GoF.Builder
{
    public class Director
    {
        private Product buildProduct;

        public Director()
        {
        }

        // 构建
        public void Construct(Builder builder)
        {
            // 利用 builder 产生各部分加入 buildProduct
            buildProduct = new Product();
            builder.BuildPart1(buildProduct);
            builder.BuildPart2(buildProduct);
        }

        // 获取成品
        public Product GetResult()
        {
            return buildProduct;
        }
    }
}