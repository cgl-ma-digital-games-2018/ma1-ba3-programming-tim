using System;
using System.Collections.Generic;
using System.Deployment.Internal;

namespace cgl_programming_ba3_01
{
    internal class NameEntryManager
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

            
        }

        public void AddEntryAtIndex(int index, string entry)
        {
            _list.AddEntryAtIndex(index, entry);
            _dictionary.AddEntryAtIndex(index, entry);
        }

        public void AddEntryAtEnd(string entry)
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
        }

        public string GetEntryAtIndex(int index)
        {
            var listEntry = "List: " + _list.GetEntryAtIndex(index);
            var dictionaryEntry = "Dictionary: " + _dictionary.GetEntryAtIndex(index);

            return listEntry + " " + dictionaryEntry;
        }

        public void RemoveEntryAtIndex(int index)
        {
            _list.RemoveEntryAtIndex(index);
            _dictionary.RemoveEntryAtIndex(index);
        }

        public void ListAllEntries()
        {
            //Console.WriteLine("Entries: \n   Array: {0} List: {1} Dictionary: {2}\n", array.Length, list.Count, dictionary.Count);

            Console.WriteLine("Content:");
            //foreach (var entry in array)
            //{
            //    Console.Write(entry + ", ");
            //}

            Console.WriteLine(" List: " + _list.ListAllEntries());

            Console.WriteLine(" Dictionary: " + _dictionary.ListAllEntries());

            Console.WriteLine("\n");
        }
    }
}