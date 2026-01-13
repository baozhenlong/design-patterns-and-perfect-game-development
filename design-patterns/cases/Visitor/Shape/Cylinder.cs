namespace GoF.Visitor
{
    // 圆柱体
    public class Cylinder : IShape
    {
        public Cylinder(RenderEngine renderEngine)
        {
            SetRenderEngine(renderEngine);
        }

        public override void Draw()
        {
            renderEngine.Render("Cylinder");
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
            visitor.VisitCylinder(this);
        }
    }

}