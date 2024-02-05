using UnityEngine;
namespace GoF.Visitor
{
    public class VisitorTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }

        private void UnitTest()
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
            Debug.Log($"顶点数: {vectorCountVisitor.count}");

            // 球体体积
            SphereVolumeVisitor sphereVolumeVisitor = new();
            shapeContainer.RunVisitor(sphereVolumeVisitor);
            Debug.Log($"球体体积: {sphereVolumeVisitor.volume}");
        }
    }
}