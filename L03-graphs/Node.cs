using System.Reflection.Emit;

namespace L03_graphs
{
    public class Node
    {
        public string Name { get; private set; }
        public int Position { get; private set; }

        public Node(string name, int position)
        {
            Name = name;
            Position = position;
        }
    }
}