namespace GoF.AbstractFactory
{
    // 对象成品类型 A2
    public class ProductA2 : AbstractProductA
    {
        public ProductA2()
        {
            Console.WriteLine("生成对象类型 A2");
        }
    }

    // 对象成品类型 B2
    public class ProductB2 : AbstractProductB
    {
        public ProductB2()
        {
            Console.WriteLine("生成对象类型 B2");
        }
    }
}