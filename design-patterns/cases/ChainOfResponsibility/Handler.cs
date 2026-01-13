public abstract class Handler
{
    private readonly Handler? _nextHandler;

    public Handler(Handler? nextHandler)
    {
        this._nextHandler = nextHandler;
    }

    public virtual void HandleRequest(int cost)
    {
        _nextHandler?.HandleRequest(cost);
    }
}