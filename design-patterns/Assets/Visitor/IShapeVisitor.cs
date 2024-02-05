namespace GoF.Visitor
{
    public abstract class IShapeVisitor
    {
        // 由 Sphere 类来调用
        public virtual void VisitSphere(Sphere sphere) { }
        // 由 Cube 类来调用
        public virtual void VisitCube(Cube cube) { }
        // 由 Cylinder 类来调用
        public virtual void VisitCylinder(Cylinder cylinder) { }
    }
}