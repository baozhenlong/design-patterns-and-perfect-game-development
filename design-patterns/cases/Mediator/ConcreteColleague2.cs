namespace GoF.Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        // 执行动作
        public void Action()
        {
            // 执行后需要通知其他 Colleague
            mediator.SendMessage(this, "ConcreteColleague2 发出通知");
        }

        // Mediator 通知请求
        public override void Request(string message)
        {
            Console.WriteLine("ConcreteColleague2.Request: " + message);
        }
    }
}