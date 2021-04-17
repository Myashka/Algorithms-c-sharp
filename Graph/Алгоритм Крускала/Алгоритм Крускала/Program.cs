using System;

namespace Алгоритм_Крускала
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph(8);
            graph.addEdge(0, 1, 6);
            graph.addEdge(1, 2, 19);
            graph.addEdge(0, 3, 17);
            graph.addEdge(0, 4, 11);
            graph.addEdge(3, 4, 8);
            graph.addEdge(1, 4, 25);
            graph.addEdge(4, 5, 2);
            graph.addEdge(5, 6, 14);
            graph.addEdge(2, 6, 9);
            graph.addEdge(5, 7, 21);


            graph.kruskal();
            graph.print();
        }
    }
}
