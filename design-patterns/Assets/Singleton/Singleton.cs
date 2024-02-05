namespace GoF.Singleton
{
    public class Singleton
    {
        public string Name { get; set; }
        private static Singleton _instance;
        public static Singleton Instance
        {
            get => _instance ??= new Singleton();
        }
        private Singleton() { }
    }
}