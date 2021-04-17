using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class DFS
    {
        Graph graph;
        List<VertexInfo> infos;

        public DFS(Graph graph)
        {
            this.graph = graph;
        }
        void InitInfo()
        {
            infos = new List<VertexInfo>();
            foreach (var v in graph.Vertices)
            {
                infos.Add(new VertexInfo(v));
            }
        }
        VertexInfo GetVertexInfo(Vertex v)
        {
            foreach (var i in infos)
            {
                if (i.Vertex.Equals(v))
                {
                    return i;
                }
            }
            return null;
        }
        public void DeepFind(string startName)
        {
            InitInfo();
            DeepFind(startName, infos);
        }
        public void DeepFind(string startName, List<VertexInfo> infos)
        {
            var startVertex = graph.FindVertex(startName);
            var first = GetVertexInfo(startVertex);
            Console.Write(first.Vertex.Name + " ");
            first.IsUnvisitied = false;
            var connectedList = GetNearVerties(first);
            foreach (var i in connectedList)
            {
                if (i.IsUnvisitied)
                {
                    DeepFind(i.Vertex.Name, infos);
                }
            }
        }
        List<VertexInfo> GetNearVerties(VertexInfo info)
        {
            var connectedList = new List<VertexInfo>();
            foreach (var e in info.Vertex.Edges)
            {
                connectedList.Add(GetVertexInfo(e.ConnectedVertex));
            }
            return connectedList;
        }
    }
}