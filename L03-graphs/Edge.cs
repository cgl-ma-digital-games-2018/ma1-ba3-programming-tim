using System.Collections.Generic;

namespace L03_graphs
{
    public class Edge
    {
        public Node[] Nodes { get; private set; } = new Node[2];
        public float Weight { get; set; } = 0.0f;

        public Edge(Node nodeA, Node nodeB)
        {
            Nodes[0] = nodeA;
            Nodes[1] = nodeB;
        }
    }
}