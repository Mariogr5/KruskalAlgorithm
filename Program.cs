
using Structurydanychprojekt2;
using System.Data;
using System.Linq.Expressions;

Lista<Edge> TabofEdges = new Lista<Edge>();
TabofEdges.AddToFront(new Edge(1, 2, 8));
TabofEdges.AddToFront(new Edge(2, 3, 4));
TabofEdges.AddToFront(new Edge(3, 4, 5));
TabofEdges.AddToFront(new Edge(0, 1, 6));
TabofEdges.AddToFront(new Edge(3, 4, 1));
TabofEdges.AddToFront(new Edge(0, 2, 4));
TabofEdges.AddToFront(new Edge(3, 4, 5));
TabofEdges.AddToFront(new Edge(0, 3, 2));

Graph Mygraph = new Graph(5, TabofEdges);
Mygraph.ShowMST();
Mygraph.MakeAdjacencyMatrix();
Mygraph.PrintGraph();