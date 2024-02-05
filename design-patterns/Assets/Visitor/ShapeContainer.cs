using System.Collections.Generic;
namespace GoF.Visitor
{
    public class ShapeContainer
    {
        List<IShape> shapes = new();

        public ShapeContainer() { }

        // 新增

        public void AddShape(IShape shape)
        {
            shapes.Add(shape);
        }

        // 共享的访问接口
        public void RunVisitor(IShapeVisitor visitor)
        {
            foreach (var shape in shapes)
            {
                shape.RunVisitor(visitor);
            }
        }
    }
}