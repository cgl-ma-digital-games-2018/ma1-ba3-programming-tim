using System.Collections.Generic;

namespace L02DataStructureIntroduction
    
{
    internal class ListManager : DataStructureManager
    {
        public override string Name { get; } = "List";

        private List<string> _data = null;

        public ListManager(string firstEntry)
        {
            _data = new List<string>() {firstEntry};
        }

        #region Public Methods
        public override void AddEntryAtEnd(string entry)
        {
            _data.Add(entry);
        }

        public override void AddEntryAtIndex(int index, string entry)
        {
            _data.Insert(index, entry);
        }

        public override string GetEntryAtIndex(int index)
        {
            return _data[index];
        }

        public override void RemoveEntryAtIndex(int index)
        {
            _data.RemoveAt(index);
        }

        public override string ListAllEntries()
        {
            var entries = "";
            foreach (var entry in _data)
            {
                entries += entry + ", ";
            }
            return entries;
        } 
        #endregion
    }
}