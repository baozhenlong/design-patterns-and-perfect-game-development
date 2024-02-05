using UnityEngine;
namespace GoF.Adapter
{
    public class AdapterTest : MonoBehaviour
    {
        private void Awake()
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}