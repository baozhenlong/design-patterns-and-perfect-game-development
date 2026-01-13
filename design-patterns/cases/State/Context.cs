namespace GoF.State
{
    // 持有目前的状态，并将有关的讯息传给状态
    public class Context
    {
        private State state;

        public void Request(int value)
        {
            state.Handle(value);
        }

        public void SetState(State state)
        {
            Console.WriteLine($"Context.SetState: {state}");
            this.state = state;
        }
    }
}