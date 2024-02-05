using UnityEngine;
namespace GoF.Observer
{
    public class ConcreteObserver2 : Observer
    {
        ConcreteSubject subject = null;
        public ConcreteObserver2(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        // 通知 subject 更新
        public override void Update()
        {
            Debug.Log("ConcreteObserver2.Update");
            Debug.Log($"ConcreteObserver2.Subject[{subject.GetState()}]");
        }
    }
}