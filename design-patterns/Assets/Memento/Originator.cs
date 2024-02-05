using UnityEngine;
namespace GoF.Memento
{
    public class Originator
    {
        // 状态，需要被保存
        string state;
        public void SetInfo(string state)
        {
            this.state = state;
        }

        public void ShowInfo()
        {
            Debug.Log($"Originator State: {state}");
        }
        // 产生要存储的记录
        public Memento CreateMemento()
        {
            Memento memento = new();
            memento.SetState(state);
            return memento;
        }

        // 设置要恢复的记录
        public void SetMemento(Memento memento)
        {
            state = memento.GetState();
        }
    }
}