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
           var newArray = new string[_data.Length + 1];

            for (var i = 0; i < _data.Length; i++)
            {
                newArray[i] = _data[i];
            }
            _data = newArray;
            // TODO: QUESTION: No need to manually garbage collect, right?
            newArray = null;

            _data[_data.Length - 1] = entry;
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