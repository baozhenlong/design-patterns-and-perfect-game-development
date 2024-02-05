namespace GoF.Builder
{
    // builder 接口的具体实现 B
    public class ConcreteBuilderB : Builder
    {
        public override void BuildPart1(Product buildProduct)
        {
            buildProduct.AddPart("ConcreteBuilderB Part1");
        }
        public override void BuildPart2(Product buildProduct)
        {
            buildProduct.AddPart("ConcreteBuilderB Part2");
        }
    }
}