using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public class Edge
    {
        public Edge(int startvertex, int endvertex, int weight)
        {
            this.StartVertex = startvertex;
            this.EndVertex = endvertex;
            this.Weight = weight;
        }
        public int StartVertex { get; set; }
        public int EndVertex { get; set; }

        public int Weight { get; set; }
    }
}
