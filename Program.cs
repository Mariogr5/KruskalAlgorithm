
using Grafy.Tests;
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

//Graph Mygraph = new Graph(5, TabofEdges);
////Mygraph.MSTusingLista();
//Mygraph.ShowMST(Mygraph.MSTusingLista());
//Mygraph.MakeAdjacencyMatrix();
//Mygraph.PrintGraph();




Console.WriteLine("Listgraph: {0} s",Testgraph.TestListGraph(10, 0.1));
Console.WriteLine("Queuegraph: {0} s", Testgraph.TestQueueGraph(50, 0.1));
//MyConverter.XMLTOJson("C:\\Users\\mario\\Desktop\\Strukturydanych\\Strukturydanychprojekt2\\StrukturydanychProjekt2\\KruskalAlgorithm\\Xml-s\\a280.xml");

