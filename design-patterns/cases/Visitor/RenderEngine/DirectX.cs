namespace GoF.Visitor
{
    // DirectX 引擎
    public class DirectX : RenderEngine
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
            Console.WriteLine("DXRender:" + objName);
        }
    }
}