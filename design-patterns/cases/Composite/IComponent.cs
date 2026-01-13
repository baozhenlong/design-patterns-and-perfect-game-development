namespace GoF.Composite
{
    public abstract class IComponent
    {
        protected string value;

        // 一般操作
        public abstract void Operation();

        // 加入节点
        public virtual void Add(IComponent component)
        {
            Console.WriteLine("子类没有实现 Add");
        }

        // 删除节点
        public virtual void Remove(IComponent component)
        {
            Console.WriteLine("子类没有实现 Remove");
        }

        // 获取子节点
        public virtual IComponent GetChild(int index)
        {
            Console.WriteLine("子类没有实现 GetChild");
            return null;
        }
    }
}