using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_graphs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var graphManager = new GraphManager();

            var firstNode = new Node("firstNode", 0);
            var secondNode = new Node("secondNode", 1);

            graphManager.AddEdge(firstNode, secondNode);

            Console.WriteLine(graphManager.OutputSet());

            Console.ReadKey();
        }
    }
}