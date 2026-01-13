namespace GoF.Decorator
{
    public class ShapeTest
    {
        public static void Test()
        {
            UnitTest();
        }
        
        private static void UnitTest()
        {
            OpenGL openGL = new();
            // 球体
            Sphere sphere = new();
            sphere.SetRenderEngine(openGL);

            // 在图形外加外框
            BorderDecorator borderDecorator = new(sphere);

            borderDecorator.SetRenderEngine(openGL);
            borderDecorator.Draw();
        }
    }
}