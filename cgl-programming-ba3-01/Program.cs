using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgl_programming_ba3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourArray = new string[] { "josh", "tim", "manuel" };
            Console.WriteLine("Array solution: \n");

            Console.WriteLine();

            PrintArray(ourArray);

            Console.WriteLine("Entry at index 1; " + ourArray[1] + "\n");

            ourArray[2] = "";

            PrintArray(ourArray);
            Console.WriteLine();

            Console.WriteLine("Please enter 3 names to overwrite! \n");
            ourArray[0] = Console.ReadLine();
            ourArray[1] = Console.ReadLine();
            ourArray[2] = Console.ReadLine();

            PrintArray(ourArray);

            Console.WriteLine();
            Console.WriteLine("List solution: \n");
            var ourList = new List<string>() { "josh", "tim", "manuel" };

            var itemNumber = 1;
            itemNumber = PrintList(ourList, itemNumber);

            //Console.WriteLine("Please enter the list index you wish to display! \n");

            Console.WriteLine("Item at list index 0: " + ourList[0] + "\n)");
            Console.WriteLine("Removing manuel");
            ourList.Remove("manuel");
            PrintList(ourList, itemNumber);

            Console.ReadLine();
        }

        private static int PrintList(List<string> ourList, int itemNumber)
        {
            foreach (var item in ourList)
            {

                Console.WriteLine("Item" + itemNumber++ + ": " + item);
            }

            return itemNumber;
        }

        private static void PrintArray(string[] ourArray)
        {
            for (int i = 0; i < ourArray.Length; i++)
            {
                Console.WriteLine("Entry " + i + ": " + ourArray[i]);
            }
        }
    }
}
