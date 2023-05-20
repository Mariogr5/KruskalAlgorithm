using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public static class Graphrepresentation
    {
        //private static Graph Graphy { get; set; }
        public static int[,] AdjacencyMatrix(bool IfIsDirected, Graph Graphy)
        {
            int[,] Matrix = new int[Graphy.NumberofVerticles + 1, Graphy.NumberofVerticles + 1];
            for (int i = 0; i < Graphy.NumberofVerticles; i++)
                for (int j = 0; j < Graphy.NumberofVerticles + 1; j++)
                    Matrix[i, j] = 0;
            for (int i = 0; i < Graphy.NumberofEdges; i++)
            {
                //Matrix[TabofEdges[i, 0], TabofEdges[i, 1]] = 1;
                Matrix[Graphy.Edges.Get(i).StartVertex, Graphy.Edges.Get(i).EndVertex] = Graphy.Edges.Get(i).Weight;
                if (IfIsDirected)
                    Matrix[Graphy.Edges.Get(i).EndVertex, Graphy.Edges.Get(i).StartVertex] = Graphy.Edges.Get(i).Weight; ;
            }
            PrintGraph(Matrix, Graphy.NumberofVerticles + 1);
            return Matrix;
        }

        public static UsedList[] NeighbourList(Graph Graphy)
        {
            var Matrix = new int[Graphy.NumberofVerticles, Graphy.NumberofEdges];

            //Lista<Lista<Edge>> Matrix1 = new Lista<Lista<Edge>>();//[NumberofVertices];
            UsedList[] Matrix1 = new UsedList[Graphy.NumberofVerticles];
            for (int i = 0; i < Graphy.NumberofVerticles; i++)
                //Matrix1.AddToFront(new Lista<Edge>());
                Matrix1[i] = null;
            for (int i = 0; i < Graphy.NumberofEdges; i++)
            {
                //var NewList = Matrix1.Get(i);
                var NewList = new UsedList();
                NewList.Number = Graphy.Edges.Get(i).EndVertex;//TabofEdges[i, 1];
                NewList.weight = Graphy.Edges.Get(i).Weight;
                NewList.Next = Matrix1[Graphy.Edges.Get(i).StartVertex]; //Matrix1[TabofEdges[i, 0]];
                Matrix1[Graphy.Edges.Get(i).StartVertex] = NewList;
                //Matrix1.Set(Graphy.Edges.Get(i).StartVertex, NewList);
                //[TabofEdges[i, 0]]
                //Matrix1[i].Add(i);
            }
            PrintGraph(Matrix1, Graphy.NumberofVerticles);
            return Matrix1;
        }


        //public static int[,] IncidentMatrix(int NumberofVertices, int NumberofEdges, int[,] TabofEdges)
        //{
        //    var Matrix = new int[NumberofVertices, NumberofEdges];
        //    for (int i = 0; i < NumberofVertices; i++)
        //        for (int j = 0; j < NumberofVertices; j++)
        //            Matrix[i, j] = 0;
        //    for (int i = 0; i < NumberofEdges; i++)
        //    {
        //        Matrix[TabofEdges[i, 0], TabofEdges[i, 1]] = 1;
        //        Matrix[TabofEdges[i, 1], TabofEdges[i, 0]] = -1;
        //    }
        //    PrintGraph(Matrix, NumberofVertices);
        //    return Matrix;
        //}
        public static void PrintGraph(int[,] tab, int Size)
        {
            Console.Write("  ");
            for (int i = 0; i < Size; i++)
                Console.Write("{0} ", i);
            Console.WriteLine();
            for (int i = 0; i < Size; i++)
            {
                Console.Write("{0} ", i);
                for (int j = 0; j < Size; j++)
                {
                    //Console.Write("{0} ", i);
                    Console.Write("{0} ", tab[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void PrintGraph(UsedList[] Matrix, int NumberofVerticles)
        {
            for (int i = 0; i < NumberofVerticles; i++)
            {
                Console.Write("{0} ", i);
                //Lista<Edge> Templist = Matrix.Get(i);
                UsedList Templist = Matrix[i];
                while (Templist != null)
                {
                    Console.Write("{0}:{1}", Templist.Number, Templist.weight);
                    Templist = Templist.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
