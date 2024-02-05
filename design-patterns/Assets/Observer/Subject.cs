using System.Collections.Generic;
namespace GoF.Observer
{
    public abstract class Subject
    {
        List<Observer> observers = new();

        // 加入观察者
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        // 删除观察者
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        // 通知所有观察者
        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}