namespace GoF.Visitor
{
    public class VisitorTest
    {
        public static void Test()
        {
            UnitTest();
        }

        private static void UnitTest()
        {
            DirectX directX = new();

            // 加入形状
            ShapeContainer shapeContainer = new();
            shapeContainer.AddShape(new Cube(directX));
            shapeContainer.AddShape(new Cylinder(directX));
            shapeContainer.AddShape(new Sphere(directX));

            // 绘图
            shapeContainer.RunVisitor(new DrawVisitor());

            // 顶点数
            VectorCountVisitor vectorCountVisitor = new();
            shapeContainer.RunVisitor(vectorCountVisitor);
            Console.WriteLine($"顶点数: {vectorCountVisitor.Count}");

            // 球体体积
            SphereVolumeVisitor sphereVolumeVisitor = new();
            shapeContainer.RunVisitor(sphereVolumeVisitor);
            Console.WriteLine($"球体体积: {sphereVolumeVisitor.Volume}");
        }
    }
}