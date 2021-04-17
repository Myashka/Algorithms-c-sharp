using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vertex
    {
        public string Name { get; }
        public List<Edge> Edges { get; }
        public Vertex(string vertexName)
        {
            this.Name = vertexName;
            Edges = new List<Edge>();
        }
        public void AddEdge(Edge newEdge)
        {
            Edges.Add(newEdge);
        }
        public void AddEdge(Vertex vertex, int edgeWeigth)
        {
            AddEdge(new Edge(vertex, edgeWeigth));
        }
        public void AddEdge(Vertex vertex)
        {
            AddEdge(new Edge(vertex));
        }
        public override string ToString() => Name;
    }
}
