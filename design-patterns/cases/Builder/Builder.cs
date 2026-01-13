namespace GoF.Builder
{
    public abstract class Builder
    {
        public abstract void BuildPart1(Product buildProduct);
        public abstract void BuildPart2(Product buildProduct);
    }
}