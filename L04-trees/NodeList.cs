using System.Collections.ObjectModel;

namespace L04_trees
{
    internal class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base()
        {
        }

        public NodeList(int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
            {
                base.Items.Add(default(Node<T>));
            }
        }

        public Node<T> FindByValue(T value)
        {
            foreach (var node in Items)
            {
                // TODO: Comparison ok or need node.value.equals?
                if (node.Equals(value))
                {
                    return node;
                }
            }

            return null;
        }
    }
}