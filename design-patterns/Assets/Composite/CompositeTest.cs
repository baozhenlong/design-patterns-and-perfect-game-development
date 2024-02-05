using UnityEngine;
namespace GoF.Composite
{
    public class CompositeTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            // 根结点
            IComponent root = new Composite("Root");
            // 加入两个最终节点
            root.Add(new Leaf("Leaf1"));
            root.Add(new Leaf("Leaf2"));

            // 子节点 1
            IComponent child1 = new Composite("Child1");
            // 加入两个最终节点
            child1.Add(new Leaf("Child1.Leaf1"));
            child1.Add(new Leaf("Child1.Leaf2"));
            root.Add(child1);

            // 子节点 2
            IComponent child2 = new Composite("Child2");
            // 加入两个最终节点
            child2.Add(new Leaf("Child2.Leaf1"));
            child2.Add(new Leaf("Child2.Leaf2"));
            root.Add(child2);

            // 显示
            root.Operation();
        }
    }
}