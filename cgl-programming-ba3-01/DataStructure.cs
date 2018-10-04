using System.Collections.Generic;

namespace cgl_programming_ba3_01
{
    internal abstract class DataStructure
    {
        public abstract void AddEntryAtEnd(string entry);

        public abstract void AddEntryAtPosition(string entry, int position);

        public abstract string GetEntryAtPosition(int position);

        public abstract void RemoveEntryAtPosition(int position);

        public abstract string ListAllEntries();
    }
}