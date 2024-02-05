using UnityEngine;
namespace GoF.FactoryMethod
{
    public class FactoryMethodTest : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("====== SubclassUnitTest");
            SubclassUnitTest();
            Debug.Log("====== SubclassUnitTest");
            Debug.Log("====== MethodTypeUnitTest");
            MethodTypeUnitTest();
            Debug.Log("====== MethodTypeUnitTest");
            Debug.Log("====== GenericClassUnitTest");
            GenericClassUnitTest();
            Debug.Log("====== GenericClassUnitTest");
            Debug.Log("====== GenericMethodUnitTest");
            GenericMethodUnitTest();
            Debug.Log("====== GenericMethodUnitTest");
        }

        private void SubclassUnitTest()
        {
            // 产品
            Product product;

            // 工厂接口
            Creator creator;

            // 设置为负责 ProductA 的工厂
            creator = new ConcreteCreatorProductA();
            product = creator.FactoryMethod();

            // 设置为负责 ProductB 的工厂
            creator = new ConcreteCreatorProductB();
            product = creator.FactoryMethod();
        }

        private void MethodTypeUnitTest()
        {
            // 工厂接口
            CreatorMethodType creatorMethodType = new ConcreteCreatorMethodType();

            // 获取两个产品
            Product product = creatorMethodType.FactoryMethod(1);
            product = creatorMethodType.FactoryMethod(2);
        }

        private void GenericClassUnitTest()
        {
            // 负责 ProduceA 的工厂
            CreatorGenericClass<ConcreteProductA> creatorProductA = new();
            Product product = creatorProductA.FactoryMethod();

            // 负责 ProduceB 的工厂
            CreatorGenericClass<ConcreteProductB> creatorProductB = new();
            product = creatorProductB.FactoryMethod();
        }

        private void GenericMethodUnitTest()
        {
            ConcreteCreatorGenericMethod concreteCreatorGenericMethod = new();
            Product product = concreteCreatorGenericMethod.FactoryMethod<ConcreteProductA>();
            product = concreteCreatorGenericMethod.FactoryMethod<ConcreteProductB>();
        }
    }
}