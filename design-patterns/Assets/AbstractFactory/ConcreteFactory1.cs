namespace GoF.AbstractFactory
{
    // 实现可构建具体成品对象的操作 1
    public class ConcreteFactory1 : AbstractFactory
    {
        public ConcreteFactory1() { }
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}