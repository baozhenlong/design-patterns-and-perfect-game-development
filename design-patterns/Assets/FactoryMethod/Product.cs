using UnityEngine;

namespace GoF.FactoryMethod
{
    // 产品对象类
    public abstract class Product { }


    // 产品对象类 A
    public class ConcreteProductA : Product
    {
        public ConcreteProductA()
        {
            Debug.Log("生成对象类 A");
        }
    }

    // 产品对象类 B
    public class ConcreteProductB : Product
    {
        public ConcreteProductB()
        {
            Debug.Log("生成对象类 B");
        }
    }
}