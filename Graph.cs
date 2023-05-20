using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public class Graph
    {
        public Graph(int NumberofVerticles, Lista<Edge> edges)
        {
            this.NumberofVerticles = NumberofVerticles;
            this.Edges = edges;
            this.NumberofEdges = edges.Count();
        }
        public Graph(int NumberofVerticles, PriorityQueue<Edge> edges)
        {
            this.NumberofVerticles = NumberofVerticles;
            this.PriorityQueueEdges = edges;
            this.NumberofEdges = edges.Count;
        }
        public Lista<Edge> Edges;
        public PriorityQueue<Edge> PriorityQueueEdges;
        public int NumberofVerticles { get; set; }
        public int NumberofEdges { get; set; } 
    }
}
