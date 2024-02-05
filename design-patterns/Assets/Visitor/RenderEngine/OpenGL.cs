using UnityEngine;

namespace GoF.Visitor
{
    // OpenGL引擎
    public class OpenGL : RenderEngine
    {
        public override void Render(string objName)
        {
            GLRender(objName);
        }
        public override void Text(string text)
        {
            GLRender(text);
        }

        public void GLRender(string objName)
        {
            Debug.Log("OpenGL:" + objName);
        }
    }
}