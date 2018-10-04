using System.Collections.Generic;

namespace cgl_programming_ba3_01
{
    internal abstract class DataStructure
    {
        public abstract void AddEntryAtEnd(string entry);

        public abstract void AddEntryAtIndex(int index, string entry);

        public abstract string GetEntryAtIndex(int index);

        public abstract void RemoveEntryAtIndex(int index);

        public abstract string ListAllEntries();
    }
}