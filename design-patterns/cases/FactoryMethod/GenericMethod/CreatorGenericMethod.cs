namespace GoF.FactoryMethod
{
    interface ICreatorGenericMethod
    {
        Product FactoryMethod<T>() where T : Product, new();
    }

    public class ConcreteCreatorGenericMethod : ICreatorGenericMethod
    {
        public ConcreteCreatorGenericMethod()
        {
        }

        public Product FactoryMethod<T>() where T : Product, new()
        {
            return new T();
        }
    }
}