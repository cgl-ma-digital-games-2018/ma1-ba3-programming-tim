using System.Collections.Generic;

namespace L03_graphs
{
    public class GraphManager
    {
        public List<Node> Nodes { get; private set; } = new List<Node>();
        public List<Edge> Edges { get; private set; } = new List<Edge>();

        //public void AddNode(string name, int position)
        //{
        //    Nodes.Add(new Node(name, position));
        //}

        public void AddEdge(Node nodeA, Node nodeB, float weight)
        {
            Edges.Add(new Edge(nodeA, nodeB, weight));
        }

        public string OutputSet()
        {
            string output = "{";

            foreach (var edge in Edges)
            {
                output += "({" + edge.Nodes[0].Name + "," + edge.Nodes[1].Name + "}" + ", " + edge.Weight + ") ,";
            }

            output += "}";

            return output;
        }
    }
}