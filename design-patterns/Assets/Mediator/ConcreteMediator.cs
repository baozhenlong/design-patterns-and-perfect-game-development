namespace GoF.Mediator
{
    public class ConcreteMediator : Mediator
    {
        ConcreteColleague1 colleague1 = null;
        ConcreteColleague2 colleague2 = null;
        public void SetColleague1(ConcreteColleague1 colleague)
        {
            colleague1 = colleague;
        }
        public void SetColleague2(ConcreteColleague2 colleague)
        {
            colleague2 = colleague;
        }
        // 收到来自 Colleague 的通知请求
        public override void SendMessage(Colleague colleague, string message)
        {
            // 收到 Colleague1 通知 Colleague2
            if (colleague1 == colleague)
            {
                colleague2.Request(message);
                
            }
            // 收到 Colleague2 通知 Colleague1
            if (colleague2 == colleague)
            {
                colleague1.Request(message);
            }
        }
    }
}