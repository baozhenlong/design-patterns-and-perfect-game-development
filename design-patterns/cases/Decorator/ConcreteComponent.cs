namespace GoF.Decorator
{
    // 实现可被 Decorator 动态增加的组件
    public class ConcreteComponent : Component
    {
        public override void Operator()
        {
            Console.WriteLine("ConcreteComponent.Operator");
        }
    }
}