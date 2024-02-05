using System.Collections.Generic;
using UnityEngine;

namespace GoF.Builder
{
    public class Product
    {
        private List<string> partList = new();
        public Product() { }

        public void AddPart(string part)
        {
            partList.Add(part);
        }

        public void ShowProduct()
        {
            Debug.Log("ShowProduct:");
            foreach (string part in partList)
            {
                Debug.Log(part);
            }
        }
    }
}