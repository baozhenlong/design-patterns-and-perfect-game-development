namespace GoF.Visitor
{
    public class SphereVolumeVisitor : IShapeVisitor
    {
        private float _volume = .0f;

        public float Volume => _volume;

        public override void VisitSphere(Sphere sphere)
        {
            _volume += sphere.GetVolume();
        }
    }
}