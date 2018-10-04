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
            Console.WriteLine("Name Entry Manager for Array, List & Dictionary. \n\n");
            
            var nameEntryManager = new NameEntryManager();

            // 0. Create array, list and dictionary.
            nameEntryManager.InitDataStructures(); 

            // 1. Take three strings.

            // 2. Add the strings.

            // 3. Retrieve string at position x.

            // 4. Remove entry at position x.

            // 5. List all entries in order.

            Console.ReadLine();
        }
    }
}
