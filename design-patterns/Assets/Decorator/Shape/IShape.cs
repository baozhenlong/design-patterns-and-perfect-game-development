namespace GoF.Decorator
{
    // 形状
    public abstract class IShape
    {
        protected RenderEngine renderEngine = null;
        public virtual void SetRenderEngine(RenderEngine renderEngine)
        {
            this.renderEngine = renderEngine;
        }
        public abstract void Draw();
        public abstract string GetPolygon();
    }
}