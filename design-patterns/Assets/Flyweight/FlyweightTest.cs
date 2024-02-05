using UnityEngine;
namespace GoF.Flyweight
{
    public class FlyweightTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }
        private void UnitTest()
        {
            // 组件工厂
            FlyweightFactory flyweightFactory = new();

            // 产生共享组件
            flyweightFactory.GetFlyweight("1", "共享组件 1");
            flyweightFactory.GetFlyweight("2", "共享组件 2");
            flyweightFactory.GetFlyweight("3", "共享组件 3");

            // 获取共享组件
            Flyweight flyweight = flyweightFactory.GetFlyweight("1", "");
            flyweight.Operator();

            // 产生不共享的组件
            UnSharedConcreteFlyweight unSharedConcreteFlyweight = flyweightFactory.GetUnSharedConcreteFlyweight("不共享的信息 1");
            unSharedConcreteFlyweight.Operator();

            // 设置共享组件
            unSharedConcreteFlyweight.SetFlyweight(flyweight);
            unSharedConcreteFlyweight.Operator();

            // 产生不共享组件，并指定使用共享组件
            UnSharedConcreteFlyweight unSharedConcreteFlyweight2 = flyweightFactory.GetUnSharedConcreteFlyweight("1", "", "不共享的信息 2");
            unSharedConcreteFlyweight2.Operator();
        }
    }
}