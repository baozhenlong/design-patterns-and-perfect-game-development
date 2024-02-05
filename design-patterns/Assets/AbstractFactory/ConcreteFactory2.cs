namespace GoF.AbstractFactory
{
    // 实现可构建具体成品对象的操作 2
    public class ConcreteFactory2 : AbstractFactory
    {
        public ConcreteFactory2() { }
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}