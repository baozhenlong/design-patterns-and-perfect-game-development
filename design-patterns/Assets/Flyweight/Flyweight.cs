namespace GoF.Flyweight
{
    public abstract class Flyweight
    {
        // 显示的内容
        protected string content;
        public Flyweight() { }
        public Flyweight(string content)
        {
            this.content = content;
        }
        public string GetContent()
        {
            return content;
        }
        public abstract void Operator();
    }
}