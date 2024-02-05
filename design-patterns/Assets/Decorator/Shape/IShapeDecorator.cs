namespace GoF.Decorator
{
    // 形状装饰者接口
    public abstract class IShapeDecorator : IShape
    {
        IShape component = null;
        public IShapeDecorator(IShape component)
        {
            this.component = component;
        }
        public override void Draw()
        {
            component.Draw();
        }
        public override string GetPolygon()
        {
            return component.GetPolygon();
        }
    }
}