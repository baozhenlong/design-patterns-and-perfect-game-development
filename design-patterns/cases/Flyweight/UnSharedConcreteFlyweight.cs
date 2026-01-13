namespace GoF.Flyweight
{
    public class UnSharedConcreteFlyweight : Flyweight
    {
        // 共享的组件
        Flyweight flyweight;

        // 不共享的组件
        private readonly string _unSharedContent;

        public UnSharedConcreteFlyweight(string content)
        {
            _unSharedContent = content;
        }

        // 设置共享的组件
        public void SetFlyweight(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Operator()
        {
            var msg = $"UnSharedConcreteFlyweight.unSharedContent[{_unSharedContent}]";
            if (flyweight != null)
            {
                msg += "包含了: " + flyweight.GetContent();
            }

            Console.WriteLine(msg);
        }
    }
}