namespace GoF.Bridge
{
    public abstract class Abstraction
    {
        private Implementor imp = null;
        public void SetImplementor(Implementor implementor)
        {
            imp = implementor;
        }
        public virtual void Operation()
        {
            imp?.OperationImp();
        }
    }
}