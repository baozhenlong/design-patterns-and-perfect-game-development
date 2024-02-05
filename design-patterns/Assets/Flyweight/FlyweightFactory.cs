using System.Collections.Generic;
using UnityEngine;
namespace GoF.Flyweight
{
    public class FlyweightFactory
    {
        Dictionary<string, Flyweight> flyweights = new();

        // 获取共享组件
        public Flyweight GetFlyweight(string key, string content)
        {
            if (flyweights.ContainsKey(key))
            {
                return flyweights[key];
            }

            // 产生并设置内容
            ConcreteFlyweight flyweight = new ConcreteFlyweight(content);
            flyweights[key] = flyweight;
            Debug.Log($"New ConcreteFlyweight key[{key}] content[{content}]");
            return flyweight;
        }

        // 获取组件（只获取不共享的 Flyweight）
        public UnSharedConcreteFlyweight GetUnSharedConcreteFlyweight(string content)
        {
            return new UnSharedConcreteFlyweight(content);
        }
        // 获取组件（包含共享部分的 Flyweight）
        public UnSharedConcreteFlyweight GetUnSharedConcreteFlyweight(string key, string sharedContent, string unSharedContent)
        {
            // 先获取共享的部分
            Flyweight sharedFlyweight = GetFlyweight(key, sharedContent);

            // 产生组件
            UnSharedConcreteFlyweight unSharedFlyweight = new(unSharedContent);

            // 设置共享的部分
            unSharedFlyweight.SetFlyweight(sharedFlyweight);
            return unSharedFlyweight;
        }
    }
}