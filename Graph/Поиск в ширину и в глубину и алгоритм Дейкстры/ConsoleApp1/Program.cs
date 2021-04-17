using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Graph unweightedGraph = new Graph();
            unweightedGraph.AddVertex("A");
            unweightedGraph.AddVertex("C");
            unweightedGraph.AddVertex("B");
            unweightedGraph.AddVertex("D");
            unweightedGraph.AddVertex("E");
            unweightedGraph.AddVertex("F");
            unweightedGraph.AddVertex("G");
            unweightedGraph.AddVertex("H");

            unweightedGraph.AddEdge("A", "B");
            unweightedGraph.AddEdge("B", "C");
            unweightedGraph.AddEdge("C", "D");
            unweightedGraph.AddEdge("B", "D");
            unweightedGraph.AddEdge("B", "E");
            unweightedGraph.AddEdge("F", "E");
            unweightedGraph.AddEdge("G", "E");
            unweightedGraph.AddEdge("G", "H");
            unweightedGraph.AddEdge("D", "H");

            var dfs = new DFS(unweightedGraph);
            Console.WriteLine("Поиск в грубину от вершины B:");
            dfs.DeepFind("B");

            Console.WriteLine("\n");

            var bfs = new BFS(unweightedGraph);
            Console.WriteLine("Поиск в ширину от вершины B:");
            bfs.BreadthFind("B");

            Console.WriteLine("\n");

            Graph weightedGraph = new Graph();
            weightedGraph.AddVertex("A");
            weightedGraph.AddVertex("B");
            weightedGraph.AddVertex("C");
            weightedGraph.AddVertex("D");
            weightedGraph.AddVertex("E");
            weightedGraph.AddVertex("F");
            weightedGraph.AddVertex("G");
            weightedGraph.AddVertex("H");

            weightedGraph.AddEdge("A", "B", 1);
            weightedGraph.AddEdge("B", "C", 10);
            weightedGraph.AddEdge("C", "D", 5);
            weightedGraph.AddEdge("B", "D", 30);
            weightedGraph.AddEdge("B", "E", 11);
            weightedGraph.AddEdge("F", "E", 29);
            weightedGraph.AddEdge("G", "E", 16);
            weightedGraph.AddEdge("G", "H", 14);
            weightedGraph.AddEdge("D", "H", 9);



            var dijkstra = new Dijkstra(weightedGraph);
            var path = dijkstra.FindMinPath("A", "H");
            Console.WriteLine("Путь от вершины A до H");
            Console.Write(path);
            Console.WriteLine("\n");

        }
    }
}
