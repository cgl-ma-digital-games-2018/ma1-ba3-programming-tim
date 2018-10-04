using System;
using System.Collections.Generic;

namespace cgl_programming_ba3_01
{
    class NameEntryManager
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

            PrintDataStructures();
        }
   
        
        // 2. add another string to the end.

        // 2.1 Add entry in the middle.

        // 3. Retrieve string at position x.

        // 4. Remove entry at position x.

        // 5. List all entries in order.

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

        public void PrintDataStructures()
        {
            Console.WriteLine("Length: \n   Array: {0} List: {1} Dictionary: {2}\n", array.Length, list.Capacity, dictionary.Count);

            Console.WriteLine("Content: \n   Array:\n");
            foreach (var entry in array)
            {
                Console.WriteLine(entry + "\n");
            }

            Console.WriteLine("Content: \n   List:\n");
            Console.WriteLine("Content: \n   Dictionary:\n");

        }
    }
}