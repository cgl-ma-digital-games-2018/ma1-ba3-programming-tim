﻿using System;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace L02DataStructureIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task: Create name entry manager with one entry.
            Console.WriteLine("Name Entry Manager for Array, List & Dictionary.\n\n");
            
            var nameEntryManager = new NameEntryManager("One");

            // Task: List all entries in order.
            Console.WriteLine(nameEntryManager.ListAllEntries());

            // Task: add another entry to the end.
            nameEntryManager.AddEntryAtEnd("Two");
            Console.WriteLine(nameEntryManager.ListAllEntries());

            // Task: Add entry at index x.
            var index = 1;
            nameEntryManager.AddEntryAtIndex(index, "Three");
            Console.WriteLine(nameEntryManager.ListAllEntries());

            // Task: Retrieve entry at index x.
            index = 2;
            Console.WriteLine(nameEntryManager.GetEntryAtIndex(index));
            
            // Task: Remove entry at index x.
            nameEntryManager.RemoveEntryAtIndex(index);
            Console.WriteLine(nameEntryManager.ListAllEntries());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
