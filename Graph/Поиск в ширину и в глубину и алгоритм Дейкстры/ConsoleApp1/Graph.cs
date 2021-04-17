using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Graph
    {
        private int numVertices;
        private LinkedList<int>[] vertices;
        private bool[] visited;
        public List<Vertex> Vertices { get; }
        public Graph()
        {
            Vertices = new List<Vertex>();
        }
        public Graph(int numVerticles)
        {
            this.numVertices = numVerticles;
            this.vertices = new LinkedList<int>[numVerticles];
            this.visited = new bool[numVerticles];
            for (int i = 0; i < numVerticles; ++i)
                vertices[i] = new LinkedList<int>();
        }
        public void ResetGraph()
        {
            visited = new bool[numVertices];
        }
        public void AddVertex(string verticleName)
        {
            Vertices.Add(new Vertex(verticleName));
        }
        public Vertex FindVertex(string vertexName)
        {
            foreach (var v in Vertices)
            {
                if (v.Name.Equals(vertexName))
                {
                    return v;
                }
            }

            return null;
        }
        public void AddEdge(string firstName, string secondName, int weight)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2 != null && v1 != null)
            {
                v1.AddEdge(v2, weight);
                v2.AddEdge(v1, weight);
            }
        }

        public void AddEdge(string firstName, string secondName)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2 != null && v1 != null)
            {
                v1.AddEdge(v2);
                v2.AddEdge(v1);
            }
        }
    }
}
