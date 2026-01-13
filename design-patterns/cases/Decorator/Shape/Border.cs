namespace GoF.Decorator
{
    // 外框
    public class Border : IAdditional
    {
        public override void DrawOnShape(IShape shape)
        {
            renderEngine.Render($"Draw Border On {shape.GetPolygon()}");
        }
    }
}