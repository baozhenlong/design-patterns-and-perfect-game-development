namespace GoF.Mediator
{
    public class MediatorTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            // 产生中介者
            ConcreteMediator mediator = new();

            // 产生两个 Colleague
            ConcreteColleague1 colleague1 = new(mediator);
            ConcreteColleague2 colleague2 = new(mediator);

            // 设置给中介者
            mediator.SetColleague1(colleague1);
            mediator.SetColleague2(colleague2);

            // 执行
            colleague1.Action();
            colleague2.Action();
        }
    }
}