using UnityEngine;

namespace GoF.FactoryMethod
{
    // 产生 ProductA 的工厂
    public class ConcreteCreatorProductA : Creator
    {
        public ConcreteCreatorProductA()
        {
            Debug.Log("产生工厂: ConcreteCreatorProductA");
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
            Debug.Log("产生工厂: ConcreteCreatorProductB");
        }
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}