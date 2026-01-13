namespace GoF.Bridge
{
    public class ConcreteImplementor2 : Implementor
    {
        public ConcreteImplementor2()
        {
        }

        public override void OperationImp()
        {
            Console.WriteLine("执行 ConcreteImplementor2.OperationImp");
        }
    }
}