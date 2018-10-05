using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Runtime.InteropServices;

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
            
            Console.WriteLine("Initialized array, list and dictionary with first entry.\n");
        }

        public override void AddEntryAtIndex(int index, string entry)
        {
            Console.WriteLine("Adding entry at index {0}...", index);
            _list.AddEntryAtIndex(index, entry);
            _dictionary.AddEntryAtIndex(index, entry);
        }

        public override void AddEntryAtEnd(string entry)
        {
            Console.WriteLine("Adding another entry to the end...");

            _array.AddEntryAtEnd(entry);
            _list.AddEntryAtEnd(entry);
            _dictionary.AddEntryAtEnd(entry);
        }

        public override string GetEntryAtIndex(int index)
        {
            var listEntry = "List: " + _list.GetEntryAtIndex(index);
            var dictionaryEntry = "Dictionary: " + _dictionary.GetEntryAtIndex(index);

            return listEntry + " " + dictionaryEntry;
        }

        public override void RemoveEntryAtIndex(int index)
        {
            Console.WriteLine("Removing entry at index {0}...", index);

            _list.RemoveEntryAtIndex(index);
            _dictionary.RemoveEntryAtIndex(index);
        }

        public override string ListAllEntries()
        {
            Console.WriteLine("Listing all entries...");

            var output = "";
            output += "Content: \n";
            output += " Array: " + _array.ListAllEntries() + "\n";
            output += " List: " + _list.ListAllEntries() + "\n";
            output += " Dictionary: " + _dictionary.ListAllEntries() + "\n";

            return output;
        }
    }
}