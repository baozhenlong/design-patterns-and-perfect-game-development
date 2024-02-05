using UnityEngine;
namespace GoF.FactoryMethod
{
    public class ConcreteCreatorMethodType : CreatorMethodType
    {
        public ConcreteCreatorMethodType()
        {
            Debug.Log("产生工厂: ConcreteCreatorMethodType");
        }

        public override Product FactoryMethod(int type)
        {
            switch (type)
            {
                case 1:
                    return new ConcreteProductA();
                case 2:
                    return new ConcreteProductB();
                default:
                    Debug.Log($"Type [{type}] 无法产生对象");
                    break;
            }
            return null;
        }
    }
}