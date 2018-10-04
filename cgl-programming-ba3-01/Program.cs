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
            Console.WriteLine("Name Entry Manager for Array, List & Dictionary. \n");
            
            // 1. Create name entry manager with one string.
            var nameEntryManager = new NameEntryManager("One");
            nameEntryManager.ListAllEntries();


            // 2. add another string to the end.
            nameEntryManager.AddEntryAtEnd("Two");
            Console.WriteLine("Added another string to the end.");
            nameEntryManager.ListAllEntries();

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
