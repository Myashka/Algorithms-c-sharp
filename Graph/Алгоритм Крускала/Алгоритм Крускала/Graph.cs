using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Алгоритм_Крускала
{
    class Graph
    {
        private List<Tuple<int, Edge>> G;
        private List<Tuple<int, Edge>> T;
        private int V;
        private int[] parent;
        public Graph(int vertices)
        {
            this.V = vertices;
            parent = new int[V];
            G = new List<Tuple<int, Edge>>();
            T = new List<Tuple<int, Edge>>();
            for (int i = 0; i < V; i++)
            {
                parent[i] = i;
            }
            if (G.Count != 0)
                G.Clear();
            if (T.Count != 0)
                T.Clear();
        }
        public void addEdge(int u, int v,int w)
        {
            G.Add(Tuple.Create(w, new Edge(u, v)));
        }
        int findSet(int i)
        {
            if (i == parent[i])
                return i;
            else
                return findSet(parent[i]);
        }
        void unionSet(int u,int v)
        {
            parent[u] = parent[v];
        }
        public void kruskal()
        {
            int i, uRep, vRep;
            var result = G.OrderBy(u => u.Item1);
            var gResult = new List<Tuple<int, Edge>>();
            foreach (var e in result)
            {
                gResult.Add(e);
            }
            for (i = 0; i < gResult.Count; i++)
            {
                uRep = findSet(gResult[i].Item2.v1);
                vRep = findSet(gResult[i].Item2.v2);
                if (uRep != vRep)
                {
                    T.Add(gResult[i]);
                    unionSet(uRep, vRep);
                }
            }
        }
        public void print()
        {
            Console.WriteLine("Edge :" + " Weight");
            for (int i = 0; i < T.Count; i++)
            {
                Console.WriteLine(T[i].Item2.v1 + " - " + T[i].Item2.v2 + " : " + T[i].Item1);
            }
        }
    }
}
