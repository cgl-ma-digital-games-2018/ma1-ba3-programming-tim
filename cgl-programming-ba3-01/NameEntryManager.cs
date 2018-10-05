using System;
using System.Collections.Generic;

namespace cgl_programming_ba3_01
{
    internal class NameEntryManager : DataStructureManager
    {
        public override string Name { get; } = "NameEntryManager";

        private readonly List<DataStructureManager> _dataStructureManagers = null;

        public NameEntryManager(string firstEntry)
        {
            _dataStructureManagers = new List<DataStructureManager>() { new ArrayManager(firstEntry), new ListManager(firstEntry), new DictionaryManager(firstEntry) };
            
            Console.WriteLine("Initialized array, list and dictionary with first entry.");
        }

        #region Public Methods
        public override void AddEntryAtIndex(int index, string entry)
        {
            Console.WriteLine("Adding entry at index {0}...", index);

            foreach (var manager in _dataStructureManagers)
            {
                manager.AddEntryAtIndex(index, entry);
            }
        }

        public override void AddEntryAtEnd(string entry)
        {
            Console.WriteLine("Adding another entry to the end...");

            foreach (var manager in _dataStructureManagers)
            {
                manager.AddEntryAtEnd(entry);
            }
        }

        public override string GetEntryAtIndex(int index)
        {
            Console.WriteLine("Getting entry at index {0}...", index);
            var entryAtIndex = "";
            foreach (var manager in _dataStructureManagers)
            {
                entryAtIndex += "--" + manager.ToString() + ": " + manager.GetEntryAtIndex(index) + "\n";
            }
            return entryAtIndex;
        }

        public override void RemoveEntryAtIndex(int index)
        {
            Console.WriteLine("Removing entry at index {0}...", index);

            foreach (var manager in _dataStructureManagers)
            {
                manager.RemoveEntryAtIndex(index);
            }
        }

        public override string ListAllEntries()
        {
            var allEntries = "";
            foreach (var manager in _dataStructureManagers)
            {
                allEntries += "--" + manager.ToString() + ": " + manager.ListAllEntries() + "\n";
            }
            return allEntries;
        } 
        #endregion
    }
}