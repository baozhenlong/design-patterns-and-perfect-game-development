using System.Collections.Generic;

namespace GoF.Memento
{
    public class Caretaker
    {
        private readonly Dictionary<string, Memento> _mementoDictionary = new();

        // 增加
        public void AddMemento(string version, Memento memento)
        {
            _mementoDictionary[version] = memento;
        }

        // 读取
        public Memento? GetMemento(string version)
        {
            if (_mementoDictionary.TryGetValue(version, out var memento))
            {
                return memento;
            }
            else
            {
                Console.WriteLine($"No memento found for version: {version}");
                return null;
            }
        }
    }
}