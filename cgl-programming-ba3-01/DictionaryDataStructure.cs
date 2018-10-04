using System.Collections.Generic;

namespace cgl_programming_ba3_01
{
    internal class DictionaryDataStructure : DataStructure
    {
        private Dictionary<int, string> _data = null;

        public DictionaryDataStructure(string entry)
        {
            _data = new Dictionary<int, string>() {{0, entry}};
        }

        #region Methods

        public override void AddEntryAtEnd(string entry)
        {
            var lastIndex = _data.Count - 1;
            _data.Add(lastIndex + 1, entry);
        }

        public override void AddEntryAtIndex(int index, string entry)
        {
            if (_data.ContainsKey(index))
            {
                // copy to new index
                AddEntryAtEnd(_data[index]);
                RemoveEntryAtIndex(index);
            }
            // ad at index.
            _data.Add(index, entry);
        }

        public override string GetEntryAtIndex(int index)
        {
            return _data[index];
        }

        public override void RemoveEntryAtIndex(int index)
        {
            _data.Remove(index);
        }

        public override string ListAllEntries()
        {
            var entries = "";
            foreach (var entry in _data)
            {
                entries += entry.Value + ", ";
            }

            return entries;
        } 
        #endregion
    }
}