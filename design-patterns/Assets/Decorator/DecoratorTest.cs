using UnityEngine;
namespace GoF.Decorator
{
    public class DecoratorTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
            ShapeUnitTest();
        }

        private void UnitTest()
        {
            ConcreteComponent component = new();

            ConcreteDecoratorA decoratorA = new(component);
            decoratorA.Operator();

            ConcreteDecoratorB decoratorB = new(component);
            decoratorB.Operator();

            ConcreteDecoratorB decoratorB2 = new(decoratorA);
            decoratorB2.Operator();
        }

        private void ShapeUnitTest()
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