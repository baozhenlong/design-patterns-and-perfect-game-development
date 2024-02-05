using System.Collections.Generic;
namespace GoF.Memento
{
    public class Caretaker
    {
        Dictionary<string, Memento> mementoDictionary = new();

        // 增加
        public void AddMemento(string version, Memento memento)
        {
            if (mementoDictionary.ContainsKey(version) == false)
            {
                mementoDictionary.Add(version, memento);
            }
            else
            {
                mementoDictionary[version] = memento;
            }
        }

        // 读取
        public Memento GetMemento(string version)
        {
            if (mementoDictionary.ContainsKey(version) == false)
            {
                return null;
            }
            return mementoDictionary[version];
        }
    }
}