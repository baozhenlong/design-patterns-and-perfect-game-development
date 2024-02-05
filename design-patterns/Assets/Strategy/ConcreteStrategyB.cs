using UnityEngine;

namespace GoF.Strategy
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyB.AlgorithmInterface");
        }
    }
}