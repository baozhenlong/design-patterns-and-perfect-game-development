using UnityEngine;

namespace GoF.Visitor
{
    // DirectX 引擎
    public class DirectX : RenderEngine
    {
        public override void Render(string objName)
        {
            DXRender(objName);
        }
        public override void Text(string text)
        {
            DXRender(text);
        }

        public void DXRender(string objName)
        {
            Debug.Log("DXRender:" + objName);
        }

    }
}