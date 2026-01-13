namespace GoF.Visitor
{
    // 球体
    public class Sphere : IShape
    {
        public Sphere(RenderEngine renderEngine)
        {
            SetRenderEngine(renderEngine);
        }

        public override void Draw()
        {
            renderEngine.Render("Sphere");
        }

        public override float GetVolume()
        {
            return 0;
        }

        public override int GetVectorCount()
        {
            return 0;
        }

        public override void RunVisitor(IShapeVisitor visitor)
        {
            visitor.VisitSphere(this);
        }
    }
}