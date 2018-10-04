using System.Collections.Generic;

namespace cgl_programming_ba3_01
    
{
    internal class ListDataStructure : DataStructure
    {
        private List<string> _list = null;

        public ListDataStructure(string firstEntry)
        {
            _list = new List<string>() {firstEntry};
        }

        #region Methods

        public override void AddEntryAtEnd(string entry)
        {
            _list.Add(entry);
        }

        public override void AddEntryAtPosition(string entry, int position)
        {
            throw new System.NotImplementedException();
        }

        public override string GetEntryAtPosition(int position)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveEntryAtPosition(int position)
        {
            throw new System.NotImplementedException();
        }

        public override string ListAllEntries()
        {
            var entries = "";
            foreach (var entry in _list)
            {
                entries += entry + ", ";
            }

            return entries;
        } 
        #endregion
    }
}