namespace GoF.Observer
{
    public class ConcreteObserver2 : Observer
    {
        private readonly ConcreteSubject _subject;

        public ConcreteObserver2(ConcreteSubject subject)
        {
            _subject = subject;
        }

        // 通知 subject 更新
        public override void Update()
        {
            Console.WriteLine("ConcreteObserver2.Update");
            Console.WriteLine($"ConcreteObserver2.Subject[{_subject.GetState()}]");
        }
    }
}