using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Алгоритм_Крускала
{
    class Edge
    {
        public int v1 { get; }
        public int v2 { get; }
        private Tuple<int , int> pair;
        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            pair = Tuple.Create(v1, v2);
        }
    }
}
