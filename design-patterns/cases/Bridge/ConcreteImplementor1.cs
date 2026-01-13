namespace GoF.Bridge
{
    public class ConcreteImplementor1 : Implementor
    {
        public ConcreteImplementor1()
        {
        }

        public override void OperationImp()
        {
            Console.WriteLine("执行 ConcreteImplementor1.OperationImp");
        }
    }
}