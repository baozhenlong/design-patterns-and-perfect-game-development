using UnityEngine;
namespace GoF.Flyweight
{
    public class UnSharedConcreteFlyweight
    // : Flyweight
    {
        // 共享的组件
        Flyweight flyweight = null;
        // 不共享的组件
        string unSharedContent;
        public UnSharedConcreteFlyweight(string content)
        {
            unSharedContent = content;
        }
        // 设置共享的组件
        public void SetFlyweight(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }
        public void Operator()
        {
            string msg = $"UnSharedConcreteFlyweight.unSharedContent[{unSharedContent}]";
            if (flyweight != null)
            {
                msg += "包含了: " + flyweight.GetContent();
            }
            Debug.Log(msg);
        }
    }
}