namespace GoF.Decorator
{
    // 形状装饰者接口
    public abstract class IShapeDecorator : IShape
    {
        private readonly IShape _component;

        public IShapeDecorator(IShape component)
        {
            _component = component;
        }

        public override void Draw()
        {
            _component.Draw();
        }

        public override string GetPolygon()
        {
            return _component.GetPolygon();
        }
    }
}