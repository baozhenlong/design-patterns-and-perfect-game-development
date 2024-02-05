using UnityEngine;
namespace GoF.Builder
{
    public class BuilderTest : MonoBehaviour
    {
        private void Awake()
        {
            // 创建
            Director director = new();
            Product buildProduct;

            // 使用 BuildA 构建
            director.Construct(new ConcreteBuilderA());
            buildProduct = director.GetResult();
            buildProduct.ShowProduct();

            // 使用 BuildB 构建
            director.Construct(new ConcreteBuilderB());
            buildProduct = director.GetResult();
            buildProduct.ShowProduct();
        }
    }
}