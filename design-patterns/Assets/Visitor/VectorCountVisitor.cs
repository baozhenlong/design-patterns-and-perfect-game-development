namespace GoF.Visitor
{
    public class VectorCountVisitor : IShapeVisitor
    {
        public int count = 0;
        public override void VisitSphere(Sphere sphere)
        {
            count += sphere.GetVectorCount();
        }

        public override void VisitCube(Cube cube)
        {
            count += cube.GetVectorCount();
        }

        public override void VisitCylinder(Cylinder cylinder)
        {
            count += cylinder.GetVectorCount();
        }
    }
}