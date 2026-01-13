namespace GoF.Visitor
{
    // OpenGL引擎
    public class OpenGL : RenderEngine
    {
        public override void Render(string objName)
        {
            ExecuteRender(objName);
        }

        public override void Text(string text)
        {
            ExecuteRender(text);
        }

        private void ExecuteRender(string objName)
        {
            Console.WriteLine("OpenGL:" + objName);
        }
    }
}