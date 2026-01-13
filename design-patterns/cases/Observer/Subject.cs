using System.Collections.Generic;
namespace GoF.Observer
{
    public abstract class Subject
    {
        private List<Observer> _observers = new();

        // 加入观察者
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        // 删除观察者
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        // 通知所有观察者
        public void Notify()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }
}