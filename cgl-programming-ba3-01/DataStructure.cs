namespace cgl_programming_ba3_01
{
    internal abstract class DataStructure<T>
    {
        private readonly T _t;

        protected DataStructure(T t)
        {
            _t = t;
        }

        protected abstract void AddEntryAtEnd(string entry);

        protected abstract void AddEntryAtPosition(string entry, int position);

        protected abstract string GetEntryAtPosition(int position);

        protected abstract void RemoveEntryAtPosition(int position);

        protected abstract string ListAllEntries();
    }
}