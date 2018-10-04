﻿using System;
using System.Collections.Generic;
using System.Deployment.Internal;

namespace cgl_programming_ba3_01
{
    internal class ArrayDataStructure : DataStructure<>
    {
        public void AddEntryAtEnd(string entry)
        {
            throw new NotImplementedException();
        }

        public void AddEntryAtPosition(string entry, int position)
        {
            throw new NotImplementedException();
        }

        public void GetEntryAtPosition(int position)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntryAtPosition(int position)
        {
            throw new NotImplementedException();
        }

        public void ListAllEntries()
        {
            throw new NotImplementedException();
        }
    }

    internal class NameEntryManager
    {
        private string[] array = null;
        private List<string> list = null;
        private Dictionary<int, string> dictionary = null;

        public NameEntryManager(string firstEntry)
        {
            array = new[] {firstEntry};
            list = new List<string>() {firstEntry};
            dictionary = new Dictionary<int, string> {{0, firstEntry}};

            Console.WriteLine("...initialized array, list and dictionary with first entry... \n \n");

            ListAllEntries();
        }
   
        
        // 2. add another string to the end.

        // 2.1 Add entry in the middle.

        // 3. Retrieve string at position x.

        // 4. Remove entry at position x.

        // 5. List all entries in order.

        public void AddEntryAtPosition(int position)
        {
            throw new NotImplementedException();
        }

        public void AddEntryAtEnd(string entry)
        {
            // Array.
            var newArray = new string[array.Length + 1];
            for (var i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;

            // TODO: QUESTION: No need to manually garbage collect, right?
            newArray = null;

            // List.
            list.Add(entry);

            // Dictionary.
            dictionary.Add(dictionary.Count + 1, entry);
        }

        public void GetEntryAtPosition(int position)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntryAtPosition(int position)
        {
            throw new NotImplementedException();
        }

        public void ListAllEntries()
        {
            Console.WriteLine("Entries: \n   Array: {0} List: {1} Dictionary: {2}\n", array.Length, list.Count, dictionary.Count);

            Console.WriteLine("Content: \n  Array:");
            foreach (var entry in array)
            {
                Console.Write(entry + ", ");
            }

            Console.WriteLine("\n\n List:");
            foreach (var entry in list)
            {
                Console.Write(entry + ", ");
            }

            Console.WriteLine("\n\n Dictionary:");
            foreach (var entry in dictionary)
            {
                Console.Write(entry + ", ");
            }

            Console.WriteLine("\n");
        }
    }
}