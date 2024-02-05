using UnityEngine;

namespace GoF.Visitor
{
    // 形状的定义
    public abstract class IShape
    {
        // 使用的绘图引擎
        protected RenderEngine renderEngine = null;
        // 显示位置
        protected Vector3 position = Vector3.zero;
        // 大小(缩放)
        protected Vector3 scale = Vector3.zero;

        public void SetRenderEngine(RenderEngine renderEngine)
        {
            this.renderEngine = renderEngine;
        }

        public Vector3 GetPosition()
        {
            return position;
        }

        public Vector3 GetScale()
        {
            return scale;
        }
        // 绘出
        public abstract void Draw();
        // 取得体积
        public abstract float GetVolume();
        // 取得顶点数
        public abstract int GetVectorCount();
        public abstract void RunVisitor(IShapeVisitor visitor);
    }
}