
using Grafy.Tests;
using Structurydanychprojekt2;
using System.Data;
using System.Linq.Expressions;

//Lista<Edge> TabofEdges = new Lista<Edge>();
//TabofEdges.AddToFront(new Edge(1, 2, 8));
//TabofEdges.AddToFront(new Edge(2, 3, 4));
//TabofEdges.AddToFront(new Edge(3, 4, 5));
//TabofEdges.AddToFront(new Edge(0, 1, 6));
//TabofEdges.AddToFront(new Edge(3, 4, 1));
//TabofEdges.AddToFront(new Edge(0, 2, 4));
//TabofEdges.AddToFront(new Edge(3, 4, 5));
//TabofEdges.AddToFront(new Edge(0, 3, 2));
//
//Graph Mygraph = new Graph(5, TabofEdges);
////Mygraph.MSTusingLista();
//Mygraph.ShowMST(Mygraph.MSTusingLista());
//Mygraph.MakeNeighbourList();
//Mygraph.PrintGraph();
double[] MyTimes = new double[6];
MyTimes = GetTimes.MakeNeighbourListGraphTimes(0.1);
//Console.WriteLine("Listgraph: {0} s",Testgraph.TestAdjacencyMatrix(80, 0.1));
for (int i = 0; i < 6; i++)
    Console.WriteLine("Listgraph: {0} s", MyTimes[i]);
