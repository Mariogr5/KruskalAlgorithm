using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public class KruskalAlgorithm
    {
        public Lista<Edge> FindMinTreeUsingLista(Lista<Edge> Edges, int NumberofVerticles)
        {
            Lista<Edge> Result = new Lista<Edge>();
            QuickSortList(Edges, 0, Edges.Count() - 1);
            int[] parent = new int[NumberofVerticles];
            for (int i = 0; i < NumberofVerticles; i++)
            {
                parent[i] = i;
            }
            int edgeCount = 0;
            int index = 0;
            while (edgeCount < NumberofVerticles - 1)
            {
                Edge currentEdge = Edges.Get(index++);
                int sourceParent = FindParent(parent, currentEdge.StartVertices);
                int destinationParent = FindParent(parent, currentEdge.EndVertices);

                if (sourceParent != destinationParent)
                {
                    Result.AddToEnd(currentEdge);
                    Union(parent, sourceParent, destinationParent);
                    edgeCount++;
                }
            }
            return Result;
        }
        public Lista<Edge> FindMinTreeUsingPriorityQueue(PriorityQueue<Edge> Edges, int NumberofVerticles)
        {
            Lista<Edge> Result = new Lista<Edge>();
            int[] parent = new int[NumberofVerticles];
            for (int i = 0; i < NumberofVerticles; i++)
            {
                parent[i] = i;
            }
            int edgeCount = 0;
            int index = 0;
            while (edgeCount < NumberofVerticles - 1)
            {
                Edge currentEdge = Edges.Get(index++);
                int sourceParent = FindParent(parent, currentEdge.StartVertices);
                int destinationParent = FindParent(parent, currentEdge.EndVertices);

                if (sourceParent != destinationParent)
                {
                    Result.AddToEnd(currentEdge);
                    Union(parent, sourceParent, destinationParent);
                    edgeCount++;
                }
            }
            return Result;
        }
        private int FindParent(int[] parent, int vertex)
        {
            if (parent[vertex] != vertex)
            {
                parent[vertex] = FindParent(parent, parent[vertex]);
            }
            return parent[vertex];
        }

        private void Union(int[] parent, int x, int y)
        {
            int xRoot = FindParent(parent, x);
            int yRoot = FindParent(parent, y);
            parent[yRoot] = xRoot;
        }




        public static void QuickSortList(Lista<Edge> tab, int left, int right)
        {
            int i = left;
            int j = right;
            double srodek = tab.Get(right).Weight;
            do
            {
                while (tab.Get(i).Weight < srodek)
                    i++;

                while (tab.Get(j).Weight > srodek)
                    j--;

                if (i <= j)
                {
                    Swapper.Swap(tab.Get(i), tab.Get(j));
                    i++;
                    j--;
                }
            } while (i <= j);

            if (right > i)
                QuickSortList(tab, i, right);
            if (left < j)
                QuickSortList(tab, left, j);
        }
    }
}
