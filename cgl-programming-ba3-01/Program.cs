using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgl_programming_ba3_01
{
    class Program
    {
        //#region FIELDS
        private static string[] _ourArray = new string[] { "josh", "tim", "manuel" };
        //#endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Array solution: \n");

            Console.WriteLine();

            PrintArray(_ourArray);

            Console.WriteLine("Entry at index 1; " + _ourArray[1] + "\n");

            _ourArray[2] = "";

            PrintArray(_ourArray);
            Console.WriteLine();

            Console.WriteLine("Please enter 3 names to overwrite! \n");
            _ourArray[0] = Console.ReadLine();
            _ourArray[1] = Console.ReadLine();
            _ourArray[2] = Console.ReadLine();

            PrintArray(_ourArray);

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

        private static int PrintList(List<string> list, int itemNumber)
        {
            foreach (var item in list)
            {

                Console.WriteLine("Item" + itemNumber++ + ": " + item);
            }

            return itemNumber;
        }

        private static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Entry " + i + ": " + array[i]);
            }
        }
    }
}
