using System;

namespace cgl_programming_ba3_01
{
    internal class ArrayDataStructure : DataStructure
    {
        private string[] _data = null;

        public ArrayDataStructure(string firstEntry)
        {
            _data = new string[] { firstEntry };
        }

        public override void AddEntryAtEnd(string entry)
        {
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

        public override void AddEntryAtIndex(int index, string entry)
        {
            throw new NotImplementedException();
        }

        public override string GetEntryAtIndex(int index)
        {
            throw new NotImplementedException();
        }

        public override void RemoveEntryAtIndex(int index)
        {
            throw new NotImplementedException();
        }

        public override string ListAllEntries()
        {
            var output = "";

            foreach (var entry in _data)
            {
                output += entry + ", ";
            }

            return output;
        }
    }
}