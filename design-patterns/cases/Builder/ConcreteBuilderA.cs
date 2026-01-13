namespace GoF.Builder
{
    // builder 接口的具体实现 A
    public class ConcreteBuilderA : Builder
    {
        public override void BuildPart1(Product buildProduct)
        {
            buildProduct.AddPart("ConcreteBuilderA Part1");
        }

        public override void BuildPart2(Product buildProduct)
        {
            buildProduct.AddPart("ConcreteBuilderA Part2");
        }
    }
}