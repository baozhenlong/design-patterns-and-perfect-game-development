namespace GoF.Flyweight
{
    public abstract class Flyweight
    {
        // 显示的内容
        private string _content;

        public Flyweight()
        {
        }

        public Flyweight(string content)
        {
            this._content = content;
        }

        public string GetContent()
        {
            return _content;
        }

        public abstract void Operator();
    }
}