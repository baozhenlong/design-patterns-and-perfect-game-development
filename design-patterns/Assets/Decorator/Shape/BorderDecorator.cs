namespace GoF.Decorator
{
    // 外框装饰者
    public class BorderDecorator : IShapeDecorator
    {
        // 外框功能
        Border border = new();
        public BorderDecorator(IShape component) : base(component) { }
        public override void SetRenderEngine(RenderEngine renderEngine)
        {
            base.SetRenderEngine(renderEngine);
            border.SetRenderEngine(renderEngine);
        }
        public override void Draw()
        {
            // 被装饰者的功能
            base.Draw();
            // 外框功能
            border.DrawOnShape(this);
        }
    }
}