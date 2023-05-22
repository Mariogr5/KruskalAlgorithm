using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public static class Swapper
    {
        public static void Swap(Edge one, Edge two)
        {
            int TempStartVertex = one.StartVertices;
            int TempEndVertex = one.EndVertices;
            int tempWeight = one.Weight;
            one.StartVertices = two.StartVertices;
            two.StartVertices = TempStartVertex;
            one.EndVertices = two.EndVertices;
            two.EndVertices = TempEndVertex;
            one.Weight = two.Weight;
            two.Weight = tempWeight;
        }
    }
}
