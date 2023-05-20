
using Structurydanychprojekt2;
using System.Data;
using System.Linq.Expressions;
using System.Xml.Schema;
using TspLibNet;
//using TspLibNet.Graph.Edges;
using TspLibNet.TSP;

int[,] Mytab = new int[4, 2] { {2, 3},{ 1, 3 },{ 1, 2 },{ 1, 3 } };
Lista<Edge> TabofEdges = new Lista<Edge>();
TabofEdges.AddToFront(new Edge(1, 2, 3));
TabofEdges.AddToFront(new Edge(2, 3, 4));
TabofEdges.AddToFront(new Edge(3, 4, 5));
Graph Mygraph = new Graph(5, TabofEdges);
//var MyRepresentation = Graphrepresentation.AdjacencyMatrix(true, Mygraph);
var MyRepresentation = Graphrepresentation.NeighbourList(Mygraph);
//Graphrepresentation.PrintGraph(MyRepresentation);
//var Mygraph = Graph.NeighbourList(4, 4, Mytab);
string path = "C:\\Users\\mario\\Desktop\\Strukturydanych\\Strukturydanychprojekt2\\Structurydanychprojekt2\\Datas\\a280.xml";
    //try
//{
//    string path = "C:\\Users\\mario\\Desktop\\Strukturydanych\\Strukturydanychprojekt2\\Structurydanychprojekt2\\Datas\\a280.xml";
//    foreach (var line in File.ReadLines("C:\\Users\\mario\\Desktop\\Strukturydanych\\Strukturydanychprojekt2\\Structurydanychprojekt2\\Datas\\a280.xml"))
//        Console.WriteLine(line);
//    TravelingSalesmanProblem FromFile(path);
//}
//catch
//{
//    Console.WriteLine("Plik nie otwarł się");
//    
//}
//
