using UnityEngine;
namespace GoF.Observer
{
    public class ConcreteObserver1 : Observer
    {
        string objectState;
        ConcreteSubject subject = null;
        public ConcreteObserver1(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        // 通知 subject 更新
        public override void Update()
        {
            Debug.Log("ConcreteObserver1.Update");
            objectState = subject.GetState();
        }

        public void ShowState()
        {
            Debug.Log($"ConcreteObserver1.Subject[{objectState}]");
        }
    }
}