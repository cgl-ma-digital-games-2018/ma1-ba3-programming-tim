using System;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace cgl_programming_ba3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task: Create name entry manager with one entry.
            Console.WriteLine("Name Entry Manager for Array, List & Dictionary.\n");
            
            var nameEntryManager = new NameEntryManager("One");
            Console.WriteLine("Initialized array, list and dictionary with first entry... \n ");

            // Task: List all entries in order.
            nameEntryManager.ListAllEntries();


            // Task: add another entry to the end.
            nameEntryManager.AddEntryAtEnd("Two");

            Console.WriteLine("Added another entry to the end...");
            nameEntryManager.ListAllEntries();

            // Task: Add entry at position x.
            int index = 1;
            nameEntryManager.AddEntryAtIndex(index, "Three");

            Console.WriteLine("Added entry at index {0}...", index);
            nameEntryManager.ListAllEntries();

            // Task: Retrieve entry at index x.
            index = 2;
            Console.WriteLine("Entry at index {0}: {1}...\n", index, nameEntryManager.GetEntryAtIndex(index));
            
            // Task: Remove entry at index x.
            nameEntryManager.RemoveEntryAtIndex(index);
            Console.WriteLine("Removed entry at index {0}...", index);
            nameEntryManager.ListAllEntries();

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
