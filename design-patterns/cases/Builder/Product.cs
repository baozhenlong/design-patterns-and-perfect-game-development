namespace GoF.Builder
{
    public class Product
    {
        private readonly List<string> _partList = new();

        public Product()
        {
        }

        public void AddPart(string part)
        {
            _partList.Add(part);
        }

        public void ShowProduct()
        {
            Console.WriteLine("ShowProduct:");
            foreach (var part in _partList)
            {
                Console.WriteLine(part);
            }
        }
    }
}