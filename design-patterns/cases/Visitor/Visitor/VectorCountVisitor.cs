namespace GoF.Visitor
{
    public class VectorCountVisitor : IShapeVisitor
    {
        private int _count = 0;
        
        public int Count => _count;
        public override void VisitSphere(Sphere sphere)
        {
            _count += sphere.GetVectorCount();
        }

        public override void VisitCube(Cube cube)
        {
            _count += cube.GetVectorCount();
        }

        public override void VisitCylinder(Cylinder cylinder)
        {
            _count += cylinder.GetVectorCount();
        }
    }
}