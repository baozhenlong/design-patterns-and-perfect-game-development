using UnityEngine;

namespace GoF.Strategy
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyA.AlgorithmInterface");
        }
    }
}