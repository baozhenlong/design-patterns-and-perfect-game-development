namespace GoF.Observer
{
    public class ObserverTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            // 主题
            ConcreteSubject subject = new();

            // 加入观察者
            ConcreteObserver1 observer1 = new(subject);
            subject.Attach(observer1);
            subject.Attach(new ConcreteObserver2(subject));

            //设置状态
            subject.SetState("设置 Subject 状态");

            // 显示
            observer1.ShowState();
        }
    }
}