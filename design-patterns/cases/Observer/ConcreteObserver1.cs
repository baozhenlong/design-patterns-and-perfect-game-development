namespace GoF.Observer
{
    public class ConcreteObserver1 : Observer
    {
        private string _objectState;
        private readonly ConcreteSubject _subject;

        public ConcreteObserver1(ConcreteSubject subject)
        {
            _subject = subject;
        }

        // 通知 subject 更新
        public override void Update()
        {
            Console.WriteLine("ConcreteObserver1.Update");
            _objectState = _subject.GetState();
        }

        public void ShowState()
        {
            Console.WriteLine($"ConcreteObserver1.Subject[{_objectState}]");
        }
    }
}