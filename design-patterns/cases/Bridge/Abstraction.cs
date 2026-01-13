namespace GoF.Bridge
{
    public abstract class Abstraction
    {
        private Implementor imp;

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