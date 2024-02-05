using UnityEngine;

namespace GoF.Strategy
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("ConcreteStrategyC.AlgorithmInterface");
        }
    }
}