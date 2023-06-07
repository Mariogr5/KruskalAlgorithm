using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy.Tests
{
    public static class GetTimes
    {
        public static double[] MakeAdjacencyMatrixGraphTimes(double density)
        {
            double[] graphTimes = new double[6];
            int z = 10;
            graphTimes[0] = Testgraph.TestAdjacencyMatrix(z, density);
            z += 10;
            graphTimes[1] = Testgraph.TestAdjacencyMatrix(z, density);
            z += 30;
            graphTimes[2] = Testgraph.TestAdjacencyMatrix(z, density);
            z += 30;
            graphTimes[3] = Testgraph.TestAdjacencyMatrix(z, density);
            z += 20;
            graphTimes[4] = Testgraph.TestAdjacencyMatrix(z, density);
            z += 25;
            graphTimes[5] = Testgraph.TestAdjacencyMatrix(z, density);

            return graphTimes;

        }
        public static double[] MakeNeighbourListGraphTimes(double density)
        {
            double[] graphTimes = new double[6];
            int z = 10;
            graphTimes[0] = Testgraph.TestNeighbourList(z, density);
            z += 10;
            graphTimes[1] = Testgraph.TestNeighbourList(z, density);
            z += 30;
            graphTimes[2] = Testgraph.TestNeighbourList(z, density);
            z += 30;
            graphTimes[3] = Testgraph.TestNeighbourList(z, density);
            z += 20;
            graphTimes[4] = Testgraph.TestNeighbourList(z, density);
            z += 25;
            graphTimes[5] = Testgraph.TestNeighbourList(z, density);

            return graphTimes;

        }
        public static double[] MakeListGraphTimes2(double density)
        {
            double[] graphTimes = new double[7];
            int z = 10;
            for(int i = 0; i < 7; i ++)
            {
                graphTimes[i] = Testgraph.TestListGraph(z, density);
                z += 10;
            }
            return graphTimes;

        }
        public static double[] MakePriorityQueueGraphTimes(double density)
        {
            double[] graphTimes = new double[7];
            int z = 10;
            for (int i = 0; i < 7; i++)
            {
                graphTimes[i] = Testgraph.TestQueueGraph(z, density);
                z += 10;
            }
            return graphTimes;

        }
    }
}
