using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dijkstra
    {
        Graph graph;
        List<VertexInfo> infos;
        public Dijkstra(Graph graph)
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
        public VertexInfo FindMinSumVertex()
        {
            var minValue = int.MaxValue;
            VertexInfo minVertexInfo = null;
            foreach (var i in infos)
            {
                if (i.IsUnvisitied && i.EdgeWeightSum < minValue)
                {
                    minVertexInfo = i;
                    minValue = i.EdgeWeightSum;
                }
            }
            return minVertexInfo;
        }
        void SetSumToNextVertex(VertexInfo info)
        {
            info.IsUnvisitied = false;
            foreach(var e in info.Vertex.Edges)
            {
                var nextInfo = GetVertexInfo(e.ConnectedVertex);
                var sum = info.EdgeWeightSum + e.Weight;
                if (sum < nextInfo.EdgeWeightSum)
                {
                    nextInfo.EdgeWeightSum = sum;
                    nextInfo.PreviousVertex = info.Vertex;
                }
            }
        }
        string GetPath(Vertex startVertex, Vertex endVertex)
        {
            var path = endVertex.ToString();
            while (startVertex != endVertex)
            {
                endVertex = GetVertexInfo(endVertex).PreviousVertex;
                path = endVertex.ToString() + path;
            }
            return path;
        }

        public string FindMinPath(Vertex startVertex, Vertex finishVertex)
        {
            InitInfo();
            var first = GetVertexInfo(startVertex);
            first.EdgeWeightSum = 0;
            while (true)
            {
                var current = FindMinSumVertex();
                if (current == null)
                    break;
                SetSumToNextVertex(current);
            }
            return GetPath(startVertex, finishVertex);
        }
        public string FindMinPath(string startName, string finishName)
        {
            return FindMinPath(graph.FindVertex(startName), graph.FindVertex(finishName));
        }
    }
}
