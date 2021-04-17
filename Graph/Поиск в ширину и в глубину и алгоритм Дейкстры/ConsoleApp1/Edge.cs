using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Edge
    {
        public Vertex ConnectedVertex { get; }
        public int Weight { get; }
        public Edge(Vertex connectedVertex, int weight)
        {
            ConnectedVertex = connectedVertex;
            Weight = weight;
        }
        public Edge(Vertex connectedVertex)
        {
            ConnectedVertex = connectedVertex;
        }
    }
}
