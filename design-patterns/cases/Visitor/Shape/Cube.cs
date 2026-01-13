namespace GoF.Visitor
{
    // 立方体
    public class Cube : IShape
    {
        public Cube(RenderEngine renderEngine)
        {
            SetRenderEngine(renderEngine);
        }

        public override void Draw()
        {
            renderEngine.Render("Cube");
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
            visitor.VisitCube(this);
        }
    }
}