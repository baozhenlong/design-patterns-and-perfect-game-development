namespace GoF.Visitor
{
    public class DrawVisitor : IShapeVisitor
    {
        public override void VisitSphere(Sphere sphere)
        {
            sphere.Draw();
        }

        public override void VisitCube(Cube cube)
        {
            cube.Draw();
        }

        public override void VisitCylinder(Cylinder cylinder)
        {
            cylinder.Draw();
        }
    }
}