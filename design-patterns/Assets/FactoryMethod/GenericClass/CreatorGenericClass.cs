using UnityEngine;
namespace GoF.FactoryMethod
{
    public class CreatorGenericClass<T> where T : Product, new()
    {
        public CreatorGenericClass()
        {
            Debug.Log($"产生工厂: CreatorGenericClass<{typeof(T)}>");
        }
        public Product FactoryMethod()
        {
            return new T();
        }
    }
}