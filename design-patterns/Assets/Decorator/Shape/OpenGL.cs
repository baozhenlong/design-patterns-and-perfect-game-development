// OpenGL 引擎
using UnityEngine;

namespace GoF.Decorator
{
    // OpenGL 引擎
    public class OpenGL : RenderEngine
    {
        public override void Render(string name)
        {
            GLRender(name);
        }

        public void GLRender(string name)
        {
            Debug.Log("OpenGL: " + name);
        }
    }
}