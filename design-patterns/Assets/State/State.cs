
namespace GoF.State
{
    // 负责封装当 Context 处于特定状态时所该展现的行为
    public abstract class State
    {
        protected Context context = null;
        public State(Context context)
        {
            this.context = context;
        }
        public abstract void Handle(int value);
    }
}