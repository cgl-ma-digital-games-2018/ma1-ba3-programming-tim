using System;

namespace L04_trees
{
    internal class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode(T node)
        {
        }
    }

    internal class Node<T>
    {
        public NodeList<T> NodeList { get; }
        public T Data { get; }

        public Node()
        {
        }

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