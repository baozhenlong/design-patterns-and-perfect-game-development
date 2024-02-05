namespace GoF.Observer
{
    public class ConcreteSubject : Subject
    {
        // 主题状态
        string subjectState;
        public void SetState(string state)
        {
            subjectState = state;
            Notify();
        }

        public string GetState()
        {
            return subjectState;
        }
    }
}