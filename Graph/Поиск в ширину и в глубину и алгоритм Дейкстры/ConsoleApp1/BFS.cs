using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class BFS
    {
        Graph graph;
        List<VertexInfo> infos;

        public BFS(Graph graph)
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
        public void BreadthFind(string startName)
        {
            InitInfo();
            var startVertex = graph.FindVertex(startName);
            var first = GetVertexInfo(startVertex);
            var visited = new List<bool>();
            for (int i=0; i < infos.Count; i++)
            {
                visited.Add(infos[i].IsUnvisitied);
                visited[i] = false;
            }

            LinkedList<VertexInfo> queue = new LinkedList<VertexInfo>();
            visited[infos.IndexOf(first)] = true;
            queue.AddLast(first);
            while (queue.Any())
            {
                first = queue.First();
                Console.Write(first.Vertex.Name + " ");
                queue.RemoveFirst();
                var connectedList = GetNearVerties(first);
                foreach (var val in connectedList)
                {
                    if(!visited[infos.IndexOf(val)])
                    {
                        visited[infos.IndexOf(val)] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }

        List<VertexInfo> GetNearVerties(VertexInfo info)
        {
            var connectedList = new List<VertexInfo>();
            
            foreach (var e in info.Vertex.Edges)
            {
                var nextInfo = GetVertexInfo(e.ConnectedVertex);
                connectedList.Add(nextInfo);
            }
            return connectedList;
        }
    }
}
