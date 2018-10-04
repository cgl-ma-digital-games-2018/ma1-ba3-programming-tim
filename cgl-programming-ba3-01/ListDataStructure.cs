﻿using System.Collections.Generic;

namespace cgl_programming_ba3_01
    
{
    internal class ListDataStructure : DataStructure
    {
        private List<string> _data = null;

        public ListDataStructure(string firstEntry)
        {
            _data = new List<string>() {firstEntry};
        }

        #region Methods

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