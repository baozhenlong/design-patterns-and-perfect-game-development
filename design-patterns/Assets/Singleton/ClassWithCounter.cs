
using UnityEngine;

namespace GoF.Singleton
{
    public class ClassWithCounter
    {
        protected static int Counter = 0;
        protected bool enable = false;
        public ClassWithCounter()
        {
            Counter += 1;
            enable = Counter == 1;
            if (Counter > 1)
            {
                Debug.LogError($"目前物件数[Counter]超过 1 个");
            }
        }

        public void Operator()
        {
            if (enable == false)
            {
                Debug.Log("不可以执行");
                return;
            }
            Debug.Log("可以执行");
        }
    }
}