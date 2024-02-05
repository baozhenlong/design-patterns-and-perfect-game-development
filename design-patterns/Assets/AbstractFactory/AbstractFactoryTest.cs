using UnityEngine;
namespace GoF.AbstractFactory
{
    public class AbstractFactoryTest : MonoBehaviour
    {
        private void Awake()
        {
            AbstractFactory factory = null;

            // 工厂 1
            factory = new ConcreteFactory1();
            // 产生两个产品
            factory.CreateProductA();
            factory.CreateProductB();

            // 工厂 2
            factory = new ConcreteFactory2();
            // 产生两个产品
            factory.CreateProductA();
            factory.CreateProductB();
        }
    }
}