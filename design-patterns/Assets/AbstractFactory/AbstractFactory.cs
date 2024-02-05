namespace GoF.AbstractFactory
{
    // 可生成各抽象成品对象的操作
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}