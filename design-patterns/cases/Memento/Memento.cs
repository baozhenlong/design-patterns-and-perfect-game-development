namespace GoF.Memento
{
    public class Memento
    {
        private string _state;

        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state;
        }
    }
}