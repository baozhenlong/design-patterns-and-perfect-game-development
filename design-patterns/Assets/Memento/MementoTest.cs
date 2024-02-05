using UnityEngine;
namespace GoF.Memento
{

    public class MementoTest : MonoBehaviour
    {
        private void Awake()
        {
            Originator originator = new();
            Caretaker caretaker = new();

            // 设置信息
            originator.SetInfo("version1");
            originator.ShowInfo();
            // 保存
            caretaker.AddMemento("1", originator.CreateMemento());

            // 设置信息
            originator.SetInfo("version2");
            originator.ShowInfo();
            // 保存
            caretaker.AddMemento("2", originator.CreateMemento());

            // 设置信息
            originator.SetInfo("version3");
            originator.ShowInfo();
            // 保存
            caretaker.AddMemento("3", originator.CreateMemento());

            // 退回到第二版
            originator.SetMemento(caretaker.GetMemento("2"));
            originator.ShowInfo();

            // 退回到第一版
            originator.SetMemento(caretaker.GetMemento("1"));
            originator.ShowInfo();
        }
    }
}