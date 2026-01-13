using System.Collections.Generic;

namespace GoF.Visitor
{
    public class ShapeContainer
    {
        private readonly List<IShape> _shapes = new();

        public ShapeContainer()
        {
        }

        // 新增

        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }

        // 共享的访问接口
        public void RunVisitor(IShapeVisitor visitor)
        {
            foreach (var shape in _shapes)
            {
                shape.RunVisitor(visitor);
            }
        }
    }
}