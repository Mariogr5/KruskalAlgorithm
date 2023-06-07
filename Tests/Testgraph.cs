using Structurydanychprojekt2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy.Tests
{
    public static class Testgraph
    {
        public static double TestListGraph(int size, double density)
        {
            double Aritmeticaverage = 0;
            for (int i = 0; i < 1; i++)
            {
                Stopwatch stopper = new Stopwatch();
                var graph = MakeGraph(size, density);
                stopper.Start();
                var MST = graph.MSTusingLista();
                stopper.Stop();
                double c = stopper.Elapsed.TotalSeconds;
                stopper.Reset();
                Aritmeticaverage += c;
            }
            Aritmeticaverage /= 5;
            return Aritmeticaverage;
        }

        public static double TestQueueGraph(int size, double density)
        {
            double Aritmeticaverage = 0;
            for (int i = 0; i < 5; i++)
            {
                var graph = MakeGraph(size, density);
                Stopwatch stopper = new Stopwatch();
                //var graph = MakeGraph(size);
                stopper.Start();
                var MST = graph.MSTusingPriotityQueue();
                stopper.Stop();
                double c = stopper.Elapsed.TotalSeconds;
                stopper.Reset();
                Aritmeticaverage += c;
            }
            Aritmeticaverage /= 5;
            return Aritmeticaverage;
        }


        public static double TestAdjacencyMatrix(int size, double density)
        {
            double AritmetivAverage = 0;
            for (int i = 0; i < 5; i++)
            {
                var graph = MakeGraph(size, density);
                Stopwatch stopper = new Stopwatch();
                stopper.Start();
                graph.MakeAdjacencyMatrix();
                stopper.Stop();
                var c = stopper.Elapsed.TotalSeconds;
                stopper.Reset();
                AritmetivAverage += c;
            }
            AritmetivAverage /= 5;
            return AritmetivAverage;
        }
        public static double TestNeighbourList(int size, double density)
        {
            double AritmetivAverage = 0;
            for (int i = 0; i < 5; i++)
            {
                var graph = MakeGraph(size, density);
                Stopwatch stopper = new Stopwatch();
                stopper.Start();
                graph.MakeNeighbourList();
                stopper.Stop();
                var c = stopper.Elapsed.TotalSeconds;
                stopper.Reset();
                AritmetivAverage += c;
            }
            AritmetivAverage /= 5;
            return AritmetivAverage;
        }


        public static Graph MakeGraph(int numberofvertexs, double density)
        {
            int numberofedges = (int)(0.5 * (density * (numberofvertexs * (numberofvertexs - 1))));
            Random random = new Random();
            Lista<Edge> Mylist = new Lista<Edge>();
            int z = 0;
            for(int i = 0; i < numberofvertexs; i++)
            {
                z = i;
                for (int j = 0; j < numberofedges; j++)
                {
                    if (z == numberofvertexs - 1)
                        z = 0;
                    Mylist.AddToFront(new Edge(i, z + 1, 20));
                }
            }
            Graph Mygraph = new Graph(numberofvertexs, Mylist);
            return Mygraph;
        }
    }
}
