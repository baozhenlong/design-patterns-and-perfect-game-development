namespace GoF.Visitor
{
    public class SphereVolumeVisitor : IShapeVisitor
    {
        public float volume = .0f;
        public override void VisitSphere(Sphere sphere)
        {
            volume += sphere.GetVolume();
        }
    }
}