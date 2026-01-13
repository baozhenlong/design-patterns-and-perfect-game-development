namespace GoF.FactoryMethod
{
    // 产生 ProductA 的工厂
    public class ConcreteCreatorProductA : Creator
    {
        public ConcreteCreatorProductA()
        {
            Console.WriteLine("产生工厂: ConcreteCreatorProductA");
        }

        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    // 产生 ProductB 的工厂
    public class ConcreteCreatorProductB : Creator
    {
        public ConcreteCreatorProductB()
        {
            Console.WriteLine("产生工厂: ConcreteCreatorProductB");
        }

        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}