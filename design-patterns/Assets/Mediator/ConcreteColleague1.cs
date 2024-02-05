using UnityEngine;
namespace GoF.Mediator
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator) { }
        // 执行动作
        public void Action()
        {
            // 执行后需要通知其他 Colleague
            mediator.SendMessage(this, "ConcreteColleague1 发出通知");
        }
        // Mediator 通知请求
        public override void Request(string message)
        {
            Debug.Log("ConcreteColleague1.Request: " + message);
        }
    }
}