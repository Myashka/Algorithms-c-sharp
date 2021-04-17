using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VertexInfo
    {
        public Vertex Vertex { get; set; }
        public bool IsUnvisitied { get; set; }
        public int EdgeWeightSum { get; set; }
        public Vertex PreviousVertex { get; set; }
        public VertexInfo(Vertex vertex)
        {
            Vertex = vertex;
            IsUnvisitied = true;
            EdgeWeightSum = int.MaxValue;
            PreviousVertex = null;
        }
    }
}
