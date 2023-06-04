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
            Stopwatch stopper = new Stopwatch();

            var graph = MakeGraph(size, density);
            stopper.Start();
            var MST = graph.MSTusingLista();
            stopper.Stop();
            //graph.ShowMST(MST);
            return stopper.Elapsed.TotalSeconds;
        }

        public static double TestQueueGraph(int size, double density)
        {
            var graph = MakeGraph(size, density);
            Stopwatch stopper = new Stopwatch();
            //var graph = MakeGraph(size);
            stopper.Start();
            var MST = graph.MSTusingPriotityQueue();
            stopper.Stop();
            //graph.ShowMST(MST);
            return stopper.Elapsed.TotalSeconds;
        }



        public static Graph MakeGraph(int numberofvertexs, double density)
        {
            int numberofedges = (int)(0.5 * (density * (numberofvertexs * (numberofvertexs - 1))));
            //density = 2 * numberofedges / (numberofvertexs * (numberofvertexs - 1));
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

       // public static Graph MakeQueueGraph(int size)
       // {
       //     Random random = new Random();
       //     PriorityQueue<Edge> Mylist = new PriorityQueue<Edge>();
       //
       //     for (int i = 0; i < size; i++)
       //     {
       //         Mylist.(new Edge(i, size - i, random.Next()));
       //     }
       //     Graph Mygraph = new Graph(size, Mylist);
       //     return Mygraph;
       // }
    }
}
