using UnityEngine;
namespace GoF.Strategy
{
    public class StrategyTest : MonoBehaviour
    {
        private void Awake()
        {
            UnitTest();
        }

        private void UnitTest()
        {
            Context context = new();

            context.SetStrategy(new ConcreteStrategyA());
            context.ContextInterface();

            context.SetStrategy(new ConcreteStrategyB());
            context.ContextInterface();

            context.SetStrategy(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }
}