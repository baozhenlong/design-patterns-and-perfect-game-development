using UnityEngine;
namespace GoF.Singleton
{
    public class SingletonTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
            UnitTestClassWithCounter();
        }

        private void UnitTest()
        {
            Singleton.Instance.Name = "Hello";
            Singleton.Instance.Name = "World";
            Debug.Log(Singleton.Instance.Name);
        }

        private void UnitTestClassWithCounter()
        {
            // 有计数功能的类
            ClassWithCounter classWithCounter1 = new();
            classWithCounter1.Operator();

            ClassWithCounter classWithCounter2 = new();
            classWithCounter2.Operator();

            classWithCounter1.Operator();
        }
    }
}