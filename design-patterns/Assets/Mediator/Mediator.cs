namespace GoF.Mediator
{
    public abstract class Mediator
    {
        public abstract void SendMessage(Colleague colleague, string message);
    }
}