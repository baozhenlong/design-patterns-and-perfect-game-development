public abstract class Handler
{
    protected Handler nextHandler = null;
    public Handler(Handler nextHandler)
    {
        this.nextHandler = nextHandler;
    }
    public virtual void HandleRequest(int cost)
    {
        nextHandler?.HandleRequest(cost);
    }
}