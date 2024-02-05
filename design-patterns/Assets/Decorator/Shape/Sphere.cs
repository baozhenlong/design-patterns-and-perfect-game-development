namespace GoF.Decorator
{
    // 球体
    public class Sphere : IShape
    {
        public override void Draw()
        {
            renderEngine.Render("Sphere");
        }
        public override string GetPolygon()
        {
            return "Sphere 多边形";
        }
    }
}