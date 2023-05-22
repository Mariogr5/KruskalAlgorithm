using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structurydanychprojekt2;

namespace Structurydanychprojekt2
{
    public class Edge
    {
        public Edge(int startVertices, int endVertices, int weight)
        {
            StartVertices = startVertices;
            EndVertices = endVertices;
            Weight = weight;
        }

        public int StartVertices { get; set; }
        public int EndVertices { get; set; }
        public int Weight { get; set; }
    }
}
