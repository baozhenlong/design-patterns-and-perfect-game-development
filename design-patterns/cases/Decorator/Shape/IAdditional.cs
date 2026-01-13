namespace GoF.Decorator
{
    // 额外功能
    public abstract class IAdditional
    {
        protected RenderEngine renderEngine;

        public void SetRenderEngine(RenderEngine renderEngine)
        {
            this.renderEngine = renderEngine;
        }

        public abstract void DrawOnShape(IShape shape);
    }
}