namespace GoF.Memento
{
    public class Memento
    {
        string state;
        public string GetState()
        {
            return state;
        }
        public void SetState(string state)
        {
            this.state = state;
        }
    }
}