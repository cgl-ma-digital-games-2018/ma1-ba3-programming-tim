using System;
using System.Collections.Generic;
using System.Deployment.Internal;

namespace cgl_programming_ba3_01
{
    internal class NameEntryManager :DataStructure
    {
        private readonly ListDataStructure _list = null;
        private readonly DictionaryDataStructure _dictionary = null;

        private string[] array = null;

        public NameEntryManager(string firstEntry)
        {
            _list = new ListDataStructure(firstEntry);
            _dictionary = new DictionaryDataStructure(firstEntry);
            
            //array = new[] {firstEntry};
            //dictionary = new Dictionary<int, string> {{0, firstEntry}};

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

            // Array.
            //var newArray = new string[array.Length + 1];
            //for (var i = 0; i < array.Length; i++)
            //{
            //    newArray[i] = array[i];
            //}

            //array = newArray;

            //// TODO: QUESTION: No need to manually garbage collect, right?
            //newArray = null;

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
            //Console.WriteLine("Entries: \n   Array: {0} List: {1} Dictionary: {2}\n", array.Length, list.Count, dictionary.Count);

            var output = "";
            output += "Content:";
            //foreach (var entry in array)
            //{
            //    Console.Write(entry + ", ");
            //}

            output += " List: " + _list.ListAllEntries();

            output += " Dictionary: " + _dictionary.ListAllEntries() + "\n";

            return output;
        }
    }
}