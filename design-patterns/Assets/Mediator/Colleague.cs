namespace GoF.Mediator
{
    public abstract class Colleague
    {
        // 通过 mediator 对外沟通
        protected Mediator mediator = null;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        // mediator 通知请求
        public abstract void Request(string message);
    }
}