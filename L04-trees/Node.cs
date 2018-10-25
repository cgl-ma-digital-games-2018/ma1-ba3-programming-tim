namespace L04_trees
{
    internal class Node<T>
    {
        public NodeList<T> NodeList { get; }
        public T Data { get; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, NodeList<T> nodeList) : this(data)
        {
            NodeList = nodeList;
        }
    }
}