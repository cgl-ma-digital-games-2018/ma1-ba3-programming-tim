using System;
using System.Collections.Generic;
using System.Deployment.Internal;

namespace cgl_programming_ba3_01
{
    internal class NameEntryManager :DataStructure
    {
        private readonly ArrayDataStructure _array = null;
        private readonly ListDataStructure _list = null;
        private readonly DictionaryDataStructure _dictionary = null;

        public NameEntryManager(string firstEntry)
        {
            _array = new ArrayDataStructure(firstEntry);
            _list = new ListDataStructure(firstEntry);
            _dictionary = new DictionaryDataStructure(firstEntry);
            
            Console.WriteLine("Initialized array, list and dictionary with first entry...");
        }

        public override void AddEntryAtIndex(int index, string entry)
        {
            _list.AddEntryAtIndex(index, entry);
            _dictionary.AddEntryAtIndex(index, entry);
            Console.WriteLine("Added entry at index {0}...", index);
        }

        public override void AddEntryAtEnd(string entry)
        {
            _list.AddEntryAtEnd(entry);
            _dictionary.AddEntryAtEnd(entry);

            Console.WriteLine("Added another entry to the end...");
        }

        public override string GetEntryAtIndex(int index)
        {
            var listEntry = "List: " + _list.GetEntryAtIndex(index);
            var dictionaryEntry = "Dictionary: " + _dictionary.GetEntryAtIndex(index);

            return listEntry + " " + dictionaryEntry;
        }

        public override void RemoveEntryAtIndex(int index)
        {
            _list.RemoveEntryAtIndex(index);
            _dictionary.RemoveEntryAtIndex(index);

            Console.WriteLine("Removed entry at index {0}...", index);
        }

        public override string ListAllEntries()
        {
            //Console.WriteLine("Entries: \n   Array: {0} List: {1} Dictionary: {2}\n", _array.Length, list.Count, dictionary.Count);

            var output = "";
            output += "Content:";
            
            output += " Array: " + _array.ListAllEntries();

            output += " List: " + _list.ListAllEntries();

            output += " Dictionary: " + _dictionary.ListAllEntries() + "\n";

            return output;
        }
    }
}