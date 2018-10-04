namespace cgl_programming_ba3_01
{
    internal interface IDataStructure
    {
        void AddEntryAtEnd(string entry);

        void AddEntryAtPosition(string entry, int position);

        void GetEntryAtPosition(int position);

        void RemoveEntryAtPosition(int position);

        void ListAllEntries();
    }
}