
using Structurydanychprojekt2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Structurydanychprojekt2;

using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public class Graph
    {
        //Tworzy graf poprzez podanie listy krawędzi
        public Graph(int numberofVertices, Lista<Edge> edges)
        {
            NumberofVertices = numberofVertices;
            Edges = edges;
        }
        //Tworzy graf poprzez podanie listy sąsiedztwa
        public Graph(int numberofVertices, Lista<Lista<Edge>> Listedges)
        {
            NumberofVertices = numberofVertices;
            NeighbourList = Listedges;
        }
        //Tworzy graf poprzez podanie macierzy sąsiedztwa
        public Graph(int numberofVertices, int[,] Matrixedges)
        {
            NumberofVertices = numberofVertices;
            AdjecencyMatrix = Matrixedges;
        }

        public int NumberofVertices { get; set; }
        public Lista<Edge> Edges { get; set; }
        public Lista<Lista<Edge>> NeighbourList { get; set; }
        public int[,] AdjecencyMatrix { get; set; }
        
        public PriorityQueue<Edge> MakePriorityQueue()
        {
            var MyPriorityQueue = new PriorityQueue<Edge>();
            for(int i = 0; i < Edges.Count(); i++)
            {
                MyPriorityQueue.Push(Edges.Get(i), Edges.Get(i).Weight);
            }
            return MyPriorityQueue;
        }
        
        public void MakeAdjacencyMatrix()
        {
            int[,] Matrix = new int[NumberofVertices + 1, NumberofVertices + 1];
            for (int i = 0; i < NumberofVertices; i++)
                for (int j = 0; j < NumberofVertices + 1; j++)
                    Matrix[i, j] = 0;
            for (int i = 0; i < Edges.Count(); i++)
            {
                //Matrix[TabofEdges[i, 0], TabofEdges[i, 1]] = 1;
                Matrix[Edges.Get(i).StartVertices, Edges.Get(i).EndVertices] = Edges.Get(i).Weight;
                Matrix[Edges.Get(i).EndVertices, Edges.Get(i).StartVertices] = Edges.Get(i).Weight; ;
            }
            //PrintGraph(Matrix, NumberofVertices + 1);
            AdjecencyMatrix = Matrix;
        }

        public void MakeNeighbourList()
        {
            Lista<Lista<Edge>> NewLista = new Lista<Lista<Edge>>();
            for (int i = 0; i < NumberofVertices; i++)
            {
                NewLista.AddToEnd(new Lista<Edge>());
            }
            for (int i = 0; i < Edges.Count(); i++)
            {
                var x = NewLista.Get(Edges.Get(i).StartVertices);
                x.AddToEnd(Edges.Get(i));
            }
            NeighbourList = NewLista;
        }

        public void AddEdge(int startvertices, int endvertives, int weight)
        {
            Edge NewEdge = new Edge(startvertices, endvertives, weight);
            Edges.AddToEnd(NewEdge);
        }

        public void PrintGraph()
        {
            if (NeighbourList == null && AdjecencyMatrix != null)
            {
                Console.Write("  ");
                for (int i = 0; i < NumberofVertices; i++)
                    Console.Write("{0} ", i);
                Console.WriteLine();
                for (int i = 0; i < NumberofVertices; i++)
                {
                    Console.Write("{0} ", i);
                    for (int j = 0; j < NumberofVertices; j++)
                    {
                        //Console.Write("{0} ", i);
                        Console.Write("{0} ", AdjecencyMatrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (NeighbourList != null && AdjecencyMatrix == null)
            {
                for (int i = 0; i < NumberofVertices; i++)
                {
                    Console.Write("{0}: ", i);
                    for (int j = 0; j < NeighbourList.Get(i).Count(); j++)
                    {
                        Console.Write("({0} : {1})", NeighbourList.Get(i).Get(j).EndVertices, NeighbourList.Get(i).Get(j).Weight);
                    }
                    Console.WriteLine();
                }
            }
        }

        public Graph MSTusingLista()
        {
            var Helper = new KruskalAlgorithm();
            var MyMinTreeList = Helper.FindMinTreeUsingLista(Edges, NumberofVertices);
            var MyMinTreeGraph = new Graph(NumberofVertices, MyMinTreeList);
            //MyMinTreeGraph.MakeAdjacencyMatrix();
            //Console.WriteLine("MST of these graph: ");
            //MyMinTreeGraph.PrintGraph();
            return MyMinTreeGraph;
        }
        public Graph MSTusingPriotityQueue()
        {
            var Helper = new KruskalAlgorithm();
            var MyMinTreeList = Helper.FindMinTreeUsingPriorityQueue(MakePriorityQueue(), NumberofVertices);
            var MyMinTreeGraph = new Graph(NumberofVertices, MyMinTreeList);
            //MyMinTreeGraph.MakeAdjacencyMatrix();
           // Console.WriteLine("MST of these graph: ");
           // MyMinTreeGraph.PrintGraph();
            return MyMinTreeGraph;
        }
        public void ShowMST(Graph graph)
        {
            Console.WriteLine("MST of these graph: ");
            graph.PrintGraph();
        }
    }
}
