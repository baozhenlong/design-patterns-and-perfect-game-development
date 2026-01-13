namespace GoF.Visitor
{
    // 绘图引擎接口
    public abstract class RenderEngine
    {
        public abstract void Render(string objName);
        public abstract void Text(string text);
    }
}