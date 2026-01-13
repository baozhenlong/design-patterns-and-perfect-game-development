namespace GoF.Memento
{
    public class Originator
    {
        // 状态，需要被保存
        private string _state;

        public void SetInfo(string state)
        {
            _state = state;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Originator State: {_state}");
        }

        // 产生要存储的记录
        public Memento CreateMemento()
        {
            Memento memento = new();
            memento.SetState(_state);
            return memento;
        }

        // 设置要恢复的记录
        public void SetMemento(Memento? memento)
        {
            if (memento != null)
            {
                _state = memento.GetState();
            }
        }
    }
}