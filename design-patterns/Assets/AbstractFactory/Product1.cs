
using UnityEngine;

namespace GoF.AbstractFactory
{
    // 对象成品类型 A1
    public class ProductA1 : AbstractProductA
    {
        public ProductA1()
        {
            Debug.Log("生成对象类型 A1");
        }
    }
    // 对象成品类型 B1
    public class ProductB1 : AbstractProductB
    {
        public ProductB1()
        {
            Debug.Log("生成对象类型 B1");
        }
    }
}