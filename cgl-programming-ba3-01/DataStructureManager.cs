using System.Collections.Generic;

namespace L02DataStructureIntroduction
{
    internal abstract class DataStructureManager
    {
        public abstract string Name { get; }

        #region Methods
        public abstract void AddEntryAtEnd(string entry);

        public abstract void AddEntryAtIndex(int index, string entry);

        public abstract string GetEntryAtIndex(int index);

        public abstract void RemoveEntryAtIndex(int index);

        public abstract string ListAllEntries();

        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}