// OpenGL 引擎

namespace GoF.Decorator
{
    // OpenGL 引擎
    public class OpenGL : RenderEngine
    {
        public override void Render(string name)
        {
            ExecuteRender(name);
        }

        private void ExecuteRender(string name)
        {
            Console.WriteLine("OpenGL: " + name);
        }
    }
}