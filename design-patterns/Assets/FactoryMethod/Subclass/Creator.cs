namespace GoF.FactoryMethod
{
    public abstract class Creator
    {
        // 子类返回对应的 Product 类型对象
        public abstract Product FactoryMethod();
    }
}